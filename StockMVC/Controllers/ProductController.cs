using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StockMVC.Models.Entity;

namespace StockMVC.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        MvcStockDBEntities db = new MvcStockDBEntities();
        public ActionResult Index()
        {
            var products = db.TblProducts.ToList();
            return View(products);
        }
    }
}