namespace TechTask.API.Dtos.Order
{
    public class OrderResultDto
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public string CustomerAddress { get; set; }
        public string TotalCost { get; set; }
        public string Status { get; set; }
    }
}
