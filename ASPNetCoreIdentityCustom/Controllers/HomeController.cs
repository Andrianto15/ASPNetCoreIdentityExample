using ASPNetCoreIdentityCustom.Areas.Identity.Data;
using ASPNetCoreIdentityCustom.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ASPNetCoreIdentityCustom.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly UserManager<ApplicationUser> _userManager;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            if (!User.Identity.IsAuthenticated) return LocalRedirect("/Identity/Account/Login");
            //if (!_signInManager.IsSignedIn(User)) return LocalRedirect("/Identity/Account/Login");    // error
            //if (_userManager.GetUserAsync(User) == null) return LocalRedirect("/Identity/Account/Login");    // error

            return View();
        }

        public IActionResult Privacy()
        {
            if (!User.Identity.IsAuthenticated) return LocalRedirect("/Identity/Account/Login");
            //if (!_signInManager.IsSignedIn(User)) return LocalRedirect("/Identity/Account/Login");    // error
            //if (_userManager.GetUserAsync(User) == null) return LocalRedirect("/Identity/Account/Login");    // error

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}