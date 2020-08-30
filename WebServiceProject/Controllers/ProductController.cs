using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebServiceProject.Models;

namespace WebServiceProject.Controllers
{
    public class ProductController : Controller
    {

        List<ProductoCLS> ListProducto = null;
        // GET: Product
        public ActionResult InfoProduct()
        {
            using (var bd = new AdventureWorksLT2019Entities1())
            {
                ListProducto = (List<ProductoCLS>)(from U in bd.Products
                                                   join D in bd.ProductCategories
                                                   on U.ProductCategoryID equals D.ProductCategoryID

                                                   select new ProductoCLS
                                                   {
                                                       Product = U.Name,
                                                       Color = U.Color,
                                                       Price = (float)U.ListPrice,
                                                       Category = D.Name

                                                   }).ToList();
            }
            return View(ListProducto);
        }
    }
}