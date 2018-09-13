namespace Catalogue.Service
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Web.Mvc;
    using Catalogue.Data;
    using Catalogue.Models.EntityModels;
    using Catalogue.Models.ViewModels;

    public class CatalogueService : ICatalogueService
    {
        private readonly CatalogueDbContext db;

        public CatalogueService(CatalogueDbContext db)
        {
            this.db = db;
        }



        public IEnumerable<ProductWithCategories> GetAllProduct()
        {
     
            var res = this.db.Products.Include("Categories");

            List<ProductWithCategories> prodWithCategories = new List<ProductWithCategories>();

            foreach (var product in res)
            {
                ProductWithCategories tempProduct = new ProductWithCategories();
                tempProduct.Title = product.Title;
                tempProduct.Price = product.Price;
                tempProduct.Content = product.Content;
                foreach (var categories in product.Categories)
                {
                    tempProduct.Categories.Add(categories.Name);
                }

                prodWithCategories.Add(tempProduct);
            }

            return prodWithCategories;
        }

        public IEnumerable<ProductView> SerarByCategories(string search)
        {
           var   productWirhCategoris =  db.Products.Include("Categories");

            List<ProductView> product = new List<ProductView>();

            foreach (var item in productWirhCategoris)
            {
                foreach (var category in item.Categories)
                {
                    if (search == category.Name)
                    {
                        ProductView tempProduct = new ProductView
                        {
                            Title = item.Title,
                            Category = item.Category,
                            Price = item.Price,
                            Content = item.Content,

                        };
                     product.Add(tempProduct);

                    }

                }
            }

            return product;
        }

        public   DropDownCategoriesView GetAllCategories()
        {
            var categories = db.Categories.ToList();

            DropDownCategoriesView dropDown = new DropDownCategoriesView();


            foreach (var item in categories)
            {
            
                dropDown.Categories.Add(new SelectListItem
                {
                    Text = item.Name,
                    Value = item.Name
                });
               
            }

            return dropDown;
        }
    }
}
