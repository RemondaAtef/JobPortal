using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI.BL.Interface;
using WebAPI.DAL.Entities;
using WebAPI.Dtos;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobDetailsController : ControllerBase
    {
        private readonly IUnitOfWork uow;
        private readonly IMapper mapper;
        public JobDetailsController(IUnitOfWork uow, IMapper mapper)
        {
            this.uow = uow;
            this.mapper = mapper;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Job>> GetJob(int id)
        {
            var job = await uow.DetailsRep.GetJobDetailsAsync(id);

            if (job == null)
                return NotFound();

            var jobDto = mapper.Map<JobDetailsDto>(job);

            return Ok(jobDto);              
        }
    }
}
