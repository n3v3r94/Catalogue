
namespace Catalogue.Service
{
    using Catalogue.Models.EntityModels;
    using Catalogue.Models.ViewModels;
    using System.Collections.Generic;

    public interface IAdministratorService
    {
        IEnumerable<Product> GetAllProduct();

        IEnumerable<Category> GetAllCategories();

        void CreateProduct(ProductView prod);
    }
}
