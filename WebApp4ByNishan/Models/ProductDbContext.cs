using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace WebApp4ByNishan.Models
{
    public class ProductDbContext: DbContext
    {
        public ProductDbContext(DbContextOptions<ProductDbContext> options) : base(options)
        {

        }
        // Here, 'products' represents the table in DB
        // NOTE: The table should be a property
        public DbSet<Product> Products { get; set; }
    }
}
