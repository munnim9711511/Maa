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
    public class HomeController : Controller {
        private readonly DataContext _db;
        public HomeController (DataContext _db) {
            this._db = _db;
        }
        public IActionResult Index () {
            ViewBag.gallery = _db.GalleryModels.Where (x => x.Text == "photo").ToArray ().Take (6);
            ViewBag.anouncements = _db.anouncementsModels.ToArray ().Take (6);
            ViewBag.news = _db.NewsModels.ToArray<NewsModel> ().Take<NewsModel> (6);
            ViewBag.slider = _db.SliderModels.ToArray ().Take (4);
            ViewBag.advertise = _db.LinkModels.Where (x => x.Catogary == "advertisement").ToArray ().Take (4);
            return View (ViewBag);
        }

        [HttpGet]
        public IActionResult Cafey () {
            ViewBag.cafey = _db.CafeyModels.ToArray ();

            return View (ViewBag);
        }

        [HttpGet]
        public IActionResult Project (string id) {
            ViewBag.project = _db.LinkModels.Where (x => x.Catogary == id).ToArray ();
            return View (ViewBag.project);
        }

        [HttpGet]
        public IActionResult News () {
            ViewBag.news = _db.NewsModels.ToArray ().OrderByDescending (x => x.Id);

            return View (ViewBag);
        }

        [HttpGet]
        public IActionResult Responsibility () {
            ViewBag.responsibility = _db.LinkModels.Where (x => x.Catogary == "res").ToArray ();
            return View (ViewBag);
        }

        [HttpGet]
        public IActionResult Harbur () {
            ViewBag.harbour = _db.LinkModels.Where (x => x.Catogary == "harbour").ToArray ();
            return View (ViewBag);
        }

        [HttpGet]

        public IActionResult About () {
            ViewData["Message"] = "Your application description page.";

            return View ();
        }

        public IActionResult EngCouncil () {
            return View ();
        }
        public IActionResult EngRules () {
            return View ();
        }

        public IActionResult Contact () {
            ViewData["Message"] = "Your contact page.";

            return View ();
        }

        [HttpGet]
        public IActionResult MaamigiliContact () {

            return View ();
        }

        [HttpGet]
        public IActionResult Counciller (string id) {
            ViewBag.conciller = _db.LinkModels.Where (x => x.Catogary == id).ToArray ();
            return View (ViewBag);
        }

        [HttpGet]
        public IActionResult AdminProcess () {
            ViewBag.admin = _db.LinkModels.Where (x => x.Catogary == "Idhare").ToArray ();
            return View (ViewBag);
        }

        [HttpGet]
        public IActionResult RunningRules (string id) {
            ViewBag.runningRules = _db.LinkModels.Where (x => x.Catogary == id).ToArray ();
            return View (ViewBag);
        }

        [HttpGet]
        public IActionResult MeetingSummery (string id) {
            ViewBag.meeting = _db.LinkModels.Where (x => x.Catogary == id).ToArray ();
            return View (ViewBag);
        }

        public IActionResult VideoGallery () {
            ViewBag.videoGallery = _db.GalleryModels.Where (x => x.Text == "video").ToArray ();
            return View (ViewBag);
        }

        public IActionResult Privacy () {
            return View ();
        }
        public IActionResult Target () {
            ViewBag.mission = _db.LinkModels.Where (x => x.Catogary == "mission").ToArray ();
            ViewBag.Vission = _db.LinkModels.Where (x => x.Catogary == "vission").ToArray ();
            return View (ViewBag);
        }

        public IActionResult Services () {
            ViewBag.services = _db.LinkModels.Where (x => x.Catogary == "services").ToArray ();
            return View (ViewBag);
        }

        [ResponseCache (Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error () {
            return View (new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}