using System.ComponentModel.DataAnnotations.Schema;

namespace server.Core.Models
{
    public class SalaryHistory
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public decimal PreviousAmount { get; set; }
        public decimal NewAmount { get; set; }
        public DateTime ChangeDate { get; set; }
        public string Reason { get; set; }

        public Employee Employee { get; set; }

       
    }
}
