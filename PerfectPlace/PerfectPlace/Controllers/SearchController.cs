using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Dynamic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.Ajax.Utilities;
using PerfectPlace.Models;
using PagedList;
using PerfectPlace.ViewModels;


namespace PerfectPlace.Controllers
{
    public class SearchController : Controller
    {
        //private ApplicationDbContext db = new ApplicationDbContext();
        //private SuburbEntities db = new SuburbEntities();
        //private PreferenceEntities db = new PreferenceEntities();
        private SuburbDataEntities db = new SuburbDataEntities();

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

        private ActionResult SearchByPreference(int[] suburbSearch, string nationality)
        {
            Session["suburbSearch"] = suburbSearch;
            Session["nationality"] = nationality;
            Session["searchMethod"] = "Index";

            ViewBag.SearchResultPage = "SearchByPreference";

            string veryNearDistanceToCity = null;
            string veryHighMoreshops = null;
            string veryHighHealthServices = null;
            string lowAccidentRate = null;
            string veryHighMoreAgedcare = null;
            string veryLessTimeToHospital = null;
            string lowCrimeRate = null;
            string topCountryOfBirth = null;

            if (suburbSearch == null && nationality.Equals("Preferred Nationality"))
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

            if (suburbSearch == null && !nationality.Equals("Preferred Nationality"))
            {
                ViewBag.veryNearDistanceToCity = null;
                ViewBag.veryHighMoreshops = null;
                ViewBag.veryHighHealthServices = null;
                ViewBag.lowAccidentRate = null;
                ViewBag.veryHighMoreAgedcare = null;
                ViewBag.veryLessTimeToHospital = null;
                ViewBag.lowCrimeRate = null;
                ViewBag.topCountryOfBirth = nationality;
                ViewBag.resultCount = db.SearchByPreference(veryNearDistanceToCity, veryHighMoreshops, veryHighHealthServices, lowAccidentRate, veryHighMoreAgedcare, veryLessTimeToHospital, lowCrimeRate, topCountryOfBirth, null).Count();
                return View(db.SearchByPreference(veryNearDistanceToCity, veryHighMoreshops, veryHighHealthServices, lowAccidentRate, veryHighMoreAgedcare, veryLessTimeToHospital, lowCrimeRate, topCountryOfBirth, null));
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
            if (!nationality.Equals("Preferred Nationality"))
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
            ViewBag.resultCount = db.SearchByPreference(veryNearDistanceToCity, veryHighMoreshops, veryHighHealthServices, lowAccidentRate, veryHighMoreAgedcare, veryLessTimeToHospital, lowCrimeRate, topCountryOfBirth, null).Count();
            return View(db.SearchByPreference(veryNearDistanceToCity, veryHighMoreshops, veryHighHealthServices, lowAccidentRate, veryHighMoreAgedcare, veryLessTimeToHospital, lowCrimeRate, topCountryOfBirth, null));
        }

        private ActionResult SearchByLifeStyle(string suburbChange)
        {
            Session["suburbChange"] = suburbChange;
            Session["searchMethod"] = "SearchBySuburbChange";

            ViewBag.SearchResultPage = "SearchByLifeStyle";

            if (suburbChange.Equals("I Want to Live Near by The Sea"))
            {
                ViewBag.LifeStyle = "SeaChange";
                return View(db.SearchBySuburbChange("sea change"));
            }
            else if (suburbChange.Equals("I Want to Live Near by The Green"))
            {
                ViewBag.LifeStyle = "TreeChange";
                return View(db.SearchBySuburbChange("tree change"));
            }
            else if (suburbChange.Equals("I Want to Live Near by The City"))
            {
                ViewBag.LifeStyle = "CityChange";
                return View(db.SearchBySuburbChange("city change"));
            }
            else
            {
                return View();
            }
        }

        private ActionResult SearchBySuburb(string inputSuburb)
        {
            Session["inputSuburb"] = inputSuburb;
            Session["searchMethod"] = "SearchBySuburb";

            ViewBag.SearchResultPage = "SearchBySuburb";

            ViewBag.inputSuburb = inputSuburb;
            ViewBag.noResult = "false";
            if (inputSuburb.Equals(""))
            {
                ViewBag.noResult = "true";
                return View();
            }
            //var userInput = inputSuburb;
            ////Debug.WriteLine(userInput);
            //var suburbs = from s in db.suburb_info where  s.community_name.Contains(inputSuburb) select s;
            var suburbs = from s in db.rating_it3 where s.suburb.Contains(inputSuburb) select s;
            if (suburbs.Count() == 0)
            {
                suburbs = from s in db.rating_it3 where s.post_code.ToString().Equals(inputSuburb) select s;
            }
            if (suburbs.Count() == 0)
            {
                ViewBag.noResult = "true";
            }
            return View(suburbs.ToList());
            //return View();
        }

        [HttpPost]
        public ActionResult Index(string searchBtn, int[] suburbSearch, string nationality, string suburbChange, string searchBySuburbBtn, string inputSuburb)
        {
            if (searchBtn != null && searchBtn.Equals("SEARCH SUBURB"))
            {
                return SearchByPreference(suburbSearch, nationality);
            }
            else if (suburbChange != null)
            {
                return SearchByLifeStyle(suburbChange);
            }
            else if (searchBySuburbBtn != null && searchBySuburbBtn.Equals("SEARCH SUBURB"))
            {
                return SearchBySuburb(inputSuburb);
            }
            else
            {
                return null;
            }
            
        }

        [HttpGet]
        public PartialViewResult _SortSuburb(string SortValue)
        {
            //SuburbAndSuburbList model = new SuburbAndSuburbList();
            //rating_it3 model = new rating_it3();
            List<rating_it3> modelList = new List<rating_it3>();
    
            //var val = SortValue;
            object suburbSearch = null;
            string nationality = "";
            string suburbChange = "";
            //string inputSuburb = "";

            ViewBag.SortValue = SortValue;

            var controller = DependencyResolver.Current.GetService<SuburbController>();
            controller.ControllerContext = new ControllerContext(this.Request.RequestContext, controller);

            if (Session["searchMethod"] == "Index")
            {
                suburbSearch = Session["suburbSearch"] == null ? null : Session["suburbSearch"];
                nationality = Session["nationality"] == null ? null : Session["nationality"].ToString();
                //model.SuburbListData = controller.Search_Index_((suburbSearch as int[]), nationality);
                modelList = controller.Search_Index_((suburbSearch as int[]), nationality);
                switch (SortValue)
                {
                    case "distanceToCBD":
                        return PartialView(modelList.OrderBy(s => s.distance_to_city));
                    case "commercialRate":
                        return PartialView(modelList.OrderBy(s => s.commercial_rate));
                    case "healthService":
                        return PartialView(modelList.OrderBy(s => s.health_services));
                    case "accidentRate":
                        return PartialView(modelList.OrderBy(s => s.accident_count_rate));
                    case "ageCareCenter":
                        return PartialView(modelList.OrderByDescending(s => s.aged_care));
                    case "timeToHospital":
                        return PartialView(modelList.OrderBy(s => s.time_to_hospital));
                    case "crimeRate":
                        return PartialView(modelList.OrderBy(s => s.crime_rate));
                    default:
                        return PartialView(modelList);
                }
                
            }
            else if (Session["searchMethod"] == "SearchBySuburbChange")
            {
                ViewBag.SearchResultPage = "SearchByLifeStyle";
                suburbChange = Session["suburbChange"] == null ? null : Session["suburbChange"].ToString();
                modelList = controller.Search_SearchBySuburbChange_(suburbChange);
                switch (SortValue)
                {
                    case "frequencyBySea":
                        ViewBag.LifeStyle = "SeaChange";
                        return PartialView(modelList.OrderBy(s => s.Public_Transport_Freq));
                    case "golfCourt":
                        ViewBag.LifeStyle = "SeaChange";
                        return PartialView(modelList.OrderByDescending(s => s.golf_count));
                    case "fishingSpot":
                        ViewBag.LifeStyle = "SeaChange";
                        return PartialView(modelList.OrderBy(s => s.distance_to_fishspot));
                    case "nearestHospital":
                        ViewBag.LifeStyle = "TreeChange";
                        return PartialView(modelList.OrderBy(s => s.distance_nearest_public_hospital));
                    case "frequencyByTree":
                        ViewBag.LifeStyle = "TreeChange";
                        return PartialView(modelList.OrderBy(s => s.Public_Transport_Freq));
                    case "nurseryShops":
                        ViewBag.LifeStyle = "TreeChange";
                        return PartialView(modelList.OrderByDescending(s => s.nursery_shops));
                    case "apartmentPrice":
                        ViewBag.LifeStyle = "CityChange";
                        return PartialView(modelList.OrderBy(s => s.buy_unit_2br_string));
                    case "cafe":
                        ViewBag.LifeStyle = "CityChange";
                        return PartialView(modelList.OrderByDescending(s => s.cafes_count));
                    case "dining":
                        ViewBag.LifeStyle = "CityChange";
                        return PartialView(modelList.OrderByDescending(s => s.dining_count));
                    case "barClub":
                        ViewBag.LifeStyle = "CityChange";
                        return PartialView(modelList.OrderByDescending(s => s.bar_count));
                    default:
                        return PartialView(modelList);
                }
                //if (SortValue.Equals("frequencyBySea"))
                //{
                //    ViewBag.LifeStyle = "SeaChange";
                //    return PartialView(modelList.OrderBy(s => s.Public_Transport_Freq));
                //}
                //else if (SortValue.Equals("golfCourt"))
                //{
                //    ViewBag.LifeStyle = "SeaChange";
                //    return PartialView(modelList.OrderByDescending(s => s.golf_count));
                //}
                //else if (SortValue.Equals("fishingSpot"))
                //{
                //    ViewBag.LifeStyle = "SeaChange";
                //    return PartialView(modelList.OrderBy(s => s.distance_to_fishspot));
                //}
                //else if (SortValue.Equals("nearestHospital"))
                //{
                //    ViewBag.LifeStyle = "TreeChange";
                //    return PartialView(modelList.OrderBy(s => s.distance_nearest_public_hospital));
                //}
                //else if (SortValue.Equals("frequencyByTree"))
                //{
                //    ViewBag.LifeStyle = "TreeChange";
                //    return PartialView(modelList.OrderBy(s => s.Public_Transport_Freq));
                //}
                //else if (SortValue.Equals("nurseryShops"))
                //{
                //    ViewBag.LifeStyle = "TreeChange";
                //    return PartialView(modelList.OrderByDescending(s => s.nursery_shops));
                //}
                //else if (SortValue.Equals("apartmentPrice"))
                //{
                //    ViewBag.LifeStyle = "CityChange";
                //    return PartialView(modelList.OrderBy(s => s.buy_unit_2br_string));
                //}
                //else if (SortValue.Equals("cafe"))
                //{
                //    ViewBag.LifeStyle = "CityChange";
                //    return PartialView(modelList.OrderByDescending(s => s.cafes_count));
                //}
                //else if (SortValue.Equals("dining"))
                //{
                //    ViewBag.LifeStyle = "CityChange";
                //    return PartialView(modelList.OrderByDescending(s => s.dining_count));
                //}
                //else if (SortValue.Equals("barClub"))
                //{
                //    ViewBag.LifeStyle = "CityChange";
                //    return PartialView(modelList.OrderByDescending(s => s.bar_count));
                //}
                //else
                //{
                //    return PartialView(modelList);
                //}
            }
            return null;
        }

        

        

        public ActionResult SearchByTreeChange()
        {
            return View(db.SearchBySuburbChange("tree change"));
        }

        public ActionResult SearchByCityChange()
        {
            return View(db.SearchBySuburbChange("tree change"));
        }

        [HttpGet]
        public ActionResult ShowAllSuburbs()
        {
            ViewBag.Current = "Suburb";
            var suburbs = from s in db.rating_it3 select s;
            return View(suburbs.ToList());
        }

        [HttpGet]
        public ActionResult Test()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Quiz()
        {
            return View();
        }

        [HttpPost]
        public ActionResult QuizResult(FormCollection form)
        {
            int seaChangeMark = 0;
            int treeChangeMark = 0;
            int cityChangeMark = 0;

            string question1 = form["Question1"];
            string question2 = form["Question2"];
            string question3 = form["Question3"];
            string question4 = form["Question4"];
            string question5 = form["Question5"];
            string question6 = form["Question6"];
            string question7 = form["Question7"];
            string question8 = form["Question8"];
            string question9 = form["Question9"];
            string question10 = form["Question10"];
            
            switch (question1)
            {
                case "a": 
                    treeChangeMark += 1;
                    break;
                case "b":
                    cityChangeMark += 1;
                    break;
                case "c":
                    seaChangeMark += 1;
                    break;
            }
            switch (question2)
            {
                case "a":
                    cityChangeMark += 1;
                    break;
                case "b":
                    treeChangeMark += 1;
                    seaChangeMark += 1;
                    break;
            }
            switch (question3)
            {
                case "a":
                    cityChangeMark += 1;
                    break;
                case "b":
                    seaChangeMark += 1;
                    break;
                case "c":
                    treeChangeMark += 1;
                    seaChangeMark += 1;
                    break;
            }
            switch (question4)
            {
                case "a":
                    cityChangeMark += 1;
                    break;
                case "b":
                    seaChangeMark += 1;
                    break;
                case "c":
                    treeChangeMark += 1;
                    break;
            }
            switch (question5)
            {
                case "a":
                    seaChangeMark += 1;
                    break;
                case "b":
                    treeChangeMark += 1;
                    break;
                case "c":
                    cityChangeMark += 1;
                    break;
            }
            switch (question6)
            {
                case "a":
                    treeChangeMark += 1;
                    seaChangeMark += 1;
                    break;
                case "b":
                    cityChangeMark += 1;
                    break;
                case "c":
                    treeChangeMark += 1;
                    break;
            }
            switch (question7)
            {
                case "a":
                    treeChangeMark += 1;
                    break;
                case "b":
                    treeChangeMark += 1;
                    seaChangeMark += 1;
                    break;
                case "c":
                    cityChangeMark += 1;
                    break;
                case "d":
                    cityChangeMark += 1;
                    break;
            }
            switch (question8)
            {
                case "a":
                    treeChangeMark += 1;
                    seaChangeMark += 1;
                    break;
                case "b":
                    cityChangeMark += 1;
                    break;
                case "c":
                    cityChangeMark += 1;
                    break;
            }
            switch (question9)
            {
                case "a":
                    treeChangeMark += 1;
                    break;
                case "b":
                    seaChangeMark += 1;
                    break;
                case "c":
                    cityChangeMark += 1;
                    break;
            }
            switch (question10)
            {
                case "a":
                    treeChangeMark += 1;
                    break;
                case "b":
                    seaChangeMark += 1;
                    break;
                case "c":
                    cityChangeMark += 1;
                    break;
            }
            
            ViewBag.question1 = question1;
            ViewBag.question2 = question2;
            ViewBag.question3 = question3;
            ViewBag.question4 = question4; 
            ViewBag.question5 = question5;
            ViewBag.question6 = question6;
            ViewBag.question7 = question7;
            ViewBag.question8 = question8;
            ViewBag.question9 = question9;
            ViewBag.question10 = question10;
            ViewBag.seaChangeMark = seaChangeMark;
            ViewBag.treeChangeMark = treeChangeMark;
            ViewBag.cityChangeMark = cityChangeMark;
            int highestMark = Math.Max(seaChangeMark, Math.Max(treeChangeMark, cityChangeMark));
            ViewBag.highestMark = highestMark;
            if (seaChangeMark == highestMark)
            {
                ViewBag.suggestChange = "Sea Change";
            }else if (treeChangeMark == highestMark)
            {
                ViewBag.suggestChange = "Tree Change";
            }
            else
            {
                ViewBag.suggestChange = "City Change";
            }
            return View();
        }
    }
}