

namespace Catalogue.Data
{
    using Catalogue.Models;
    using Catalogue.Models.EntityModels;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure.Annotations;

    public class CatalogueDbContext : IdentityDbContext<User>
    {
        public CatalogueDbContext() : base("CatalogueDbContext")
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        
       

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            modelBuilder
                .Entity<Product>()
                .HasMany(c => c.Categories)
                .WithMany(p => p.Products);

            modelBuilder
                .Entity<Category>()
                 .Property(t => t.Name)
                    .HasColumnAnnotation(
                          "Index",
                        new IndexAnnotation(new[]
                              {
                          new IndexAttribute("Index1"),
                          new IndexAttribute("Index2") { IsUnique = true }

                   }));

            modelBuilder.Entity<Product>().Property(p => p.Price).HasPrecision(12, 10);
           
        }
        public static CatalogueDbContext Create()
        {
            return new CatalogueDbContext();
        }

    }
}
