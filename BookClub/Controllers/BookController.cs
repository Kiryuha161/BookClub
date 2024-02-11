using BookClub.Data;
using BookClub.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.Security.Claims;

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
            ViewData["HttpContextUser"] = HttpContext.Session.GetString("UserId");

            return View(books);
        }

        [HttpPost]
        public async Task<IActionResult> MarkBookAsRead(int bookId)
        {
            var userName = User.Identity.Name;
            var user = _database.Logins.FirstOrDefault(l => l.Name == userName);

            if (user != null)
            {
                var userId = user.Id; 

                var userReadBook = new UserReadBook
                {
                    UserId = userId,
                    BookId = bookId,
                    IsRead = true
                };

                _database.UserReadBooks.Add(userReadBook);
                _database.SaveChanges();

                return RedirectToAction("Index", "Book");
            }
            else
            {
                return NotFound();
            }
        }

        [HttpPost]
        public async Task<IActionResult> MarkBookAsUnread(int bookId)
        {
            var userName = User.Identity.Name;
            var user = _database.Logins.FirstOrDefault(u => u.Name == userName);

            if (user != null)
            {
                var userId = user.Id;

                var userReadBook = _database.UserReadBooks.FirstOrDefault(ub => ub.UserId == userId && ub.BookId == bookId);

                if (userReadBook != null)
                {
                    userReadBook.IsRead = false;
                    _database.UserReadBooks.Update(userReadBook);
                    _database.SaveChanges();
                }
                
                return RedirectToAction("Index");
            }
            else
            {
                return NotFound();
            }
        }

        public IActionResult GetReadBooks()
        {
            var readBooks = _database.Books.Where(x => x.IsRead).ToList();

            return View(readBooks);
        }
    }
}
