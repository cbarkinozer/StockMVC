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
    }
}