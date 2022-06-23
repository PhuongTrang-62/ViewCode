using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebGK.Models;
namespace WebGK.Controllers
{
    public class HomeController : Controller
    {
        WebTHIGKEntities db = new WebTHIGKEntities();
        // GET: Home
        public ActionResult Index()
        {
            var Product = db.Products1.ToList();
            ViewBag.Product = Product;
            var Category = db.Categories.ToList();
            ViewBag.Category = Category;



            return View();
        }
    }
}