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
        //private SuburbEntities db = new SuburbEntities();
        private PreferenceEntities db = new PreferenceEntities();
        //
        // POST: /Search/
        //[HttpPost]
        //public ActionResult Index(string criteriaOne, string criteriaTwo, string nationality)
        //{
        //    var suburbs = from s in db.suburb_info select s;
        //    var resultNum = 50;
        //    if (!criteriaOne.Equals("Criteria 1"))
        //    {
        //        //Debug.WriteLine("ok, Not equals");
        //        ViewBag.criteriaOne = criteriaOne;

        //        switch (criteriaOne)
        //        {
        //            case "Near CBD":
        //                suburbs = suburbs.OrderBy(s => s.distance_to_gpo).Take(resultNum);
        //                break;
        //            case "More shops":
        //                suburbs = suburbs.OrderBy(s => s.commercial_percent).Take(resultNum);
        //                break;
        //            case "More health service":
        //                suburbs = suburbs.OrderBy(s => s.public_hospitals).Take(resultNum);
        //                break;
        //            case "More aged care centre":
        //                suburbs = suburbs.OrderBy(s => s.aged_care_high_care).Take(resultNum);
        //                break;
        //            case "Near hospital":
        //                suburbs = suburbs.OrderBy(s => s.distance_nearest_public_hospital).Take(resultNum);
        //                break;
        //            case "Primary Schools":
        //                suburbs = suburbs.OrderBy(s => s.primary_schools).Take(resultNum);
        //                break;
        //        }
        //        resultNum = 30;
        //        if (!criteriaTwo.Equals("Criteria 2"))
        //        {
        //            ViewBag.criteriaTwo = criteriaTwo;
        //            switch (criteriaTwo)
        //            {
        //                case "Near CBD":
        //                    suburbs = suburbs.OrderBy(s => s.distance_to_gpo).Take(resultNum);
        //                    break;
        //                case "More shops":
        //                    suburbs = suburbs.OrderBy(s => s.commercial_percent).Take(resultNum);
        //                    break;
        //                case "More health service":
        //                    suburbs = suburbs.OrderBy(s => s.public_hospitals).Take(resultNum);
        //                    break;
        //                case "More aged care centre":
        //                    suburbs = suburbs.OrderBy(s => s.aged_care_high_care).Take(resultNum);
        //                    break;
        //                case "Near hospital":
        //                    suburbs = suburbs.OrderBy(s => s.distance_nearest_public_hospital).Take(resultNum);
        //                    break;
        //                case "Primary Schools":
        //                    suburbs = suburbs.OrderBy(s => s.primary_schools).Take(resultNum);
        //                    break;
        //            }
        //        }
        //        resultNum = 10;
        //        if (!nationality.Equals("Nationality"))
        //        {
        //            ViewBag.nationality = nationality;
        //            switch (nationality)
        //            {
        //                case "Near CBD":
        //                    suburbs = suburbs.OrderBy(s => s.distance_to_gpo).Take(resultNum);
        //                    break;
        //                case "More shops":
        //                    suburbs = suburbs.OrderBy(s => s.commercial_percent).Take(resultNum);
        //                    break;
        //                case "More health service":
        //                    suburbs = suburbs.OrderBy(s => s.public_hospitals).Take(resultNum);
        //                    break;
        //                case "More aged care centre":
        //                    suburbs = suburbs.OrderBy(s => s.aged_care_high_care).Take(resultNum);
        //                    break;
        //                case "Near hospital":
        //                    suburbs = suburbs.OrderBy(s => s.distance_nearest_public_hospital).Take(resultNum);
        //                    break;
        //                case "Primary Schools":
        //                    suburbs = suburbs.OrderBy(s => s.primary_schools).Take(resultNum);
        //                    break;
        //            }
        //        }
        //        suburbs = suburbs.Take(10);
        //        return View(suburbs.ToList());
        //    }
        //    else
        //    {
        //        //Debug.WriteLine("sorry, Equals");
        //        ViewBag.criteriaOne = "Criteria 1";
        //        resultNum = 30;
        //        if (!criteriaTwo.Equals("Criteria 2"))
        //        {
        //            //Debug.WriteLine("ok, Not equals");
        //            ViewBag.criteriaTwo = criteriaTwo;

        //            switch (criteriaTwo)
        //            {
        //                case "Near CBD":
        //                    suburbs = suburbs.OrderBy(s => s.distance_to_gpo).Take(resultNum);
        //                    break;
        //                case "More shops":
        //                    suburbs = suburbs.OrderBy(s => s.commercial_percent).Take(resultNum);
        //                    break;
        //                case "More health service":
        //                    suburbs = suburbs.OrderBy(s => s.public_hospitals).Take(resultNum);
        //                    break;
        //                case "More aged care centre":
        //                    suburbs = suburbs.OrderBy(s => s.aged_care_high_care).Take(resultNum);
        //                    break;
        //                case "Near hospital":
        //                    suburbs = suburbs.OrderBy(s => s.distance_nearest_public_hospital).Take(resultNum);
        //                    break;
        //                case "Primary Schools":
        //                    suburbs = suburbs.OrderBy(s => s.primary_schools).Take(resultNum);
        //                    break;
        //            }
        //            resultNum = 10;
        //            if (!nationality.Equals("Nationality"))
        //            {
        //                ViewBag.nationality = nationality;
        //                switch (nationality)
        //                {
        //                    case "Near CBD":
        //                        suburbs = suburbs.OrderBy(s => s.distance_to_gpo).Take(resultNum);
        //                        break;
        //                    case "More shops":
        //                        suburbs = suburbs.OrderBy(s => s.commercial_percent).Take(resultNum);
        //                        break;
        //                    case "More health service":
        //                        suburbs = suburbs.OrderBy(s => s.public_hospitals).Take(resultNum);
        //                        break;
        //                    case "More aged care centre":
        //                        suburbs = suburbs.OrderBy(s => s.aged_care_high_care).Take(resultNum);
        //                        break;
        //                    case "Near hospital":
        //                        suburbs = suburbs.OrderBy(s => s.distance_nearest_public_hospital).Take(resultNum);
        //                        break;
        //                    case "Primary Schools":
        //                        suburbs = suburbs.OrderBy(s => s.primary_schools).Take(resultNum);
        //                        break;
        //                }
        //            }
        //            suburbs = suburbs.Take(10);
        //            return View(suburbs.ToList());
        //        }
        //        else
        //        {
        //            ViewBag.criteriaTwo = "Criteria 2";
        //            resultNum = 10;
        //            if (!nationality.Equals("Nationality"))
        //            {
        //                ViewBag.nationality = nationality;
        //                switch (nationality)
        //                {
        //                    case "Near CBD":
        //                        suburbs = suburbs.OrderBy(s => s.distance_to_gpo).Take(resultNum);
        //                        break;
        //                    case "More shops":
        //                        suburbs = suburbs.OrderBy(s => s.commercial_percent).Take(resultNum);
        //                        break;
        //                    case "More health service":
        //                        suburbs = suburbs.OrderBy(s => s.public_hospitals).Take(resultNum);
        //                        break;
        //                    case "More aged care centre":
        //                        suburbs = suburbs.OrderBy(s => s.aged_care_high_care).Take(resultNum);
        //                        break;
        //                    case "Near hospital":
        //                        suburbs = suburbs.OrderBy(s => s.distance_nearest_public_hospital).Take(resultNum);
        //                        break;
        //                    case "Primary Schools":
        //                        suburbs = suburbs.OrderBy(s => s.primary_schools).Take(resultNum);
        //                        break;
        //                }
        //                suburbs = suburbs.Take(10);
        //                return View(suburbs.ToList());
        //            }
        //            else
        //            {
        //                ViewBag.nationality = "Nationality";
        //                ViewBag.noInput = "Please select one criteria";
        //                return View();
        //            }
        //        }
               
        //    }
        //    //suburbs = suburbs.Where(s=>s)
        //    //Debug.WriteLine("hello");
        //    //Debug.WriteLine(location);
        //    //Debug.WriteLine(criteriaOne);
        //    //ViewBag.criteriaOne = criteriaOne;
        //    //ViewBag.criteriaTwo = criteriaTwo;
        //    //ViewBag.nationality = nationality;
        //    //return View();
        //}

        [HttpPost]
        public ActionResult Index(int[] suburbSearch, string nationality)
        {
            string veryNearDistanceToCity = null;
            string veryHighMoreshops = null;
            string veryHighHealthServices = null;
            string lowAccidentRate = null;
            string veryHighMoreAgedcare = null;
            string veryLessTimeToHospital = null;
            string lowCrimeRate = null;
            string topCountryOfBirth = null;

            if (suburbSearch == null && nationality.Equals("Prefered Nationality"))
            {
                ViewBag.veryNearDistanceToCity = null;
                ViewBag.veryHighMoreshops = null;
                ViewBag.veryHighHealthServices = null;
                ViewBag.lowAccidentRate = null;
                ViewBag.veryHighMoreAgedcare = null;
                ViewBag.veryLessTimeToHospital = null;
                ViewBag.lowCrimeRate = null;
                ViewBag.topCountryOfBirth = null;
                ViewBag.resultCount = 0;
                return View();
            }

            if (suburbSearch == null && !nationality.Equals("Prefered Nationality"))
            {
                ViewBag.veryNearDistanceToCity = null;
                ViewBag.veryHighMoreshops = null;
                ViewBag.veryHighHealthServices = null;
                ViewBag.lowAccidentRate = null;
                ViewBag.veryHighMoreAgedcare = null;
                ViewBag.veryLessTimeToHospital = null;
                ViewBag.lowCrimeRate = null;
                ViewBag.topCountryOfBirth = nationality;
                ViewBag.resultCount = db.SearchByPreference(veryNearDistanceToCity, veryHighMoreshops, veryHighHealthServices, lowAccidentRate, veryHighMoreAgedcare, veryLessTimeToHospital, lowCrimeRate, topCountryOfBirth).Count();
                return View(db.SearchByPreference(veryNearDistanceToCity, veryHighMoreshops, veryHighHealthServices, lowAccidentRate, veryHighMoreAgedcare, veryLessTimeToHospital, lowCrimeRate, topCountryOfBirth));
            }

            Debug.WriteLine("Display:");
            //Debug.WriteLine(suburb_search.Length);
            for (int i = 0; i < suburbSearch.Length; i++)
            {
                switch (suburbSearch[i])
                {
                    case 1:
                        Debug.WriteLine("Near CBD");
                        veryNearDistanceToCity = "Very Near";
                        break;
                    case 2:
                        Debug.WriteLine("More shops");
                        veryHighMoreshops = "Very High";
                        break;
                    case 3:
                        Debug.WriteLine("More health service");
                        veryHighHealthServices = "Very High";
                        break;
                    case 4:
                        Debug.WriteLine("Low Accident Rate");
                        lowAccidentRate = "Low";
                        break;
                    case 5:
                        Debug.WriteLine("More aged care centre");
                        veryHighMoreAgedcare = "Very High";
                        break;
                    case 6:
                        Debug.WriteLine("Near hospital");
                        veryLessTimeToHospital = "Very Less";
                        break;
                    case 7:
                        Debug.WriteLine("Low Crime Rate");
                        lowCrimeRate = "Low";
                        break;
                    default:
                        Debug.WriteLine("Null");
                        break;
                }
            }
            if (!nationality.Equals("Prefered Nationality"))
            {
                topCountryOfBirth = nationality;
            }
            else
            {
                topCountryOfBirth = null;
            }
            ViewBag.veryNearDistanceToCity = veryNearDistanceToCity;
            ViewBag.veryHighMoreshops = veryHighMoreshops;
            ViewBag.veryHighHealthServices = veryHighHealthServices;
            ViewBag.lowAccidentRate = lowAccidentRate;
            ViewBag.veryHighMoreAgedcare = veryHighMoreAgedcare;
            ViewBag.veryLessTimeToHospital = veryLessTimeToHospital;
            ViewBag.lowCrimeRate = lowCrimeRate;
            ViewBag.topCountryOfBirth = topCountryOfBirth;
            ViewBag.resultCount = db.SearchByPreference(veryNearDistanceToCity, veryHighMoreshops, veryHighHealthServices, lowAccidentRate, veryHighMoreAgedcare, veryLessTimeToHospital, lowCrimeRate, topCountryOfBirth).Count();
            return View(db.SearchByPreference(veryNearDistanceToCity, veryHighMoreshops, veryHighHealthServices, lowAccidentRate, veryHighMoreAgedcare, veryLessTimeToHospital, lowCrimeRate, topCountryOfBirth));
        }

        // POST: /Search/SearchBySuburb   string inputSuburb

        public ActionResult SearchBySuburb(string inputSuburb)
        {
            ViewBag.inputSuburb = inputSuburb;
            //var userInput = inputSuburb;
            ////Debug.WriteLine(userInput);
            //var suburbs = from s in db.suburb_info where  s.community_name.Contains(inputSuburb) select s;
            var suburbs = from s in db.rating_it2 where s.suburb.Contains(inputSuburb) select s;
            return View(suburbs.ToList());
            //return View();
        }

        [HttpPost]
        public ActionResult SearchBySuburbChange(string suburbChange)
        {
            if (suburbChange.Equals("SEA CHANGE"))
            {
                return View(db.SearchBySuburbChange("sea change"));
            }
            else if (suburbChange.Equals("TREE CHANGE"))
            {
                return View(db.SearchBySuburbChange("tree change"));
            }
            else if (suburbChange.Equals("CITY CHANGE"))
            {
                return View(db.SearchBySuburbChange("city change"));
            }
            else
            {
                return View();
            }
        }
    }
}