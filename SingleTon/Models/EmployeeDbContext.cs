using Microsoft.EntityFrameworkCore;

namespace SingleTon.Models
{
    public class EmployeeDbContext : DbContext
    {
        public EmployeeDbContext()
        {
                
        }
        public DbSet<Employee> Employees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=SF-CPU-032\\SQLEXPRESS;Initial Catalog=Practical-22;Integrated Security=True;Trusted_Connection=SSPI;Encrypt=false;TrustServerCertificate=true");
        }
    }
}
