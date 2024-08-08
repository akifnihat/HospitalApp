using Hospital_App.Entities;
using Microsoft.EntityFrameworkCore;

namespace Hospital_App.Data
{
    public class HospitalDbContext : DbContext
    {
        public DbSet<Department> Departments { get; set; }
        public HospitalDbContext(DbContextOptions options) : base(options)
        {

        }
        
    }
}
