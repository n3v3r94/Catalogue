
namespace Catalogue.Web.Controllers
{
    using Catalogue.Service;
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
           var allProduct = this.catalogueSvc.GetAllProduct();

            return View(allProduct);
       }
    }
}