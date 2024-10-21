using BT4FW.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BT4FW.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            QuanLySanPhamDataContext context = new QuanLySanPhamDataContext();
            List<Product> dsCatalog = context.Products.ToList();
            return View(dsCatalog);
        }
    }
}