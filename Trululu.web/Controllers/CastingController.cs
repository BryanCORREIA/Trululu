<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
=======
﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
>>>>>>> 0984396bd013328c84554674dddc01a61636a76a
using Trululu.web.Filters;
using Trululu.web.ViewModels;

namespace Trululu.web.Controllers
{
<<<<<<< HEAD

=======
>>>>>>> 0984396bd013328c84554674dddc01a61636a76a
    public class CastingController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [LogFilter]
<<<<<<< HEAD
        public IActionResult AjouterCasting(CastingViewModel contactViewModel)
=======
        public IActionResult AddCasting(CastingViewModel castingViewModel)
>>>>>>> 0984396bd013328c84554674dddc01a61636a76a
        {
            if (ModelState.IsValid)
            {
                //TODO SAVE Database
<<<<<<< HEAD
                return RedirectToAction("Index", "Casting");
            }
            else
            {
                return View(new CastingViewModel());
            }
        }

    }
}
=======
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return View(castingViewModel);
            }
        }
    }
}
>>>>>>> 0984396bd013328c84554674dddc01a61636a76a
