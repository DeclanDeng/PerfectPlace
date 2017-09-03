using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using PerfectPlace.Models;

namespace PerfectPlace.Controllers
{
    public class ResultController : Controller
    {
        ResultEntities db = new ResultEntities();
        //
        // GET: /Result/
        public ActionResult Index()
        {
            return View(db.GetPreferenceResult("Near", null, null, null, null, null, null));

            //return View(db.GetPreferenceResult("Near", "Very High", "Vietnam", "Low", "Moderate", "Moderate", "Moderate"));
        }
	}
}