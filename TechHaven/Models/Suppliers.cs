using System.ComponentModel.DataAnnotations;

namespace TechHaven.Models
{
    public class Suppliers
    {
        public int SuppliersID { get; set; }



        // Supplier name must be less then 100 characters but more then 1 character and must have a name//
        [Required(ErrorMessage = "Supplier Name is required.")]
        [StringLength(100, MinimumLength = 1, ErrorMessage = "Supplier Name must be between 1 and 100 characters.")]
        public string SupplierName { get; set; }

        // Supplier contact number needs to be a number and limited to 10 characters that either starts with 021 or 022//
        [Required]
        [Range(0210000000, 0229999999, ErrorMessage = "Please enter a vaild phone number (021-0000000,022-0000000)")]
        public int SupplierContact { get; set; }

        // Supplier product must be less then 100 characters and must have a name//
        [Required(ErrorMessage = "Product information is required.")]
        [StringLength(100, ErrorMessage = "Product name must be under 100 characters.")]
        public string SupplierProduct { get; set; }

        // Delivery time must be in date format//
        public int DeliveryTime { get; set; }


        public ICollection<Products> Product { get; set; }

    }


}      