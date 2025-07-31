namespace TechHaven.Models
{
    public class OrderDetail
    {
        public int OrderDetailID { get; set; }
        public string ProductName { get; set; }
        public int Quantaty { get; set; }
        public int Price { get; set; }

        public Order Order { get; set; }
        public Products Products { get; set; }
    }
}
