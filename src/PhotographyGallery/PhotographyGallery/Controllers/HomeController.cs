using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PhotographyGallery.Models;
using PhotographyGallery.Data;

namespace PhotographyGallery.Controllers
{
    public class HomeController : Controller
    {
        private PhotoRepository _photoRepository = null;

        public ActionResult Index()
        {
            List<Photo> photoList = null;
            return View(photoList);
        }

        public ActionResult About()
        {
            return View();
        }
    }
}