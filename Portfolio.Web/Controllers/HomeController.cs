using Portfolio.Web.Adapters.DataAdapters;
using Portfolio.Web.Adapters.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Portfolio.Web.Controllers
{
    public class HomeController : Controller
    {
        ICategoryAdapter db;

        public HomeController()
        {
            db = new CategoryAdapter();
        }

        public HomeController(ICategoryAdapter _db)
        {
            db = _db;
        }

        public ActionResult Index()
        {
            var model = db.getCategories();

            return View(model);
        }
    }
}