namespace TechTask.Domain.Models
{
    public class Customer : Entity
    {
        public string Name { get; set; }
        public string Adress { get; set; }
        public int TotalOrdered { get; set; }
        public int OrdersCount { get; set; }

        public IEnumerable<Order> Orders { get; set; }
    }
}
