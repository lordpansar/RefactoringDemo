namespace RefactoringDemo.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public DateTime CreateDateUtc { get; set; }
        public List<int>? OrderItems { get; set; }
        public string? OrderStatus { get; set; }
    }
}
