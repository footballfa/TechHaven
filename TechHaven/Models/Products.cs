namespace TechHaven.Models
{
    public class Products
    {
        public int ProductsID { get; set; }
        public int OrderDetail { get; set; }
        public string ProductName { get; set; }
        public  int Quantaty { get; set; }
        public int Price { get; set; }
        public string Stock { get; set; }

        public OrderDetail OrderDetails { get; set; }
        public ICollection<Suppliers> Supplier { get; set; }

    }
}
