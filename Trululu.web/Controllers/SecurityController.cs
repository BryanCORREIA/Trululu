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
        public IActionResult Index()
        {
            return View(new ConnexionViewModel());
        }

        [HttpPost]
        public IActionResult SignIn(SignInViewModel signInViewModel)
        {
            if (ModelState.IsValid)
            {
                //TODO SAVE Database
                return RedirectToAction("Index", "Home");
            }
            return View(connexionViewModel);
        }
        [HttpGet]
        public IActionResult SignUp()
        {
            return View(new SignUpViewModel());
        }

        [HttpPost]
        public IActionResult SignUp(SignUpViewModel signUpViewModel)
        {
            if (ModelState.IsValid)
            {
                //TODO SAVE Database
                return RedirectToAction("Index", "Home");
            }
            return View(signUpViewModel);
        }
    }
}
