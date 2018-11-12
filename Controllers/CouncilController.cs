using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using coouncil.Models;
using Coun.Data;
using Microsoft.AspNetCore.Mvc;

namespace Coun.Controllers {
    public class CouncilController : Controller {
        private DataContext _db;

        public CouncilController (DataContext _db) {
            this._db = _db;
        }
        public IActionResult NewsPress () {
            ViewBag.newspress = _db.LinkModels.Where (x => x.Catogary == "news press").ToArray ();
            return View (ViewBag);
        }
        public IActionResult Approved () {
            ViewBag.Approved = _db.LinkModels.Where (x => x.Catogary == "finished & aprove").ToArray ();
            return View (ViewBag);
        }
         public IActionResult Ajenda () {
            ViewBag.Ajenda = _db.LinkModels.Where (x => x.Catogary == "meeting agenda").ToArray ();
            return View (ViewBag);
        }

    }

}