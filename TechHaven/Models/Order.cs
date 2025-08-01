﻿using System.ComponentModel.DataAnnotations;

namespace TechHaven.Models
{
    public class Order
    {
        public int OrderID { get; set; }


        public int EmployeeID { get; set; }


        public int OrderDetailId {get; set;}


        [Required(ErrorMessage = "Order Date is required.")]
        [DataType(DataType.Date)]
        [Display(Name = "Order Date")]
        public int OrderDate { get; set; }


        [Required(ErrorMessage = "Total Price is required.")]
        public int TottalPrice { get; set; }


        [Required(ErrorMessage = "Product Name is required.")]
        [StringLength(100, MinimumLength = 1, ErrorMessage = "Product Name must be between 2 and 100 characters.")]
        public string ProductName { get; set; }


        public Customer Customer { get; set; }
        public Employee Employee { get; set; }
        public ICollection<OrderDetail> OrderDetails { get; set; }

    }
}
