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
            ViewData["Title"] = "Home";
            ViewBag.gallery = _db.GalleryModels.Where (x => x.Text == "photo").ToArray ().Take (6);
            ViewBag.anouncements = _db.anouncementsModels.ToArray ().Take (6);
            ViewBag.news = _db.NewsModels.OrderByDescending(x=>x.Id).ToArray<NewsModel> ().Take<NewsModel> (6);
            ViewBag.slider = _db.SliderModels.ToArray ().Take (4);
            ViewBag.advertise = _db.LinkModels.Where (x => x.Catogary == "advertisement").ToArray ().Take (4);
            return View (ViewBag);
        }

        [HttpGet]
        public IActionResult Cafey () {
            ViewData["Title"] = "Cafey";
            ViewBag.cafey = _db.CafeyModels.ToArray ();

            return View (ViewBag);
        }

        [HttpGet]
        public IActionResult Project (string id) {
              ViewData["Title"] = "Project";
            ViewBag.project = _db.LinkModels.Where (x => x.Catogary == id).ToArray ();
            return View (ViewBag.project);
        }

        [HttpGet]
        public IActionResult News () {
              ViewData["Title"] = "News";
            ViewBag.news = _db.NewsModels.ToArray ().OrderByDescending (x => x.Id);

            return View (ViewBag);
        }

        [HttpGet]
        public IActionResult Responsibility () {
              ViewData["Title"] = "Responsibility";
            ViewBag.responsibility = _db.LinkModels.Where (x => x.Catogary == "res").ToArray ();
            return View (ViewBag);
        }

        [HttpGet]
        public IActionResult Harbur () {
              ViewData["Title"] = "Harbour";
            ViewBag.harbour = _db.LinkModels.Where (x => x.Catogary == "harbour").ToArray ();
            return View (ViewBag);
        }

        [HttpGet]

        public IActionResult About () {
            ViewData["Message"] = "Your application description page.";

            return View ();
        }

        public IActionResult EngCouncil () {
              ViewData["Title"] = "Council";
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
              ViewData["Title"] = "Contact";

            return View ();
        }

        [HttpGet]
        public IActionResult Counciller (string id) {
              ViewData["Title"] = "Council";
            ViewBag.conciller = _db.CouncilModels.OrderByDescending(x=>x.Id).ToArray();
            return View (ViewBag);
        }

        [HttpGet]
        public IActionResult AdminProcess () {
              ViewData["Title"] = "Admin";
            ViewBag.admin = _db.LinkModels.Where (x => x.Catogary == "Idhare").ToArray ();
            return View (ViewBag);
        }

        // [HttpGet]
        // public IActionResult AdminProcess () {
        //     ViewBag.admin = _db.LinkModels.Where (x => x.Catogary == "Idhare").ToArray ();
        //     return View (ViewBag);
        // }

        [HttpGet]
        public IActionResult RunningRules (string id) {
              ViewData["Title"] = "Rules";
            ViewBag.runningRules = _db.LinkModels.Where (x => x.Catogary == id).ToArray ();
            return View (ViewBag);
        }

        [HttpGet]
        public IActionResult MeetingSummery (string id) {
              ViewData["Title"] = "Summery";
            ViewBag.meeting = _db.LinkModels.Where (x => x.Catogary == id).ToArray ();
            return View (ViewBag);
        }

        public IActionResult VideoGallery () {
              ViewData["Title"] = "Gallery";
            ViewBag.videoGallery = _db.GalleryModels.Where (x => x.Text == "video").ToArray ();
            return View (ViewBag);
        }

        public IActionResult Privacy () {
              ViewData["Title"] = "Privacy";
            return View ();
        }
        public IActionResult Target () {
              ViewData["Title"] = "Target";
            ViewBag.mission = _db.LinkModels.Where (x => x.Catogary == "mission").ToArray ();
            ViewBag.Vission = _db.LinkModels.Where (x => x.Catogary == "vission").ToArray ();
            return View (ViewBag);
        }

        public IActionResult Services () {
              ViewData["Title"] = "Service";
            ViewBag.services = _db.LinkModels.Where (x => x.Catogary == "services").ToArray ();
            return View (ViewBag);
        }

        [ResponseCache (Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error () {
            return View (new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}