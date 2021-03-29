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
        [HttpGet]
        public ActionResult AddProduct()
        {
            List<SelectListItem> selectListItems = (from i in db.TblCategories.ToList()
                                                    select new SelectListItem
                                                    {
                                                        Text = i.CategoryName,
                                                        Value = i.CategoryID.ToString()
                                                    }).ToList();
            ViewBag.itemList = selectListItems;
            return View();
        }
        public ActionResult AddProduct(TblProducts tblProducts)
        {
            db.TblProducts.Add(tblProducts);
            db.SaveChanges();
            return View();
        }
    }
}