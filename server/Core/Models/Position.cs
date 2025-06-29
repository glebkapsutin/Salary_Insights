namespace server.Core.Models
{
    public class Position
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public decimal SalaryMax { get; set; }
        public decimal SalaryMin { get; set; }

    }
}
