using Microsoft.EntityFrameworkCore;

namespace WebApiByNishan.Models
{
    public class ApiDemoDbContext:DbContext
    {
        public ApiDemoDbContext(DbContextOptions<ApiDemoDbContext> options) : base(options)
        {

        }
        public DbSet<Users> Users { get; set; }
    }
}
