using System.ComponentModel.DataAnnotations;

namespace TechHaven.Models
{
    public class OrderDetail
    {
        public int OrderDetailID { get; set; }
        public int OrderID { get; set; }
        public int ProductsID { get; set; } 


        [Required(ErrorMessage = "Product Name is required.")]
        [StringLength(75, MinimumLength = 1, ErrorMessage = "Product Name must be between 1 and 75 characters.")]
        public string ProductName { get; set; }


        [Required(ErrorMessage = "Quantity is required.")]
        [Range(1, 100, ErrorMessage = "Quantity must be between 1 and 100.")]
        public int Quantaty { get; set; }


        [Required(ErrorMessage = "Price is required.")]
        [Range(1, 5000, ErrorMessage = "Price must be a positive number between 1 and 5,000")]
        public int Price { get; set; }

        public Order Order { get; set; }
        public Products Products { get; set; }
    }
}
