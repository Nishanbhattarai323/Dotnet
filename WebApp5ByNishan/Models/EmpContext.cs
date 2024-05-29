using Microsoft.EntityFrameworkCore;
using WebApp5ByNishan.Models;

namespace WebApp5ByNishan.Data
{
    public class EmpContext : DbContext
    {
        public EmpContext(DbContextOptions<EmpContext> options) : base(options) { }

        public DbSet<Employees> Employees { get; set; }
    }
}