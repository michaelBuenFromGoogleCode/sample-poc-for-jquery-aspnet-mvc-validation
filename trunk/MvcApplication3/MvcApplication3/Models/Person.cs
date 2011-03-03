using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MvcApplication3.Models
{
    public class Person
    {
        [Required(ErrorMessage="Last Name required")]
        public string Lastname { get; set; }

        [Required(ErrorMessage="First Name required")]
        public string Firstname { get; set; }

        [Required(ErrorMessage="Age Required")]
        [Range(0,120, ErrorMessage="Age must be between 0 and 120")]
        public int Age { get; set; }


        // sourced here: http://www.regular-expressions.info/email.html
        [Required(ErrorMessage="Email required")]
        [RegularExpression(@"[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?",
            ErrorMessage="Not a valid email")]
        public string Email { get; set; }
    
    }
}