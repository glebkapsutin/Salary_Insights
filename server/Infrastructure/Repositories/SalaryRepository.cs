using Microsoft.EntityFrameworkCore;
using server.Application.Interfaces;
using server.Core.Models;
using server.Infrastructure.Data;

namespace Salary_Insights.Infrastructure.Repositories
{
    public class SalaryRepository : ISalaryRepository
    {   
        private readonly SalaryInsightsDbContext _context;

        public SalaryRepository(SalaryInsightsDbContext context)
        {
            _context = context;
        }
        public async Task AddAsync(Salary salary)
        {
            await _context.Salarys.AddAsync(salary);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Salary salary)
        {
            _context.Salarys.Remove(salary);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Salary>> GetAllAsync()
        {
            return await _context.Salarys.ToListAsync();
        }

        public async Task<Salary?> GetByIdAsync(int id)
        {
            return await _context.Salarys.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task UpdateAsync(Salary salary)
        {
            var existingSalary = await _context.Salarys.FindAsync(salary.Id);
            if (existingSalary == null)
            {
                throw new KeyNotFoundException($"Salary with ID {salary.Id} not found.");
            }

            existingSalary.Amount = salary.Amount;
            existingSalary.Date = salary.Date;
            existingSalary.EmployeeId = salary.EmployeeId;

            await _context.SaveChangesAsync();
        }

       
    }
}
