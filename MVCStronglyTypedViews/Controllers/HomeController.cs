using MVCStronglyTypedViews.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCStronglyTypedViews.Controllers
{
    public class HomeController : Controller
    {
        List<Album> albums = new List<Album>();

        public ActionResult Index()
        {
            Album album1 = new Album("Dark Side of the Moon", "Pink Floyd", "Vinyl", 9.99M);
            albums.Add(album1);
            Album album2 = new Album("Tubular Bells", "Mike OldField", "Vinyl", 8.99M);
            albums.Add(album2);
            Album album3 = new Album("Back to Black", "Amy Winehouse", "CD", 13.99M);
            albums.Add(album3);

            return View(albums);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}