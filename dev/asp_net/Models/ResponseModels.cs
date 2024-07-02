namespace asp_net
{
    public class GroupResponseModel
    {
        public int GroupId { get; set; }
        public string GroupName { get; set; }
        public string Message { get; set; }
    }

    public class ProductResponseModel
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public string Message { get; set; }
    }

    public class DeleteResponseModel
    {
        public string Message { get; set; }
    }

}
