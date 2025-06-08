namespace Salary_Insights.Core.Models
{
    public class Department
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public int ManagerId { get; set; }

        public Employee Manager { get; set; }

    }
}
