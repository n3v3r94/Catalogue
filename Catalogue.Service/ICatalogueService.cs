
namespace Catalogue.Service
{
    using Catalogue.Models.EntityModels;
    using Catalogue.Models.ViewModels;
    using System.Collections.Generic;
    public interface ICatalogueService
    {
        IEnumerable<ProductWithCategories> GetAllProduct();
        IEnumerable<ProductView> SerarByCategories(string category);

        DropDownCategoriesView GetAllCategories();
      
    }
}
