using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI.BL.Interface;
using WebAPI.DAL.Database;
using WebAPI.DAL.Entities;
using WebAPI.Dtos;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApplicationController : ControllerBase
    {
        private readonly IUnitOfWork uow;
        private readonly IMapper mapper;

        public ApplicationController(IUnitOfWork uow, IMapper mapper)
        {
                       
            this.uow = uow;
            this.mapper = mapper;
     
        }

        [HttpPost("Add")]
        private async Task<IActionResult> WriteFile(IFormFile file, [FromForm] ApplicationDto applicationDto)
        {
            string fileName = "";

            try
            {
                var extension = "." + file.FileName.Split('.')[file.FileName.Split('.').Length - 1];
                fileName = DateTime.Now.Ticks + extension;
                var pathBuilt = Path.Combine(Directory.GetCurrentDirectory(), "files");

                if (!Directory.Exists(pathBuilt))
                {
                    Directory.CreateDirectory(pathBuilt);

                }
                var path = Path.Combine(Directory.GetCurrentDirectory(), "files", fileName);

                using (var stream = new FileStream(path, FileMode.Create))
                {
                   await file.CopyToAsync(stream);
                }

                applicationDto.Resume = fileName;

                var app = mapper.Map<Application>(applicationDto);

                uow.ApplicationRep.AddApplication(app);
                await uow.SaveAsync();

                return StatusCode(201);
            }
            catch (Exception ex)
            {

                return Ok(ex.InnerException.Message);
            }

        }

        [HttpPost("UpdateApplication")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)] 
        public async Task<IActionResult> AddNewItem(IFormFile file, [FromForm] ApplicationDto applicationDto, CancellationToken cancellationToken)
        {
            var result = await WriteFile(file, applicationDto);

            return Ok(result);
        }
    }
}
