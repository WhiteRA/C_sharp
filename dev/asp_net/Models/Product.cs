namespace asp_net.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public int GroupId { get; set; }
        public Group Group { get; set; }
    }
}
