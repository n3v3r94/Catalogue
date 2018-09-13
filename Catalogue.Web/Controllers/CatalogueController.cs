
namespace Catalogue.Web.Controllers
{
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

        public ActionResult SearchByCategories (string search)
        {

        }
    }
}