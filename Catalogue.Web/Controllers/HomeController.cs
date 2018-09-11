using Catalogue.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Catalogue.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICatalogueService catalogueSvc;

        public HomeController(ICatalogueService catalogueSvc)
        {
            this.catalogueSvc = catalogueSvc;
        }

        public ActionResult Index()
        {
            var allProdcut = this.catalogueSvc.GetAllProduct();
            return View(allProdcut);
        }
    }
}