
namespace Catalogue.Service
{
    using System.Collections.Generic;
    using Catalogue.Models.EntityModels;
    using Catalogue.Models.ViewModels;
    public interface ICatalogueService
    {
        IEnumerable<ProductView> GetAllProduct();
    }
}
