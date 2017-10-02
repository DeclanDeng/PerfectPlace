using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PerfectPlace.Models;

namespace PerfectPlace.ViewModels
{
    public class SuburbAndSuburbList
    {
        //public IEnumerable<rating_it3> SuburbListData { get; set; }
        //public rating_it3 SuburbInfo { get; set; }

        public List<rating_it3> SuburbListData { get; set; }
        public List<rating_it3> SuburbListDataCompare { get; set; }
        public rating_it3 SuburbData { get; set; }
    }
}