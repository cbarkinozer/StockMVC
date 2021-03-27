using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StockMVC.Controllers;
using StockMVC.Models.Entity;

namespace StockMVC.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        MvcStockDBEntities db = new MvcStockDBEntities();
        public ActionResult Index()
        {
            var customers = db.TblCustomers.ToList();
            return View(customers);
        }
    }
}