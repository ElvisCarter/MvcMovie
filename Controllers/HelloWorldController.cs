using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: /<controller>/
        //razor based template- IActionResult
        public IActionResult Index()
        {
            return View();
        }
           //THe IAction allows this to be rendered dynamically. Having to cause a value be passed through the Controller to the view in order for it to be displayed 
        public IActionResult Welcome(string name, int numTimes = 1)
        {
            //ViewData-> allows us to access these data from the View Templates
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;
            return View();
        }
        //Hard coded html into browser
        /* public string Index()
        {
            return "This is my default action...";
        }*/

        // 
        // GET: /HelloWorld/Welcome/ 

        //public string Welcome()
        //{
        //    return "This is the Welcome action method...";
        //}


 
    }
}
