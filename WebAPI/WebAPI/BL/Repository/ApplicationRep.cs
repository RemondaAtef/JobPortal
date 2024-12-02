using WebAPI.BL.Interface;
using WebAPI.DAL.Database;
using WebAPI.DAL.Entities;

namespace WebAPI.BL.Repository
{
    public class ApplicationRep : IApplicationRep
    {
        private readonly DataContext dc;
        public ApplicationRep(DataContext dc) 
        {
            this.dc = dc;
        }
        public void AddApplication(Application app)
        {
            dc.Applications.AddAsync(app);
        }

       
    }
}
