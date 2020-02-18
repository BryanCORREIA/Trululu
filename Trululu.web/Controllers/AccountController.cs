using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Trululu.web.Entities;
using Trululu.web.ViewModels;

namespace Trululu.web.Controllers
{
    public class AccountController : Controller
    {       
        [HttpGet]
        public IActionResult Index()
        {
            var user = User.Identity as ClaimsIdentity;
            var utilisateurId = user.FindFirst(ClaimTypes.Sid);

            return View(user);
        }
    }
}
