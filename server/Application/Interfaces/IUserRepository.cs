using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Salary_Insights.Core.Models;

namespace Salary_Insights.Application.Interfaces
{
    public interface IUserRepository
    {
        Task<IEnumerable<User>> GetAllUsersAsync();

        Task <User?> GetUSerByIdAsync(int id);
        
        Task AddUserAsync(User user);
        Task UpdateUserAsync(User user);
        Task DeleteUserAsync(User user);
        Task<User?> GetUserByEmailAsync(string email);
        
    }
}