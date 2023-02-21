using BlakesBananas.Controllers;
using System.Data.Entity;

namespace BlakesBananas.Models
{
    public class ProductContext : DbContext
    {
        public ProductContext() : base("BlakesBananas")
        {
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
