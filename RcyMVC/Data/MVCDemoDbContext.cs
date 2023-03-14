using Microsoft.EntityFrameworkCore;
using RcyMVC.Models.Domain;

namespace RcyMVC.Data
{
    public class MVCDemoDbContext : DbContext
    {
        public MVCDemoDbContext(DbContextOptions options): base(options) {
        }

        public DbSet<Employee> Employees { get; set; }
    }
}
