﻿namespace TechHaven.Models
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public int OrderID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int Phone { get; set; }
        public string Address { get; set; }


        public Order Order { get; set; }
    }
}
