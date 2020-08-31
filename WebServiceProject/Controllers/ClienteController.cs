using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebServiceProject.Models;

namespace WebServiceProject.Controllers
{
    public class ClienteController : Controller
    {

        List<ClienteCLS> listaCliente = new List<ClienteCLS>();
        // GET: Cliente
        public ActionResult InfoCliente()
        {
            using (var bd = new AdventureWorksLT2019Entities2())
            {
                listaCliente = (List<ClienteCLS>)(from c in bd.Customer
                                                  join D in bd.CustomerAddress
                                                  on c.CustomerID equals D.CustomerID

                                                  select new ClienteCLS
                                                   {
                                                       CustomerID = c.CustomerID,
                                                       FirstName = c.FirstName,
                                                       LastName = c.LastName,
                                                       EmailAddress= c.EmailAddress,
                                                       AddressType = D.AddressType

                                                   }).ToList();
            }
            return View(listaCliente);
        }
    }
}