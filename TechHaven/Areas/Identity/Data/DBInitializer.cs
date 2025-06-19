using TechHaven.Models;

namespace TechHaven.Areas.Identity.Data
{
    public class DBInitializer
    {
        public static IEnumerable<Employee> Employees { get; private set; }

        internal static void Initialize(TechHavenContext context)
        {

            // Look for any students. 

            if (context.Customer.Any())

            {

                return;   // DB has been seeded 

            }



            var customers = new Customer[]

            {
                new Customer { FirstName = "Alex", LastName = "Benjaman", Email = "Alex31@gmail.com", Phone = 0220398787, Address = "72 Victoria Street West, Auckland CBD, Auckland 1010, New Zealand" },
                new Customer { FirstName = "Bob", LastName = "The Builder", Email = "Bob123@gmail.com", Phone = 0227291560, Address = "Parnell, Auckland 1010, New Zealand" },
                new Customer {FirstName = "Michael", LastName = "Joradn", Email = "Michael531@gmail.com", Phone = 0227206418,  Address = "22 Princes Street, Auckland CBD, Auckland 1010, New Zealand"},
                new Customer {FirstName = "Mike", LastName = "Tyson", Email = "Mike@gmail.com", Phone = 0212046835, Address = "286 Mount Wellington Highway, Mount Wellington, Auckland 1060, New Zealand"},
                new Customer {FirstName = "Max", LastName = "farewel", Email = "Max@gmail.com", Phone = 0221839472, Address = "Motions Road, Western Springs, Auckland 1022, New Zealand"},
                new Customer {FirstName = "Jhon", LastName = "Jones", Email = "Jhon@gmail.com", Phone = 0221768503, Address = "Wellesley Street East, Auckland CBD, Auckland 1010, New Zealand"},
                new Customer {FirstName = "David", LastName = "Hallen", Email = "David@gmail.com", Phone = 0219204176, Address = "Reimers Avenue, Kingsland, Auckland 1024, New Zealand"},
                new Customer {FirstName = "William", LastName = "Finn", Email = "William@gmail.com", Phone = 0221395842, Address = "Tamaki Drive, Mission Bay, Auckland 1071, New Zealand"},
                new Customer {FirstName = "Joe", LastName = "Rogan", Email = "Joe@gmail.com", Phone = 0222057936, Address = "2 Park Road, Grafton, Auckland 1023, New Zealand"},
                new Customer {FirstName = "Khabib", LastName = "Nurmagomedov", Email = "Khabib@gmail.com", Phone = 0221483705, Address = "210 Victoria Street West, Auckland CBD, Auckland 1010, New Zealand"},

            };

            foreach (Customer c in customers)

            {

                context.Customer.Add(c);

            }

            context.SaveChanges();


            context.Database.EnsureCreated();


            var Employees = new Employee[]
           {
                 new Employee {EmployeeName = "William", EmployeeRole = "Receptionist", LoginCredentials = 5345 },
                 new Employee {EmployeeName = "Ahmad", EmployeeRole = "Receptionist", LoginCredentials = 5332 },
                 new Employee {EmployeeName = "Yousef", EmployeeRole = "Receptionist", LoginCredentials = 2456 },
                 new Employee {EmployeeName = "Yashveen", EmployeeRole = "Receptionist  ", LoginCredentials = 5432 },
                 new Employee {EmployeeName = "Jhon", EmployeeRole =  "Receptionist", LoginCredentials = 8654 },
                 new Employee {EmployeeName = "Alexander the first", EmployeeRole = "Receptionist", LoginCredentials = 3467 },
                 new Employee {EmployeeName = "Max", EmployeeRole = "Receptionist", LoginCredentials = 8753 },
                 new Employee {EmployeeName = "Jones", EmployeeRole = "Receptionist", LoginCredentials = 2457},
                 new Employee { EmployeeName = "Suria", EmployeeRole = "Receptionist", LoginCredentials = 1467 },
                 new Employee {EmployeeName = "Ronaldo", EmployeeRole = "Receptionist", LoginCredentials = 4678 },
                  };
                foreach (Employee e in Employees)
                 {
                context.Employee.Add(e);
                  }
            context.SaveChanges();

            context.Database.EnsureCreated();

            var Orders = new Order[]
            {
                new Order { OrderDate = 09/5/23, TottalPrice = 1300, ProductName = "HP Laptop"},
                new Order { OrderDate = 02/7/23, TottalPrice = 1250, ProductName = "Iphone 16 pro max"},
                new Order { OrderDate = 05/3/23, TottalPrice = 700, ProductName = "Acer Chromebook"},
                new Order { OrderDate = 04/5/24, TottalPrice = 1000, ProductName = "Mac book"},
                new Order { OrderDate = 08/5/24, TottalPrice = 999, ProductName = "Ipad Pro"},
                new Order { OrderDate = 26/6/24, TottalPrice = 1370, ProductName = "PC"},
                new Order { OrderDate = 17/8/24, TottalPrice = 2700, ProductName = "samsong odessy Monitor"},
                new Order { OrderDate = 18/11/24, TottalPrice = 2000, ProductName = "Samsung Tv"},
                new Order { OrderDate = 29/12/24, TottalPrice = 1500, ProductName = "Gamming Laptop"},
                new Order { OrderDate = 30/12/24, TottalPrice= 1200, ProductName = "HP Laptop"},
            };
            foreach (Order o in Orders)
            {
                context.Order.Add(o);
            }
            context.SaveChanges();

            

        }
    }
}
