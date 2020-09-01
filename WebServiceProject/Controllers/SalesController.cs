using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebServiceProject.Models;


namespace WebServiceProject.Controllers
{
    public class SalesController : Controller
    {
        // GET: Sales
        public ActionResult GetAll()
        {
            List<SalesCLS> salesList = null;
            using (var db = new AdventureWorksLT2019Entities1())
            {
                salesList = (List<SalesCLS>)(from SalesOrder in db.SalesOrderHeaders
                                             join Detail in db.SalesOrderDetails
                                          on SalesOrder.SalesOrderID equals Detail.SalesOrderID
                                             join Product in db.Products
                                             on Detail.ProductID equals Product.ProductID


                                             select new SalesCLS
                                             {
                                                 SalesOrderID = SalesOrder.SalesOrderID,
                                                 Status = SalesOrder.Status,
                                                 DueDate = SalesOrder.DueDate,
                                                 ShipDate = (DateTime)SalesOrder.ShipDate,
                                                 OrderDate = SalesOrder.OrderDate,
                                                 OrderSubTotal = SalesOrder.SubTotal,
                                                 TaxAmt = SalesOrder.TaxAmt,
                                                 Freight = SalesOrder.Freight,
                                                 Name = Product.Name,
                                                 OrderQty = Detail.OrderQty
                                             }).ToList();
            }
            return View(salesList);
        }
    }
}