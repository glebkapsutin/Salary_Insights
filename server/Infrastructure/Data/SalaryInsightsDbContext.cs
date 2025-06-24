using Salary_Insights.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace Salary_Insights.Infrastructure.Data
{
    public class SalaryInsightsDbContext : DbContext
    {
        public SalaryInsightsDbContext(DbContextOptions<SalaryInsightsDbContext> options) : base(options)
        {
        }
        public DbSet<Department> Departments { get; set; }

        public DbSet<Employee> Employees { get; set; }

        public DbSet<Position> Positions { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<Role> Roles { get; set; }

        public DbSet<Salary> Salarys { get; set; }

        public DbSet<SalaryHistory> SalaryHistory { get; set; }




    }
}
