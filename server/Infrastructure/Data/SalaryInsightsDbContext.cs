using Salary_Insights.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace Salary_Insights.Infrastructure.Data
{
    public class SalaryInsightsDbContext : DbContext
    {
        public SalaryInsightsDbContext(DbContextOptions<SalaryInsightsDbContext> options) : base(options)
        {
        }
    }
}
