using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebServiceProject.Models
{
    public class ClienteCLS
    {
        [Display(Name = "Id")]
        public int CustomerID { get; set; }

        [Display(Name = "Name")]
        public String FirstName { get; set; }

        [Display(Name = "LastName")]
        public String LastName { get; set; }

        [Display(Name = "Email")]
        public String EmailAddress { get; set; }

        [Display(Name = "Address")]
        public String AddressType { get; set; }

    }
}