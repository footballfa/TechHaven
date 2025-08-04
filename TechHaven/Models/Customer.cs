using System.ComponentModel.DataAnnotations;

namespace TechHaven.Models
{
    public class Customer
    {
        public int CustomerID { get; set; }



        [RegularExpression(@"^[A-Z]+[a-zA-Z]*$")]
        [Required]
        [StringLength(12, MinimumLength= 1, ErrorMessage = "First name must be between 1 and 12 characters")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }


        [RegularExpression(@"^[A-Z]+[a-zA-Z]*$")]
        [Required]
        [Display(Name = "Last Name")]
        [StringLength(12, MinimumLength = 1, ErrorMessage = "Last name must be between 1 and 12 characters")]
        public string LastName { get; set; }


        //must be in email format for example "jonathon@gmail.com"//
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }


        //phone number needs to be a number and limited to 10 characters//
        [Required]
        [Range(0210000000, 0229999999, ErrorMessage = "Please enter a vaild phone number (021-0000000,022-0000000)")]
        [Display(Name = "Phone Number")]
        public int Phone { get; set; }


        //the minimum length of the address is 5 and max is 100//
        [Required(ErrorMessage = "Address is required")]
        [StringLength(75, MinimumLength = 3, ErrorMessage = "Address must be between 5 and 100 characters")]
        public string Address { get; set; }


        public ICollection<Order> Order { get; set; }
    }
}
