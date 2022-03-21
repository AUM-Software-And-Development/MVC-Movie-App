using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        public string Index()
        {
            return "This is my default action...";
        }

        public string Welcome(string firstName="Eric", string lastName="Dee", int id = 1)
        {
            return HtmlEncoder.Default.Encode($"Hello {firstName} {lastName}, id: {id}");
        }
    }
}
