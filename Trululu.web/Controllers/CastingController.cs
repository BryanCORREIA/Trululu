using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Trululu.web.Filters;
using Trululu.web.ViewModels;

namespace Trululu.web.Controllers
{

    public class CastingController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [LogFilter]
        public IActionResult AjouterCasting(CastingViewModel contactViewModel)
        {
            if (ModelState.IsValid)
            {
                //TODO SAVE Database
                return RedirectToAction("Index", "Casting");
            }
            else
            {
                return View(new CastingViewModel());
            }
        }

    }
}