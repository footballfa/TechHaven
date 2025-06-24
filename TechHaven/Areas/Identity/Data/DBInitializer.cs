using TechHaven.Models;

namespace TechHaven.Areas.Identity.Data
{
  
        public class Initializer()
        {

            public static void Add(IApplicationBuilder applicationBuilder)
            {
                using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
                {


                    var context = serviceScope.ServiceProvider.GetRequiredService<TechHavenContext>();

                    context.Database.EnsureCreated();
                    if (context.Customer.Any())
                    {
                        return;   // DB has been seeded   
                    }
               



                    var Supplier = new Suppliers[]



                      {



                new Suppliers {SupplierName = "Olivia Bennett" , SupplierContact = 0221787597 , DeliveryTime = 1021  , SupplierProduct = "Samsung Monitors" },

                new Suppliers {SupplierName = "Liam Carter" , SupplierContact = 0222714487 , DeliveryTime = 0624 , SupplierProduct = "Sony"},

                new Suppliers {SupplierName = "Ava Thompson" , SupplierContact = 0228397878 , DeliveryTime = 8011 , SupplierProduct = "Microsoft Xbox"},

                new Suppliers {SupplierName = "Noah Patel" , SupplierContact = 0229976385 , DeliveryTime = 1024 , SupplierProduct = "Apple Iphones"},

                new Suppliers {SupplierName = "Mia Robinson" , SupplierContact = 0214241942 , DeliveryTime = 1011 , SupplierProduct = "Logitech"},

                new Suppliers {SupplierName = "Ethan Walker" , SupplierContact = 0220668927 , DeliveryTime = 0622 , SupplierProduct = "Samsung Phones"},

                new Suppliers {SupplierName = "Isabella Mitchell" , SupplierContact = 0228771043 , DeliveryTime = 6012 , SupplierProduct = "Asus Laptops"},

                new Suppliers {SupplierName = "Lucas Edwards" , SupplierContact = 0210774283 , DeliveryTime = 6011 , SupplierProduct = "HP Laptops"},

                new Suppliers {SupplierName = "Charlotte Hayes" , SupplierContact = 0227619487 , DeliveryTime = 1010 , SupplierProduct = "Meta Quest"},

                new Suppliers {SupplierName = "Jack Morrison" , SupplierContact = 0223878767 , DeliveryTime = 1052 , SupplierProduct = "Bose Headphones" }



                      };



                    foreach (Suppliers s in Supplier)

                    {

                        context.Suppliers.Add(s);

                    }

                    context.SaveChanges();







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

                }







            }



        }

    }
