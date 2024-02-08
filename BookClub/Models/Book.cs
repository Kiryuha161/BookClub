using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookClub.Models
{
    public class Book
    {
        [Required]
        [Key]
        public int Id { get; set; }
        [Display(Name = "Название")]
        public string Title { get; set; }
        [Display(Name = "Автор")]
        public string Author { get; set; }
        [Display(Name = "Описание")]
        public string Description { get; set; }
        [Display(Name = "Статус прочтения")]
        public bool IsRead { get; set; }
        public string ImageUrl { get; set; }

        [Display(Name = "Прочитано", AutoGenerateField = false)]
        public string IsReadDisplay
        {
            get { return IsRead ? "Прочитал" : "Не прочитал"; }
        }
    }
}
