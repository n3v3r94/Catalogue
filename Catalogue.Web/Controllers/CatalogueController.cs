
namespace Catalogue.Web.Controllers
{
    using Catalogue.Models.ViewModels;
    using Catalogue.Service;
    using System.Linq;
    using System.Web.Mvc;

    public class CatalogueController : Controller
    {
        private readonly ICatalogueService catalogueSvc;

        public CatalogueController(ICatalogueService catalogueSvc)
        {
            this.catalogueSvc = catalogueSvc;
        }

        public ActionResult GetAllProduct()
        {
            var allProduct = this.catalogueSvc.GetAllProduct().ToList();

            var lastThreeProduct = allProduct.Skip(allProduct.Count - 3);

            return View(allProduct);
       }


        [HttpGet]
        public ActionResult SearchProduct()
        {
            var categories = catalogueSvc.GetAllCategories();

            return View(categories);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SearchByCategories (string Categories)
        {
            
           
            var categories = catalogueSvc.SerarByCategories(Categories);
            return View(categories);
        }
    }
}