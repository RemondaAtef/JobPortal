using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPI.DAL.Entities
{
    public class Application
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string? Resume { get; set; } 
        public int JobId { get; set; }

        [ForeignKey("JobId")]
        public Job Job { get; set; }
    }
}
