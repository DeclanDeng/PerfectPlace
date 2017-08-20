using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using PerfectPlace.Models;
using PagedList;

namespace PerfectPlace.Controllers
{
    public class SearchController : Controller
    {
        //private ApplicationDbContext db = new ApplicationDbContext();
        private SuburbEntities db = new SuburbEntities();
        //
        // POST: /Search/
        [HttpPost]
        public ActionResult Index(string criteriaOne, string criteriaTwo, string nationality)
        {
            var suburbs = from s in db.suburb_info select s;
            var resultNum = 50;
            if (!criteriaOne.Equals("Criteria 1"))
            {
                //Debug.WriteLine("ok, Not equals");
                ViewBag.criteriaOne = criteriaOne;

                switch (criteriaOne)
                {
                    case "Near CBD":
                        suburbs = suburbs.OrderBy(s => s.distance_to_gpo).Take(resultNum);
                        break;
                    case "More shops":
                        suburbs = suburbs.OrderBy(s => s.commercial_percent).Take(resultNum);
                        break;
                    case "More health service":
                        suburbs = suburbs.OrderBy(s => s.public_hospitals).Take(resultNum);
                        break;
                    case "More aged care centre":
                        suburbs = suburbs.OrderBy(s => s.aged_care_high_care).Take(resultNum);
                        break;
                    case "Near hospital":
                        suburbs = suburbs.OrderBy(s => s.distance_nearest_public_hospital).Take(resultNum);
                        break;
                    case "Primary Schools":
                        suburbs = suburbs.OrderBy(s => s.primary_schools).Take(resultNum);
                        break;
                }
                resultNum = 30;
                if (!criteriaTwo.Equals("Criteria 2"))
                {
                    ViewBag.criteriaTwo = criteriaTwo;
                    switch (criteriaTwo)
                    {
                        case "Near CBD":
                            suburbs = suburbs.OrderBy(s => s.distance_to_gpo).Take(resultNum);
                            break;
                        case "More shops":
                            suburbs = suburbs.OrderBy(s => s.commercial_percent).Take(resultNum);
                            break;
                        case "More health service":
                            suburbs = suburbs.OrderBy(s => s.public_hospitals).Take(resultNum);
                            break;
                        case "More aged care centre":
                            suburbs = suburbs.OrderBy(s => s.aged_care_high_care).Take(resultNum);
                            break;
                        case "Near hospital":
                            suburbs = suburbs.OrderBy(s => s.distance_nearest_public_hospital).Take(resultNum);
                            break;
                        case "Primary Schools":
                            suburbs = suburbs.OrderBy(s => s.primary_schools).Take(resultNum);
                            break;
                    }
                }
                resultNum = 10;
                if (!nationality.Equals("Nationality"))
                {
                    ViewBag.nationality = nationality;
                    switch (nationality)
                    {
                        case "Near CBD":
                            suburbs = suburbs.OrderBy(s => s.distance_to_gpo).Take(resultNum);
                            break;
                        case "More shops":
                            suburbs = suburbs.OrderBy(s => s.commercial_percent).Take(resultNum);
                            break;
                        case "More health service":
                            suburbs = suburbs.OrderBy(s => s.public_hospitals).Take(resultNum);
                            break;
                        case "More aged care centre":
                            suburbs = suburbs.OrderBy(s => s.aged_care_high_care).Take(resultNum);
                            break;
                        case "Near hospital":
                            suburbs = suburbs.OrderBy(s => s.distance_nearest_public_hospital).Take(resultNum);
                            break;
                        case "Primary Schools":
                            suburbs = suburbs.OrderBy(s => s.primary_schools).Take(resultNum);
                            break;
                    }
                }
                suburbs = suburbs.Take(10);
                return View(suburbs.ToList());
            }
            else
            {
                //Debug.WriteLine("sorry, Equals");
                ViewBag.criteriaOne = "Criteria 1";
                resultNum = 30;
                if (!criteriaTwo.Equals("Criteria 2"))
                {
                    //Debug.WriteLine("ok, Not equals");
                    ViewBag.criteriaTwo = criteriaTwo;

                    switch (criteriaTwo)
                    {
                        case "Near CBD":
                            suburbs = suburbs.OrderBy(s => s.distance_to_gpo).Take(resultNum);
                            break;
                        case "More shops":
                            suburbs = suburbs.OrderBy(s => s.commercial_percent).Take(resultNum);
                            break;
                        case "More health service":
                            suburbs = suburbs.OrderBy(s => s.public_hospitals).Take(resultNum);
                            break;
                        case "More aged care centre":
                            suburbs = suburbs.OrderBy(s => s.aged_care_high_care).Take(resultNum);
                            break;
                        case "Near hospital":
                            suburbs = suburbs.OrderBy(s => s.distance_nearest_public_hospital).Take(resultNum);
                            break;
                        case "Primary Schools":
                            suburbs = suburbs.OrderBy(s => s.primary_schools).Take(resultNum);
                            break;
                    }
                    resultNum = 10;
                    if (!nationality.Equals("Nationality"))
                    {
                        ViewBag.nationality = nationality;
                        switch (nationality)
                        {
                            case "Near CBD":
                                suburbs = suburbs.OrderBy(s => s.distance_to_gpo).Take(resultNum);
                                break;
                            case "More shops":
                                suburbs = suburbs.OrderBy(s => s.commercial_percent).Take(resultNum);
                                break;
                            case "More health service":
                                suburbs = suburbs.OrderBy(s => s.public_hospitals).Take(resultNum);
                                break;
                            case "More aged care centre":
                                suburbs = suburbs.OrderBy(s => s.aged_care_high_care).Take(resultNum);
                                break;
                            case "Near hospital":
                                suburbs = suburbs.OrderBy(s => s.distance_nearest_public_hospital).Take(resultNum);
                                break;
                            case "Primary Schools":
                                suburbs = suburbs.OrderBy(s => s.primary_schools).Take(resultNum);
                                break;
                        }
                    }
                    suburbs = suburbs.Take(10);
                    return View(suburbs.ToList());
                }
                else
                {
                    ViewBag.criteriaTwo = "Criteria 2";
                    resultNum = 10;
                    if (!nationality.Equals("Nationality"))
                    {
                        ViewBag.nationality = nationality;
                        switch (nationality)
                        {
                            case "Near CBD":
                                suburbs = suburbs.OrderBy(s => s.distance_to_gpo).Take(resultNum);
                                break;
                            case "More shops":
                                suburbs = suburbs.OrderBy(s => s.commercial_percent).Take(resultNum);
                                break;
                            case "More health service":
                                suburbs = suburbs.OrderBy(s => s.public_hospitals).Take(resultNum);
                                break;
                            case "More aged care centre":
                                suburbs = suburbs.OrderBy(s => s.aged_care_high_care).Take(resultNum);
                                break;
                            case "Near hospital":
                                suburbs = suburbs.OrderBy(s => s.distance_nearest_public_hospital).Take(resultNum);
                                break;
                            case "Primary Schools":
                                suburbs = suburbs.OrderBy(s => s.primary_schools).Take(resultNum);
                                break;
                        }
                        suburbs = suburbs.Take(10);
                        return View(suburbs.ToList());
                    }
                    else
                    {
                        ViewBag.nationality = "Nationality";
                        ViewBag.noInput = "Please select one criteria";
                        return View();
                    }
                }
               
            }
            //suburbs = suburbs.Where(s=>s)
            //Debug.WriteLine("hello");
            //Debug.WriteLine(location);
            //Debug.WriteLine(criteriaOne);
            //ViewBag.criteriaOne = criteriaOne;
            //ViewBag.criteriaTwo = criteriaTwo;
            //ViewBag.nationality = nationality;
            //return View();
        }
	}
}