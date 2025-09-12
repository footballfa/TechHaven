using System.ComponentModel.DataAnnotations;

namespace TechHaven.Models
{
    public class OrderDetail
    {
        public int OrderDetailID { get; set; }
        public int OrderID { get; set; }
        public int ProductsID { get; set; }

        // Product name shold be less then 75 characters but more then 1 character and must have a name//
        [Required(ErrorMessage = "Product Name is required.")]
        [StringLength(75, MinimumLength = 1, ErrorMessage = "Product Name must be between 1 and 75 characters.")]
        public string ProductName { get; set; }


        // Quantity must be a number between 1 and 100//
        [Required(ErrorMessage = "Quantity is required.")]
        [Range(1, 100, ErrorMessage = "Quantity must be between 1 and 100.")]
        public int Quantaty { get; set; }

        // Price must be a positive number between 1 and 5000//
        [Required(ErrorMessage = "Price is required.")]
        [Range(1, 5000, ErrorMessage = "Price must be a positive number between 1 and 5,000")]
        public int Price { get; set; }

        public Order Order { get; set; }
        public Products Products { get; set; }
    }
}
