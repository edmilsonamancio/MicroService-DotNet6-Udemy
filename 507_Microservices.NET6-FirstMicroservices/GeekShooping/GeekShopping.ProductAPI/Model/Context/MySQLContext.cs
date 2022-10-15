using Microsoft.EntityFrameworkCore;

namespace GeekShopping.ProductAPI.Model.Context
{
    public class MySQLContext : DbContext
    {
        public MySQLContext() {}

        public MySQLContext(DbContextOptions<MySQLContext> options) : base(options) {}

        public DbSet<Product> Products { set; get; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(new Product { 
                Id = 2,
                Name = "Caderno 2",
                Price = new decimal(69.9),
                Description = "Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum",
                ImageUrl = "https://www.google.com.br",
                CategoryName = "Papelaria"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 3,
                Name = "Caderno 3",
                Price = new decimal(69.9),
                Description = "Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum",
                ImageUrl = "https://www.google.com.br",
                CategoryName = "Papelaria"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 4,
                Name = "Caderno 4",
                Price = new decimal(69.9),
                Description = "Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum",
                ImageUrl = "https://www.google.com.br",
                CategoryName = "Papelaria"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 5,
                Name = "Caderno 5",
                Price = new decimal(69.9),
                Description = "Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum",
                ImageUrl = "https://www.google.com.br",
                CategoryName = "Papelaria"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 6,
                Name = "Caderno 6",
                Price = new decimal(69.9),
                Description = "Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum",
                ImageUrl = "https://www.google.com.br",
                CategoryName = "Papelaria"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 7,
                Name = "Caderno 7",
                Price = new decimal(69.9),
                Description = "Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum",
                ImageUrl = "https://www.google.com.br",
                CategoryName = "Papelaria"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 8,
                Name = "Caderno 8",
                Price = new decimal(69.9),
                Description = "Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum",
                ImageUrl = "https://www.google.com.br",
                CategoryName = "Papelaria"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 9,
                Name = "Caderno 9",
                Price = new decimal(69.9),
                Description = "Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum",
                ImageUrl = "https://www.google.com.br",
                CategoryName = "Papelaria"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 10,
                Name = "Caderno 10",
                Price = new decimal(69.9),
                Description = "Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum",
                ImageUrl = "https://www.google.com.br",
                CategoryName = "Papelaria"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 11,
                Name = "Caderno 11",
                Price = new decimal(69.9),
                Description = "Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum",
                ImageUrl = "https://www.google.com.br",
                CategoryName = "Papelaria"
            });
        }
    }
}
