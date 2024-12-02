
namespace WebAPI.DAL.Entities
{
    public class Job
    {
        public int JobId { get; set; }
        public string Title { get; set; }
        public string Company { get; set; }
        public string Description { get; set; }
        public string Requirements { get; set; }      
        public string Location { get; set; }
        public string Photo {  get; set; }
       // public ICollection<Application> Applications { get; set; }
    }
}
