namespace TechHaven.Models
{
    public class Products
    {
        public int ProductsID { get; set; }
        public string ProductName { get; set; }
        public  int Quantaty { get; set; }
        public int Price { get; set; }
        public string Stock { get; set; }
        public OrderDetail OrderDetail { get; set; }
        public ICollection<Suppliers> Supplier { get; set; }

    }
}
