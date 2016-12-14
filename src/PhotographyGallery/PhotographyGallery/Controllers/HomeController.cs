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
        BingRepository bingRepository = new BingRepository();

        public ActionResult Index()
        {            
            BingImage[] photoList = bingRepository.GetBingImages();
            return View(photoList);
        }

        public ActionResult About()
        {
            return View();
        }

        public string ImageLink(string url)
        {

            return url;
        }
    }
}