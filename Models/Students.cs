using System.ComponentModel.DataAnnotations;

namespace StdMgtSystem.Models
{
    public class Students
    {
        public int StudentId { get; set; }
        [Required]
        [MaxLength(50, ErrorMessage = "Name cannot exceed 50 characters")]
        public string Name { get; set;}
        [Required]
        public string Branch { get; set;}
        [Required]
        public string Section {  get; set;}
        [Required]
        public string Gender { get; set;}
        
    }
}
