using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public string Welcome(string firstName="Eric", string lastName="Dee", int id = 1)
        {
            return HtmlEncoder.Default.Encode($"Hello {firstName} {lastName}, id: {id}");
        }

        public IActionResult WelcomeWithContext(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;

            return View();
        }
    }
}
