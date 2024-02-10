using System.ComponentModel.DataAnnotations;

namespace BookClub.Models
{
    public class Login
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Display(Name="Логин")]
        public string Name { get; set; }
    }
} 
