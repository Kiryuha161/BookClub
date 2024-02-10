using BookClub.Data;
using BookClub.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace BookClub.Controllers
{
    public class AccountController : Controller
    {
        private const string SESSION_USERNAME_KEY = "Username";
        private readonly BookClubDbContext _database;

        public AccountController(BookClubDbContext database)
        {
            _database = database; 
        }

        public IActionResult Index()
        {
            ViewData["HttpContext"] = HttpContext;
            return View();
        }

        [HttpPost]
        public IActionResult Login(string name)
        {
            var existingUser = _database.Logins.FirstOrDefault(x => x.Name == name);
            if (existingUser == null)
            {
                _database.Logins.Add(new Login
                {
                    Name = name
                });
                _database.SaveChanges();

                HttpContext.Session.SetString(SESSION_USERNAME_KEY, name);
            }
            else
            {
                HttpContext.Session.SetString(SESSION_USERNAME_KEY, existingUser.Name);
            }

            return RedirectToAction("Index", "Book");
        }

        [HttpPost]
        public IActionResult Logout()
        {
            HttpContext.Session.Remove(SESSION_USERNAME_KEY);

            return RedirectToAction("Index", "Home");
        }
    }
}

//private readonly UserManager<IdentityUser> _userManager;
/*public AccountController(UserManager<IdentityUser> userManager)
{
    _userManager = userManager;
}*/

/*[HttpPost]
public async Task<IActionResult> Login(Login model)
{
    var user = await _userManager.FindByNameAsync(model.Name);

    if (user != null)
    {
        await HttpContext.SignInAsync(IdentityConstants.ApplicationScheme, new ClaimsPrincipal(new ClaimsIdentity(new[]
        {
                new Claim(ClaimTypes.Name, model.Name)
            }, IdentityConstants.ApplicationScheme)), new AuthenticationProperties());

        await _userManager.UpdateSecurityStampAsync(user);
    }
    else
    {
        var newUser = new IdentityUser
        {
            UserName = model.Name
        };

        var result = await _userManager.CreateAsync(newUser);
        await _userManager.UpdateSecurityStampAsync(newUser);

    }

    return RedirectToAction("Index", "Book");
}*/