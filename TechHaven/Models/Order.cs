namespace TechHaven.Models
{
    public class Order
    {
        public int OrderID { get; set; }
        public int CustomersID { get; set; }
        public int EmployeeID { get; set; }
        public int OrderDate { get; set; }
        public int TottalPrice { get; set; }
        public string ProductName { get; set; }
        public Customer Customer { get; set; }
        public Employee Employee { get; set; }
        public OrderDetail OrderDetail { get; set; }


    }
}
