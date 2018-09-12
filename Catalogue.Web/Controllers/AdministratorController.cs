
namespace Catalogue.Web.Controllers
{
    using Catalogue.Models.ViewModels;
    using Catalogue.Service;
    using System.Web.Mvc;

    [Authorize(Roles = "Admin")]
    public class AdministratorController : Controller
    {
        private readonly IAdministratorService administratorSvc;

        public AdministratorController(IAdministratorService administratorSvc)
        {
            this.administratorSvc = administratorSvc;
        }

        [HttpGet]
        public ActionResult GetAllProduct()
        {
           var allProduct =  this.administratorSvc.GetAllProduct();
            return View(allProduct);

        }

        [HttpGet]
        public ActionResult GetAllCategories()
        {

            var categories = administratorSvc.GetAllCategories();

            return View(categories);
        }

      [HttpGet]
       public ActionResult Create()
        {
            return  View(new ProductView());
        }



        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ProductView prod)
        {
            if (ModelState.IsValid)
            {
                this.administratorSvc.CreateProduct(prod);
                return RedirectToAction(nameof(GetAllProduct));

            }

            return View(prod);
        }
    }
}