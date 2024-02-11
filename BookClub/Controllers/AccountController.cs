using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using BookClub.Models;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using BookClub.Data;
using System.Security.Claims;
using Microsoft.AspNetCore.Http;

namespace BookClub.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly BookClubDbContext _database;

        public AccountController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager, BookClubDbContext database)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _database = database;
        }

        [HttpPost]
        public async Task<IActionResult> Login(Login model)
        {
            var existingUser = await _userManager.FindByNameAsync(model.Name);
            if (existingUser == null)
            {
                var newUserIdentity = new IdentityUser
                {
                    UserName = model.Name
                };

                var result = await _userManager.CreateAsync(newUserIdentity);

                if (result.Succeeded)
                {
                    var newUser = new Login
                    {
                        Name = model.Name,
                        IsAuth = true
                    };

                    _database.Logins.Add(newUser);
                    _database.SaveChanges();

                    await _signInManager.SignInAsync(newUserIdentity, isPersistent: false);
                    var claimsPrincipal = await _signInManager.CreateUserPrincipalAsync(newUserIdentity);
                    await HttpContext.SignInAsync(IdentityConstants.ApplicationScheme, claimsPrincipal);

                    HttpContext.User = claimsPrincipal;
                    HttpContext.Session.SetString("UserId", newUser.Id.ToString());

                    return RedirectToAction("Index", "Home");
                }
            }
            else
            {
                var claimsPrincipal = await _signInManager.CreateUserPrincipalAsync(existingUser);

                await HttpContext.SignInAsync(claimsPrincipal);

                Login login = _database.Logins.FirstOrDefault(x => x.Name == model.Name);
                if (login != null)
                {
                    login.IsAuth = true;
                }

                return RedirectToAction("Index", "Home");
            }

            return RedirectToAction("Index", "Home");
        }
        
        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();

            Login login = _database.Logins.FirstOrDefault(x => x.Name == User.Identity.Name);
            if (login != null)
            {
                login.IsAuth = false;
            }

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

//private readonly BookClubDbContext _database;

//public AccountController(BookClubDbContext database)
//{
//    _database = database;
//}

//public IActionResult Index()
//{
//    ViewData["HttpContext"] = HttpContext;
//    return View();
//}

//[HttpPost]
//public IActionResult Login(string name)
//{
//    var existingUser = _database.Logins.FirstOrDefault(x => x.Name == name);
//    if (existingUser == null)
//    {
//        var newUser = new Login
//        {
//            Name = name
//        };
//        _database.Logins.Add(newUser);
//        _database.SaveChanges();

//        string sessionName = $"Session/{newUser.Name}";

//        HttpContext.Session.SetString(sessionName, name);
//    }
//    else
//    {
//        string sessionName = $"Session/{existingUser.Name}";
//        HttpContext.Session.SetString(sessionName, name);
//    }

//    return RedirectToAction("Index", "Book");
//}

//[HttpPost]
//public IActionResult Logout()
//{
//    foreach (var key in HttpContext.Session.Keys.ToList())
//    {
//        HttpContext.Session.Remove(key);
//    }

//    return RedirectToAction("Index", "Home");
//}