

namespace Catalogue.Models.EntityModels
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
   public class Product
    {
        public Product()
        {
            this.Categories = new HashSet<Category>();
        }
        public int Id { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 3)]
        public  string Title { get; set; }

        [Required]
        [StringLength(250, MinimumLength = 3)]
        public  string Content { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 3)]
        public virtual string Category { get; set; }

        public virtual ICollection<Category> Categories { get; set; }
    }
}
