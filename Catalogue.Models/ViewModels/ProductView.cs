
namespace Catalogue.Models.ViewModels
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Web.Mvc;

    public class ProductView
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

            
    }
}
