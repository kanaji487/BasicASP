using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BasicASP.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [DisplayName("Full name")]
        public string Name { get; set; }
        [DisplayName("Test score")]
        [Range(0,100)]
        public int Score { get; set; }
    }
}