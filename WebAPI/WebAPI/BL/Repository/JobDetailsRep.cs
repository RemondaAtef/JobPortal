using Microsoft.EntityFrameworkCore;
using WebAPI.BL.Interface;
using WebAPI.DAL.Database;
using WebAPI.DAL.Entities;

namespace WebAPI.BL.Repository
{
    public class JobDetailsRep : IJobDetailsRep
    {
        private readonly DataContext dc;
        public JobDetailsRep(DataContext dc)
        {
            this.dc = dc;
        }
      
        public async Task<Job> GetJobDetailsAsync(int id)
        {
            return await dc.Jobs.FindAsync(id);
        }       
    }
}
