using System.ComponentModel.DataAnnotations;

namespace TechHaven.Models
{
    public class Employee
    {
        
        public int EmployeeID { get; set; }


        //First name has to have uppercase and limited to 12 characters//
        [RegularExpression(@"^[A-Z]+[a-zA-Z]*$")]
        [Required]
        [StringLength(12, MinimumLength = 1, ErrorMessage = "Name must be between 1 and 12 characters")]
        [Display(Name = "First Name")]
        public string EmployeeName { get; set; }

        //limited to 25 characters and must have something written//
        [Required]
        [StringLength(25)]
        public string EmployeeRole { get; set; }


        [Required]
        [Range(1000, 9999, ErrorMessage = "LoginCredentials must be a 4-digit number.")]
        public int LoginCredentials { get; set; }



        public ICollection<Order> Order { get; set; }
        


    }
}
