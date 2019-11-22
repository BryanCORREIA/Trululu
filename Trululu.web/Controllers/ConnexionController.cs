using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Trululu.web.ViewModels;

namespace Trululu.web.Controllers
{
    public class ConnexionController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View(new ConnexionViewModel());
        }

        public IActionResult Index(ConnexionViewModel connexionViewModel)
        {
            if (ModelState.IsValid)
            {
                //TODO SAVE Database
                return RedirectToAction("Index", "Home");
            }
            return View(connexionViewModel);
        }
    }
}
