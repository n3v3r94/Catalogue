
namespace Catalogue.Web.Controllers
{
    using Catalogue.Models.ViewModels;
    using Catalogue.Service;
    using System.Linq;
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

            var categories = administratorSvc.GetAllCategories().ToList();

            return View(categories);
        }

      [HttpGet]
       public ActionResult Create()
        {

           
            var product = new ProductView();
            var categories = administratorSvc.GetAllCategories().ToList();
            foreach (var item in categories)
            {
                SelectListItem tempCategory = new SelectListItem();

                tempCategory.Text = item.Name;
                tempCategory.Value = item.Name;
                product.Categories.Add(tempCategory);

            }


            return  View(product);
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