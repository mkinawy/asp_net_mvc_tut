using AspNetMvcTut.Models;
using AspNetMvcTut.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetMvcTut.Controllers
{
    public class UsersController : Controller
    {
        public IActionResult Index()
        {
            //return RedirectToAction("Index", "Home");
            //return View("../Home/Index");
            var users = UsersRepository.GetAll();
            return View(users);
        }

        [HttpPost("users")]
        public IActionResult Register(UserModel user)
        {
            // validation: done
            // store: done
            UsersRepository.Add(user);

            // return success message
            return View("Thanks", user);
        }
    }
}
