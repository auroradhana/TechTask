namespace TechTask.Domain.Models
{
    public class Order : Entity
    {
        public int CustomerId { get; set; }
        public DateTime OrderDate { get; set; }
        public string Status { get; set; }
        public int TotalCost { get; set; }
        public string Comment { get; set; }

        public Customer Customer { get; set; }
        public IEnumerable<Product> Products { get; set; }
    }
}
