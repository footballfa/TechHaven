namespace TechHaven.Models
{
    public class OrderDetail
    {
        public int OrderDetailID { get; set; }
        public string ProductName { get; set; }
        public int Quantaty { get; set; }
        public int Price { get; set; }
        public ICollection<Order> Order { get; set; }
        public ICollection<Products> Products { get; set; }
    }
}
