using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PerfectPlace.Models
{
    public class Employee
    {
        public int Id { get; set; }
        
        [Required]
        public string Name { get; set; }
        
        [Required]
        public int Age { get; set; }
        
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        public string ContactNo { get; set; }

    }
}