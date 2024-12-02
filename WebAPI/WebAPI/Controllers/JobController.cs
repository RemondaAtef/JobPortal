using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAPI.BL.Interface;
using WebAPI.DAL.Database;
using WebAPI.Dtos;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobController : ControllerBase
    {
        private readonly IUnitOfWork uow;
        private readonly IMapper mapper;
        public JobController(IUnitOfWork uow, IMapper mapper)
        {
            this.uow = uow;
            this.mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetJobs()
        {          
            var jobs = await uow.JobRep.GetJobsAsync();
                       
            var jobsDto = mapper.Map<IEnumerable<JobDto>>(jobs);

            return Ok(jobsDto);
        }
    }
}
