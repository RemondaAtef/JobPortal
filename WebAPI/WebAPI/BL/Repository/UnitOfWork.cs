using WebAPI.BL.Interface;
using WebAPI.DAL.Database;

namespace WebAPI.BL.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DataContext dc;
        public UnitOfWork(DataContext dc)
        {
            this.dc = dc;
        }
        public IJobRep JobRep => 
            new JobRep(dc);       

        public IApplicationRep ApplicationRep => new ApplicationRep(dc);

        public IJobDetailsRep DetailsRep => new JobDetailsRep(dc);

        public async Task<bool> SaveAsync()
        {
            return await dc.SaveChangesAsync() > 0;
        }
    }
}
