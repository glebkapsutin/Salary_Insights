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
        Task<User?> GetUserByIdAsync(int id);
        Task AddUserAsync(User user);
        Task UpdateUserAsync(User user);
        Task DeleteUserAsync(User user);
        Task<bool> UserExists(int id);
        Task<User?> GetUserByEmailAsync(string email);
    }
}