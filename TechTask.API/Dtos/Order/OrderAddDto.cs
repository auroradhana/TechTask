namespace TechTask.API.Dtos.Order
{
    public class OrderAddDto
    {
        public int OrderNumber { get; set; }
        public DateTime OrderDate { get; set; }
        public int CustomerId { get; set; }
        public string Status { get; set; }
        public IEnumerable<Domain.Models.Product> Products { get; set; }
        public string Comment { get; set; }

    }
}
