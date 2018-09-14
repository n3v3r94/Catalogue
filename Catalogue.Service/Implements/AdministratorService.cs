
namespace Catalogue.Service.Implements
{
    using Catalogue.Data;
    using Catalogue.Models.EntityModels;
    using Catalogue.Models.ViewModels;
    using System.Collections.Generic;
    using System.Linq;

    public class AdministratorService : IAdministratorService
    {
        private readonly CatalogueDbContext db;

        public AdministratorService(CatalogueDbContext db)
        {
            this.db = db;
        }


        public IEnumerable<Product> GetAllProduct()
        {
            var allProduct = this.db.Products;

            return allProduct.ToList();
        }

        public IEnumerable<Category> GetAllCategories()
        {
            var allCategory = this.db.Categories;


            return allCategory;
        }

        public ProductView FindProduct(int id)
        {

            var prodDb = this.db.Products.FirstOrDefault(p => p.Id == id);

            var prodVm = new ProductView
            {
                Title = prodDb.Title,
                Content = prodDb.Content,
                Price = prodDb.Price,
                Category = prodDb.Category
            };

            return prodVm;
        }


        public void EditProduct(ProductView product, int id)
        {

            var prodDb = this.db.Products.FirstOrDefault(p => p.Id == id);

            if (prodDb != null)
            {
                prodDb.Price = product.Price;
                prodDb.Title = product.Title;
                prodDb.Category = product.Category;
                prodDb.Content = product.Content;
            }

            this.db.Products.Add(prodDb);
            this.db.SaveChanges();

        }

        public void CreateProduct(CreateProductWithCategoryView prod)
        {
            Product tempProduct = new Product
            {
                Title = prod.Title,
                Content = prod.Content,
                Price = prod.Price,
                Category = prod.Category
            };

            this.db.Products.Add(tempProduct);

            foreach (var item in prod.SelectedCategories)
            {
               var currentCategory = this.db.Categories.FirstOrDefault(c => c.Name == item);

                tempProduct.Categories.Add(currentCategory);

            }
            
            db.SaveChanges();

        }

        public void DeleteProduct(int id, string strConfirm)
        {
            var product = this.db.Products.FirstOrDefault(p => p.Id == id);

             

            this.db.Products.Remove(product);
            this.db.SaveChanges();

        }

        public string CreateCategory(Category category)
        {
            try
            {
               db.Categories.Add(category);
                db.SaveChanges();
            }
            catch (System.Exception)
            {

               return  "the name must be unique";
            }

            return "success";
        }
    }
}
