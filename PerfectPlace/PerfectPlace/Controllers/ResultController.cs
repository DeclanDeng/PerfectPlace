using System;
using System.Collections.Generic;
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
            return View(db.GetPreferenceResult("Very Near","","","","","",""));
        }
	}
}