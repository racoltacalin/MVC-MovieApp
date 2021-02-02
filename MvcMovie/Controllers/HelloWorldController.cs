using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: /HelloWorld
        public IActionResult Index()
        {
            return View();
        }

        // Get: /HelloWorld/Welcome/
        public string Welcome(string name, int ID = 1)
        {
            // Uses HtmlEncoder.Default.Encode to protect the app from malicious input (namely JavaScript)
            return HtmlEncoder.Default.Encode($"Hello {name}, ID: {ID}");
        }
    }
}
