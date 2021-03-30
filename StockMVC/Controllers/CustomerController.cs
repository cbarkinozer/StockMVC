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
        [HttpGet]
        public ActionResult NewCustomer() 
        {
            return View();
        }
        [HttpPost]
        public ActionResult NewCustomer(TblCustomers tblCustomers) 
        {
            db.TblCustomers.Add(tblCustomers);
            db.SaveChanges();
            return View();
        }
        public ActionResult Delete(int id) 
        {
            var customer = db.TblCustomers.Find(id);
            db.TblCustomers.Remove(customer);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}