using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Trululu.web.Data;
using Trululu.web.Entities;
using Trululu.web.Filters;
using Trululu.web.ViewModels;

namespace Trululu.web.Controllers
{
    public class CastingController : Controller
    {
        private readonly ICastingRepository _castingRepository;

        public CastingController(ICastingRepository castingRepository)
        {
            _castingRepository = castingRepository;
        }

        public IActionResult Index()
        {
            var castings = _castingRepository.GetAllCastings();
            return View(castings);
        }

        public IActionResult Casting(int id)
        {
            var casting = _castingRepository.GetCastingById(id);
            return View(casting);
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

