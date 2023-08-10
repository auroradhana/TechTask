namespace TechTask.Domain.Models
{
    public class Product : Entity
    {
        public int OrderId { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }

        public Order Order { get; set; }
    }
}
