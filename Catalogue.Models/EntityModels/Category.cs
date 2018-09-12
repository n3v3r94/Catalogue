

namespace Catalogue.Models.EntityModels
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Category
    {
        public Category()
        {
            this.Products = new HashSet<Product>();
        }

        public int Id { get; set; }

        [Index]
        [Column(TypeName = "VARCHAR")]
        [StringLength(150, MinimumLength =3)]
        public  string Name { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
