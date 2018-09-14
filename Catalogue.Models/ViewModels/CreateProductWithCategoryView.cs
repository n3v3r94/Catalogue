using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace Catalogue.Models.ViewModels
{
    public class CreateProductWithCategoryView
    {
        [Required]
        [StringLength(100, MinimumLength = 3)]
        public string Title { get; set; }


        [Required]
        [StringLength(250, MinimumLength = 3)]
        public string Content { get; set; }


        [Required]
        public decimal Price { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 3)]
        public virtual string Category { get; set; }

        public List<SelectListItem> Categories { get; set; } = new List<SelectListItem>();

        public List<string> SelectedCategories { get; set; } = new List<string>();
    }
}
