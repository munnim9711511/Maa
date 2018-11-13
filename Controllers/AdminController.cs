using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using coouncil.Models;
using Coun.Data;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Coun.Controllers {
    [Authorize]
    public class AdminController : Controller {
        private const string ControllerName = "Admin";
        private readonly DataContext _db;
        private readonly IHostingEnvironment he;
        public AdminController (DataContext _db, IHostingEnvironment he) {
            this._db = _db;
            this.he = he;
        }
        public IActionResult Index () {
            return View ();
        }
        public IActionResult News () {
            return View ();
        }

        [HttpGet]
        public IActionResult Gallery () {
            return View ();
        }

        [HttpGet]
        public IActionResult Users () {
            return View ();
        }

        [HttpPost]
        public IActionResult Gallery (GalleryModel galleryM, IFormFile gpic) {
            if (gpic != null) {
                var fileName = Path.Combine (he.WebRootPath + "/gallery", Path.GetFileName (gpic.FileName));
                gpic.CopyTo (new FileStream (fileName, FileMode.Create));
                galleryM.ImgUrl = Path.GetFileName (gpic.FileName);

                _db.GalleryModels.Add (galleryM);
                _db.SaveChanges ();

            }

            return View ("Gallery");
        }

        [HttpPost]
        public IActionResult News (NewsModel NewsM, IFormFile NewsPic) {
            if (NewsPic != null) {
                var fileName = Path.Combine (he.WebRootPath + "/newsImage", Path.GetFileName (NewsPic.FileName));
                NewsPic.CopyTo (new FileStream (fileName, FileMode.Create));
                NewsM.ImgUrl = Path.GetFileName (NewsPic.FileName);
                NewsM.Date = DateTime.Now.ToString ();
                _db.NewsModels.Add (NewsM);
                _db.SaveChanges ();

            }
            return View ("News");
        }

        [HttpGet]
        public IActionResult GetInfo () {
            dynamic data = _db.NewsModels.ToArray ();
            var x = JsonConvert.SerializeObject (data);
            return Json (x);
        }

        [HttpGet]
        public IActionResult Anouncements () => View ();

        [HttpPost]
        public IActionResult Anouncements (AnouncementsModel AnM, IFormFile Doc) {

            if (Doc != null) {
                var fileName = Path.Combine (he.WebRootPath + "/anounceDoc", Path.GetFileName (Doc.FileName));
                Doc.CopyTo (new FileStream (fileName, FileMode.Create));
                AnM.DocUrl = Path.GetFileName (Doc.FileName);

                _db.anouncementsModels.Add (AnM);
                _db.SaveChanges ();

            }
            return View ("Anouncements");
        }
        public IActionResult UploadDoc () {
            return View ();
        }
        public IActionResult Cafey () {
            return View ();
        }

        [HttpPost]
        public IActionResult Cafey (CafeyModel cM, IFormFile pic) {
            if (pic != null) {
                var fileName = Path.Combine (he.WebRootPath + "/cafey", Path.GetFileName (pic.FileName));
                pic.CopyTo (new FileStream (fileName, FileMode.Create));
                cM.ImgUrl = Path.GetFileName (pic.FileName);

                _db.CafeyModels.Add (cM);
                _db.SaveChanges ();

            }
            return View ("Cafey");
        }
        public IActionResult Bussiness () {
            return View ();
        }
        public IActionResult UpdateLink () {
            return View ();
        }

        [HttpGet]
        public IActionResult CouncilInfo () {
            return View ();
        }

        [HttpPost]
        public IActionResult CouncilInfo (CouncilModel Cmodel, List<IFormFile> pic) {

            if (pic != null) {
                var fileName = Path.Combine (he.WebRootPath + "/council", Path.GetFileName (pic[0].FileName));
                pic[0].CopyTo (new FileStream (fileName, FileMode.Create));
                Cmodel.FirstPic = Path.GetFileName (pic[0].FileName);
                fileName = Path.Combine (he.WebRootPath + "/council", Path.GetFileName (pic[1].FileName));
                pic[1].CopyTo (new FileStream (fileName, FileMode.Create));
                Cmodel.SecondPic = Path.GetFileName (pic[1].FileName);
                fileName = Path.Combine (he.WebRootPath + "/council", Path.GetFileName (pic[2].FileName));
                pic[2].CopyTo (new FileStream (fileName, FileMode.Create));
                Cmodel.TheirdPic = Path.GetFileName (pic[2].FileName);

                _db.CouncilModels.Add (Cmodel);
                _db.SaveChanges ();

            }
            return View ("CouncilInfo");

        }

        [HttpPost]
        public IActionResult UpdateLink (LinkModel linlM, IFormFile NewsPic) {

            if (NewsPic != null) {
                var fileName = Path.Combine (he.WebRootPath + "/LinkPic", Path.GetFileName (NewsPic.FileName));
                NewsPic.CopyTo (new FileStream (fileName, FileMode.Create));
                linlM.ImgUrl = Path.GetFileName (NewsPic.FileName);

                _db.LinkModels.Add (linlM);
                _db.SaveChanges ();

            }
            return View ("UpdateLink");

        }
        public IActionResult Slider () {
            return View ();
        }

        [HttpGet]
        public IActionResult UpdateNews () {
            ViewBag.news = _db.NewsModels.ToArray ().OrderByDescending (x => x.Id);
            return View (ViewBag);
        }

        [HttpPost]
        public IActionResult UpdateNews (NewsModel newsM, IFormFile NewsPic) {
            if (NewsPic != null) {
                var fileName = Path.Combine (he.WebRootPath + "/newsImage", Path.GetFileName (NewsPic.FileName));
                NewsPic.CopyTo (new FileStream (fileName, FileMode.Create));
                newsM.ImgUrl = Path.GetFileName (NewsPic.FileName);
                newsM.Date = DateTime.Now.ToString ();
                _db.NewsModels.Update (newsM);
                _db.SaveChanges ();

            }

            return RedirectToAction ("UpdateNews", "admin");

        }

        [HttpGet]
        public IActionResult UpdateNew (int id) {
            ViewBag.news = _db.NewsModels.Where (x => x.Id == id).ToArray ();
            return View (ViewBag);
        }

        [HttpPost]
        public IActionResult Slider (SliderModel slideM, IFormFile slide) {
            if (slide != null) {
                var fileName = Path.Combine (he.WebRootPath + "/slideImage", Path.GetFileName (slide.FileName));
                slide.CopyTo (new FileStream (fileName, FileMode.Create));
                slideM.ImgUrl = Path.GetFileName (slide.FileName);
                _db.SliderModels.Add (slideM);
                _db.SaveChanges ();

            }

            return View ("slider");
        }

    }
}