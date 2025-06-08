using System.ComponentModel.DataAnnotations;

namespace Salary_Insights.Core.Models
{
    public class User
    {
        public int Id { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        public string PasswordHash { get; set; }
        [Required, EmailAddress]
        public string Email { get; set; }
        public string Role { get; set; }
    }
}
