using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Address
    {
        public int ID { get; set; }
        //database need a unique identifier (primary key)
        [Required(ErrorMessage = "Please Enter This Field")] //Forename Validation
        public string Forenames { get; set; }

        [Required(ErrorMessage = "Please Enter This Field")]//Surname Validation
        public string Surname { get; set; }

        [Required(ErrorMessage = "Please Enter This Field")]//Address 1 Validation
        public string AddressLineOne { get; set; }
        public string AddressLineTwo { get; set; }

        [Required(ErrorMessage = "Please Enter This Field")]//Postcode Validation
        public string Postcode { get; set; }

        [Required(ErrorMessage = "Please Enter This Field")]//Town Validation
        public string Town { get; set; }

        [Required(ErrorMessage = "Please Enter This Field")]//Country Validation
        public string Country { get; set; }

        [Required(ErrorMessage = "Please Enter This Field")]//Email Validation
        public string Email { get; set; }

        [Required(ErrorMessage = "Please Enter This Field")]//Mobile Validation
        public string MobileNo { get; set; }
        //stored as a string to avoid incorrect formatting
    }
}
