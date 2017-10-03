using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PerfectPlace.Models;

namespace PerfectPlace.Controllers
{
    public class HomeController : Controller
    {
        SuburbDataEntities context = new SuburbDataEntities();

        // GET: /Home/Index
        public ActionResult Index()
        {
            ViewBag.Current = "Home";
            return View();
        }

        public JsonResult KeywordPredict()
        {
            var rating = context.rating_it3.Select(s => new {s.suburb, s.postcode});
            return Json(rating, JsonRequestBehavior.AllowGet);
        }

        // GET: /Home/About
        public ActionResult About()
        {
            //ViewBag.Message = "Your application description page.";
            ViewBag.Current = "About";
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}