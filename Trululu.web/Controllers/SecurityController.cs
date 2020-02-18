using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Trululu.web.Filters;
using Trululu.web.ViewModels;

namespace Trululu.web.Controllers
{
    public class SecurityController : Controller
    {
        private IEnumerable<Claim> GetRoleClaims()
        {
            yield return new Claim(ClaimTypes.Role, "ROLE_ADMIN");
        }

        [HttpGet]
        public IActionResult SignIn()
        {
            return View(new SignInViewModel());
        }

        [HttpPost]
        [LogFilter]
        public async Task<IActionResult> SignInAsync(SignInViewModel signinViewModel)
        {
            if (ModelState.IsValid)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Sid, "1"),
                    new Claim(ClaimTypes.NameIdentifier, "Bryan")
                };
                claims.AddRange(GetRoleClaims());
                var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity));

                //TODO SAVE Database

                return RedirectToAction("Index", "Home");
            }
            return View(signinViewModel);
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

        [HttpGet]
        public IActionResult Logout()
        {
            return View(new SignUpViewModel());
        }
    }
}
