using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StockMVC.Models.Entity;

namespace StockMVC.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        MvcStockDBEntities db = new MvcStockDBEntities();
        public ActionResult Index()
        {
            var categories = db.TblCategories.ToList();
            return View(categories);
        }
        [HttpGet]
        public ActionResult NewCategory() 
        {
            return View();
        }
        [HttpPost]
        public ActionResult NewCategory(TblCategories tblCategories) 
        {
            db.TblCategories.Add(tblCategories);
            db.SaveChanges();
            return View();
        }
        public ActionResult Delete(int id) 
        {
            var category = db.TblCategories.Find(id);
            db.TblCategories.Remove(category);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}