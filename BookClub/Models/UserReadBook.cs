using System.ComponentModel.DataAnnotations;

namespace BookClub.Models
{
    public class UserReadBook
    {
        [Key]
        public int Id { get; set; }
        public int UserId { get; set; }
        public int BookId { get; set; }
        public bool IsRead { get; set; }
    }
}
