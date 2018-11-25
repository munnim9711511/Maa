﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using coouncil.Models;
using Coun.Data;
using Coun.Models;
using Microsoft.AspNetCore.Mvc;

namespace Coun.Controllers {
    public class EngPageController : Controller {
        private readonly DataContext _db;
        public EngPageController (DataContext _db) {
            this._db = _db;
        }

        public IActionResult AboutIsland () {
            ViewBag.about = _db.LinkModels.Where (x => x.Catogary == "aboutIslandEn").ToArray ();
            return View (ViewBag);
        }
        public IActionResult GovermentAuthorities () {
            ViewBag.govAuth = _db.LinkModels.Where (x => x.Catogary == "govermentAutEn").ToArray ();
            return View (ViewBag);
        }
        public IActionResult AirportEn () {
            ViewBag.air = _db.LinkModels.Where (x => x.Catogary == "airportEn").ToArray ();
            return View (ViewBag);
        }

        public IActionResult HarbourEn () {
            ViewBag.harbourEn = _db.LinkModels.Where (x => x.Catogary == "harbourEn").ToArray ();
            return View (ViewBag);
        }

        public IActionResult SpecialLocEn () {
              ViewBag.history = _db.ImportantLocationModels.ToArray ();
            return View (ViewBag);
        }

        public IActionResult GuestHouseEn () {
            ViewBag.ghouseEn = _db.GuestHousesModels.ToArray ();
            return View (ViewBag);
        }
        public IActionResult CafeyEn () {
            ViewBag.cafeyEn = _db.LinkModels.Where (x => x.Catogary == "cafeyEn").ToArray ();
            return View (ViewBag);
        }
        public IActionResult BussinesEn () {
            ViewBag.bussinesEn = _db.LinkModels.Where (x => x.Catogary == "bussinesEn").ToArray ();
            return View (ViewBag);
        }

        [HttpGet]
        public IActionResult HistoryEng () {
            ViewBag.history = _db.ImportantLocationModels.ToArray ();
            return View (ViewBag);
        }

    }
}