using Microsoft.EntityFrameworkCore;
using WebAPI.BL.Interface;
using WebAPI.DAL.Database;
using WebAPI.DAL.Entities;

namespace WebAPI.BL.Repository
{
    public class JobRep : IJobRep
    {
        private readonly DataContext dc;
        public JobRep(DataContext dc)
        {
            this.dc = dc;
        }
        public async Task<IEnumerable<Job>> GetJobsAsync()
        {
            return await dc.Jobs.ToListAsync();
        }
    }
}
