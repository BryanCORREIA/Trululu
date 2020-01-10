using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Trululu.web.Filters;
using Trululu.web.ViewModels;

namespace Trululu.web.Controllers

    
{
    public class CastingController : Controller
    { 
        public IActionResult AddCasting(CastingViewModel castingViewModel)
        {
            return View();
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        [LogFilter]
        public IActionResult Add(CastingViewModel castingViewModel)
        {
            if (ModelState.IsValid)
            {
                //TODO SAVE Database
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return View(castingViewModel);
            }
        }
    }
}

