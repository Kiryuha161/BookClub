using BookClub.Data;
using BookClub.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookClub.Controllers
{
    public class BookController : Controller
    {
        private readonly BookClubDbContext _database;

        public BookController(BookClubDbContext database)
        {
            _database = database;
        }

        public IActionResult Index()
        {
            List<Book> books = _database.Books.ToList();

            return View(books);
        }

        public IActionResult MarkAsRead(int? id)
        {
            var book = _database.Books.FirstOrDefault(x => x.Id == id);
            if (book != null)
            {
                book.IsRead = true;
                _database.SaveChanges();
                return RedirectToAction("Index");
            }
            return NotFound();
        }

        public IActionResult MarkAsUnread(int? id)
        {
            var book = _database.Books.FirstOrDefault(x => x.Id == id);
            if (book != null )
            {
                book.IsRead = false;
                _database.SaveChanges();
                return RedirectToAction("Index");
            }
            return NotFound();
        }
    }
}
