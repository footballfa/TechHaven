namespace TechHaven.Models
{
    public class Order
    {
        public int OrderID { get; set; }
        public int OrderDate { get; set; }
        public string TottalPrice { get; set; }
        public OrderDetail OrderDetail { get; set; }
        public ICollection<Customer> Customer { get; set; }
    }
}
