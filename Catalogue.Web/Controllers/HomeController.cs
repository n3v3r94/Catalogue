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
            var allProduct = this.catalogueSvc.GetAllProduct().ToList();

            var lastThreeProduct = allProduct.Skip(allProduct.Count - 3);
            return View(lastThreeProduct);
        }
    }
}