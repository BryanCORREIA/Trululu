using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Trululu.web.ViewModels;

namespace Trululu.web.Controllers
{
    public class SecurityController : Controller
    {
        [HttpGet]
        public IActionResult Connexion()
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
        [HttpGet]
        public IActionResult Inscription()
        {
            return View(new InscriptionViewModel());
        }

        public IActionResult Index(InscriptionViewModel inscriptionViewModel)
        {
            if (ModelState.IsValid)
            {
                //TODO SAVE Database
                return RedirectToAction("Index", "Home");
            }
            return View(inscriptionViewModel);
        }
    }
}
