using System.ComponentModel.DataAnnotations;

namespace TechHaven.Models
{
    public class Suppliers
    {
        public int SuppliersID { get; set; }


        

        [Required(ErrorMessage = "Supplier Name is required.")]
        [StringLength(100, MinimumLength = 1, ErrorMessage = "Supplier Name must be between 1 and 100 characters.")]
        public string SupplierName { get; set; }


        [Required]
        [Range(0210000000, 0229999999, ErrorMessage = "Please enter a vaild phone number (021-0000000,022-0000000)")]
        public int SupplierContact { get; set; }


        [Required(ErrorMessage = "Product information is required.")]
        [StringLength(100, ErrorMessage = "Product name must be under 100 characters.")]
        public string SupplierProduct { get; set; }


        [Required(ErrorMessage = "Delivery time is required.")]
        [Range(0, 9999, ErrorMessage = "Delivery time must be a 4-digit number.")]
        public int DeliveryTime { get; set; }


        public ICollection<Products> Product { get; set; }

    }


}      