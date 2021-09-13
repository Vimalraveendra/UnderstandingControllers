using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UnderstandingControllers.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace UnderstandingControllers.Controllers
{
    public class HomeController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ReceivedDataByRequest()
        {
            string name = Request.Form["name"];
            string sex = Request.Form["sex"];
            return View("ReceivedDataByRequest", $"{name} sex is {sex}");
        }

        public IActionResult ReceivedDataByParameter(string name, string sex)
        {
            return View("ReceivedDataByParameter", $"{name} sex is {sex}");
        }

        public IActionResult ReceivedDataByModelBinding(Person person)
        {
            return View("ReceivedDataByModelBinding",person);
        }
    }
}
