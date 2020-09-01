using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebServiceProject.Models
{
    public class SalesCLS
    {
        [Display(Name = "Order Id")]
        public int SalesOrderID { get; set; }

        [Display(Name = "Due Date")]
        public DateTime DueDate { get; set; }

        [Display(Name = "Ship Date")]
        public DateTime ShipDate { get; set; }
        [Display(Name = "Order Date")]

        public DateTime OrderDate { get; set; }

        [Display(Name = "Status")]
        public byte Status { get; set; }

        [Display(Name = "Sub Total")]
        public decimal OrderSubTotal { get; set; }

        [Display(Name = "Tax Amount")]
        public decimal TaxAmt { get; set; }

        [Display(Name = "Freight")]
        public decimal Freight { get; set; }

        [Display(Name = "Product Name")]
        public string Name { get; set; }

        [Display(Name = "Order Quantity")]
        public decimal OrderQty { get; set; }
    }
}