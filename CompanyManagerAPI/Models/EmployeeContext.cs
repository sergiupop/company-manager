using Microsoft.EntityFrameworkCore;

namespace CompanyManagerAPI.Models
{
    public class EmployeeContext: DbContext
    {
        public EmployeeContext(DbContextOptions options): base(options) { }

        DbSet<Employee> Employees { get; set; }
    }
}
