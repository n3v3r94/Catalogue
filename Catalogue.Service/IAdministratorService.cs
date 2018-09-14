
namespace Catalogue.Service
{
    using Catalogue.Models.EntityModels;
    using Catalogue.Models.ViewModels;
    using System.Collections.Generic;

    public interface IAdministratorService
    {
        IEnumerable<Product> GetAllProduct();

        IEnumerable<Category> GetAllCategories();

        void CreateProduct(CreateProductWithCategoryView prod);

        ProductView FindProduct(int id);

        void EditProduct(ProductView product, int id);

        void DeleteProduct(int id, string strConfirm);

        string CreateCategory(Category category);
    }
}
