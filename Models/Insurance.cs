using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc.Routing.Constraints;

namespace SkladkaUbezpieczenie.Models
{
    public class Insurance
    {
        public int Id { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        [Display(Name = "Date of Birth")]
        public DateTime BirthDate { get; set; }
        [Required]
        [Display(Name = "Insurance Sum")]
        public double Price { get; set; }
        [Required]
        [Display(Name = "Yearly Length")]
        public double YearlyLength { get; set; }
    }
}