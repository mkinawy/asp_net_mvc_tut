using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetMvcTut.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return Content("hello world");
        }

        [Route("welcome")]
        public string Welcome()
        {
            return "hello world";
        }

        public IActionResult Json(int id, [FromQuery(Name = "age")] int myAge = 22)
        {
            var obj = new { name = "Mahmoud", id = id, age = myAge };
            return Json(obj);
        }
    }
}
