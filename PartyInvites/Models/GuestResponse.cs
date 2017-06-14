using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PartyInvites.Models
{
    public class GuestResponse
    {
        [Required(ErrorMessage ="Please Enter your name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please Enter your email address")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage ="Please Enter a valid email address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please Enter your phone number")]
        public string Phone { get; set; }

        [Required(ErrorMessage ="Please specify whether you'll attend")]
        public bool? WillAttend { get; set; }
    }
}