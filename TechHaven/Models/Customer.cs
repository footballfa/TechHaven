using System.ComponentModel.DataAnnotations;

namespace TechHaven.Models
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public int OrderID { get; set; }
        [StringLength(12)]
        public string FirstName { get; set; }
        [StringLength(12)]
        public string LastName { get; set; }
        public string Email { get; set; }
        public int Phone { get; set; }
        public string Address { get; set; }


        public ICollection<Order> Order { get; set; }
    }
}
