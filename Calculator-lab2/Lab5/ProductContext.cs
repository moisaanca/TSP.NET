using System.Data.Entity;

namespace Calculator_lab2.Lab5
{
    public class ProductContext: System.Data.Entity.DbContext
    {
        public System.Data.Entity.DbSet<Product> Products { get; set; }

        public ProductContext() : base("name=ProductContext")
        { }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Product>()
            .Map(m =>
            {
                m.Properties(p => new { p.SKU, p.Description, p.Price });
                m.ToTable("Product", "BazaDeDate");
            })
            .Map(m =>
            {
                m.Properties(p => new { p.SKU, p.ImageURL });
                m.ToTable("ProductWebInfo", "BazaDeDate");
            });
        }

    }
}
