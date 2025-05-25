namespace TechHaven.Models
{
    public class Employee
    {
        
        public int EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeRole { get; set; }
        public int LoginCredentials { get; set; }
        public Order order { get; set; }
    }
}
