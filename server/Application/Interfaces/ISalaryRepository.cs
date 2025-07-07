using server.Core.Models;

namespace server.Application.Interfaces
{
    public interface ISalaryRepository
    {
        Task<IEnumerable<Salary>> GetAllAsync();

        public Task<Salary?> GetByIdAsync(int id);

        public Task AddAsync(Salary salary);

        public Task UpdateAsync(Salary salary);

        public Task DeleteAsync(Salary salary);
    }
}
