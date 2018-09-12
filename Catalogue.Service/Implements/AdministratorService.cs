
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


        public IEnumerable<Product>GetAllProduct()
        {
            var  allProduct = this.db.Products;

            return allProduct.ToList();
        }

        public IEnumerable<Category> GetAllCategories()
        {
            var allCategory = this.db.Categories;

            return allCategory;
        }


        public void CreateProduct(ProductView prod)
        {
            Product tempProduct = new Product
            {
                Title = prod.Title,
                Content = prod.Content,
                Price = prod.Price,
                Category = prod.Category
            };

            this.db.Products.Add(tempProduct);
            db.SaveChanges();

        }

      
    }
}
