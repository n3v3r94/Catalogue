namespace Catalogue.Service
{
    using System.Collections.Generic;
    using System.Linq;
    using Catalogue.Data;
    using Catalogue.Models.ViewModels;

    public class CatalogueService : ICatalogueService
    {
        private readonly CatalogueDbContext db;

        public CatalogueService(CatalogueDbContext db)
        {
            this.db = db;
        }

        public IEnumerable<ProductView> GetAllProduct()
        {
            var allProducts = this.db.Products.Select(p => new ProductView
            {
                Title = p.Title,
                Content = p.Content,
                Price = p.Price,
                Category = p.Category,
            });

            return allProducts.ToList();
        }

     
    }
}
