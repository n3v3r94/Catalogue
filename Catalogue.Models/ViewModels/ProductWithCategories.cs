
namespace Catalogue.Models.ViewModels
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Web.Mvc;

    public class ProductWithCategories
    {
        [Required]
        [StringLength(100, MinimumLength = 3)]
        public string Title { get; set; }


        [Required]
        [StringLength(250, MinimumLength = 3)]
        public string Content { get; set; }


        [Required]
        public decimal Price { get; set; }

       
        public List<string> Categories { get; set; } = new List<string>(); 
    }
}
