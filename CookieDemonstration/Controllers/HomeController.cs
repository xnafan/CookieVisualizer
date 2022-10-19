using CookieDemonstration.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;

namespace CookieDemonstration.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index() => View();

        public IActionResult DeleteCookie([FromQuery] string cookiename)
        {
            Response.Cookies.Delete(cookiename);
            return Redirect(nameof(Index));
        }

        public IActionResult CreateCookie([FromForm] Cookie newCookie)
        {
            Response.Cookies.Append(newCookie.CookieName, newCookie.CookieValue);
            return Redirect(nameof(Index));
        }
    }
}