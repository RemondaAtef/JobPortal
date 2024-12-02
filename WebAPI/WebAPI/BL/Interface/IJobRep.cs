using WebAPI.DAL.Entities;

namespace WebAPI.BL.Interface
{
    public interface IJobRep
    {
        Task<IEnumerable<Job>> GetJobsAsync();
    }
}
