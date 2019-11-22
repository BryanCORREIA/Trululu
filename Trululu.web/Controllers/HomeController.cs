using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Trululu.web.Filters;
using Trululu.web.ViewModels;

namespace Trululu.web.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        [LogFilter]
        public IActionResult Contact(ContactViewModel contactViewModel)
        {
            if (ModelState.IsValid)
            {
                //TODO SAVE Database
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return View(contactViewModel);
            }
        }
    }
}