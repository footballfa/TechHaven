using System.ComponentModel.DataAnnotations;

namespace TechHaven.Models
{
    public class Products
    {
        public int ProductsID { get; set; }
        public int SuppliersId { get; set; }

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

        // Stock status must be under 50 characters//
        [Required(ErrorMessage = "Stock status is required.")]
        [StringLength(50, ErrorMessage = "Stock status must be under 50 characters.")]
        public string Stock { get; set; }

        public Suppliers Suppliers { get; set; }
        public ICollection<OrderDetail> OrderDetails { get; set; }

    }
}
