using EmployeeInfoAPI.Model;
using Microsoft.EntityFrameworkCore;

namespace EmployeeInfoAPI.DataAccess
{
    public class EmployeeDBContext : DbContext
    {
        public EmployeeDBContext(DbContextOptions<EmployeeDBContext> options) : base(options)
        {
        }

        public DbSet<EmployeeInfo> EmployeeInfo { get; set; }
    }
}