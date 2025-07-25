﻿namespace server.Core.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public int DepartmentId { get; set; }

        public Department Department { get; set; }

        public Position Position { get; set; }

        public int PositionId { get; set; }
        
        public DateTime HireDate { get; set; }

        public DateTime TerminationDate { get; set; }

        public List<Salary> Salaries { get; set; }



    }
}
