using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ModelPractice.Models
{
    public class Employee
    {
        public int Id { get; set; }

        [Display (Name = "Please enter your name")]
        public string Name { get; set; }
        public string Address { get; set; }
        public bool isOnline { get; set; }
        [Display (Name = " enter your date of birth")] 
        [DataType (DataType.Date)]
        public DateTime Dateofbirth  { get; set; }
      


    }
}