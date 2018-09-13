
namespace Catalogue.Web.Controllers
{
    using Catalogue.Models.EntityModels;
    using Catalogue.Models.ViewModels;
    using Catalogue.Service;
    using PagedList;
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

            return View( allProduct);

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

           
            var product = new CreateProductWithCategoryView();
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
        public ActionResult Create(CreateProductWithCategoryView prod)
        {
            if (ModelState.IsValid)
            {
                var cat = prod.Categories;

                this.administratorSvc.CreateProduct(prod);
                return RedirectToAction(nameof(GetAllProduct));

            }

            return View(prod);
        }

        [HttpGet]
        public ActionResult Edit(int id )
        {
            var product = this.administratorSvc.FindProduct(id);

            return View(product);
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ProductView product, int id)
        {
            if (ModelState.IsValid)
            {
                this.administratorSvc.EditProduct(product, id);

                return RedirectToAction(nameof(GetAllProduct));
            }


            return View(product);
        }


        [HttpGet]
        public ActionResult Delete (int id)
        {
            
                var product = this.administratorSvc.FindProduct(id);
            
          
            return View(product);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, string confirmString)
        {
            if (ModelState.IsValid)
            {
                this.administratorSvc.DeleteProduct(id,confirmString);
                return RedirectToAction(nameof(GetAllProduct));
            }
            //TO DO fixx
            return RedirectToAction(nameof(GetAllProduct));

        }

        [HttpGet]
        public ActionResult CreateCategory()
        {
            return View(new Category());
        }

        [HttpPost]
        public ActionResult CreateCategory(Category category)
        {
            if (ModelState.IsValid)
            {
               this.administratorSvc.CreateCategory(category);

              return  RedirectToAction(nameof(GetAllCategories));
            }

            return View(category);
        }


    }
}