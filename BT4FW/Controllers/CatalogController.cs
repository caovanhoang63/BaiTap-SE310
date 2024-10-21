using BT4FW.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
namespace BT4FW.Controllers
{
    public class CatalogController : Controller
    {
        // GET: Catalog
        public ActionResult Index()
        {
            QuanLySanPhamDataContext context = new QuanLySanPhamDataContext();
            List<Catalog> dsCatalog = context.Catalogs.ToList();
            return View(dsCatalog);
        }
    }
}