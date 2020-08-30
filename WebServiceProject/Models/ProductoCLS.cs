using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Dynamic;
using System.Linq;
using System.Web;

namespace WebServiceProject.Models
{
    public class ProductoCLS
    {   
        [Display(Name ="Name")]
        public string Product { get; set;}
        public string Color { get; set; }
        public float Price { get; set; }
        public string Category { get; set; }
    }
}