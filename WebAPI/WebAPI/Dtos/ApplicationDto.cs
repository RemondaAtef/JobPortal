using System.ComponentModel.DataAnnotations;

namespace WebAPI.Dtos
{
    public class ApplicationDto
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Name is mandatory field")]
        [RegularExpression(".*[a-zA-Z]+.*", ErrorMessage = "Only numerics are not allowed")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Email is mandatory field")]
        [EmailAddress(ErrorMessage = "You Must Enter Valid Mail")]
        public string Email { get; set; }

       // [Required(ErrorMessage = "Resume is mandatory field")]
        public string? Resume { get; set; }
        public int JobId { get; set; }
    }
}
