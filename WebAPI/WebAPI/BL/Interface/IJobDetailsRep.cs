using WebAPI.DAL.Entities;

namespace WebAPI.BL.Interface
{
    public interface IJobDetailsRep
    {
        Task<Job> GetJobDetailsAsync(int id);
    }
}
