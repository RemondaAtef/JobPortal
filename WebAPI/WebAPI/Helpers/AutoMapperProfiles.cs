using AutoMapper;
using WebAPI.DAL.Entities;
using WebAPI.Dtos;

namespace WebAPI.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<Job, JobDto>().ReverseMap();
            CreateMap<Job, JobDetailsDto>().ReverseMap();
            CreateMap<Application, ApplicationDto>().ReverseMap();
        }
    }
}
