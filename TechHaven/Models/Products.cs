namespace TechHaven.Models
{
    public class Products
    {
        public int ProductsID { get; set; }
        public int OrderDetailId { get; set; } // Foreign key
        public string ProductName { get; set; }
        public int Quantaty { get; set; }
        public int Price { get; set; }
        public string Stock { get; set; }

        public OrderDetail OrderDetail { get; set; } // Navigation property
        public ICollection<Suppliers> Suppliers { get; set; }
    }
}
