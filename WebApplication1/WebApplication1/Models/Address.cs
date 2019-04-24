using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Address
    {
        public int ID { get; set; }
        //database need a unique identifier (primary key)
        public string Forenames { get; set; }
        public string Surname { get; set; }
        public string AddressLineOne { get; set; }
        public string AddressLineTwo { get; set; }
        public string Postcode { get; set; }
        public string Town { get; set; }
        public string Country { get; set; }
        public string Email { get; set; }
        public string MobileNo { get; set; }
        //stored as a string to avoid incorrect formatting
    }
}
