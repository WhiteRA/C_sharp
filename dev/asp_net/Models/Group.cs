namespace asp_net.Models
{
    public class Group
    {
        public int GroupId { get; set; }
        public string GroupName { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}

}
