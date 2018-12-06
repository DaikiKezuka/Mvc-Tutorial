using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MvcTutorial.Controllers
{
    public class HelloWorldController : Controller
    {
        // Get:/JelloWorld/
        //public string Index()
        //{
        //    return "This is my default action...";
        //}

        public IActionResult Index()
        {
            return View();
        }

        // Get:/HelloWorld/Welcome/
        // Requires using System.Text.Encodings.Web;
        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello" + name;
            ViewData["NumTimes"] = numTimes;

            return View();
        }
    }
}
