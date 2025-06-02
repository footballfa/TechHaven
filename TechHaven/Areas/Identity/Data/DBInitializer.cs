using TechHaven.Models;

namespace TechHaven.Areas.Identity.Data
{
    public class DBInitializer
    {
        internal static void Initialize(TechHavenContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.Customer.Any())
            {
                return;   // DB has been seeded
            }

            var customers = new Customer[]
            {
                new Customer { FirstName = "Alex", LastName = "Benjaman", Email = "Alex31@gmail.com" },
                new Customer { FirstName = "Bob", LastName = "The Builder", Email = "Bob123@gmail.com" },
                new Customer { FirstName = "Michael", LastName = "Joradn", Email = "Michael531@gmail.com" },
                new Customer { FirstName = "Mike", LastName = "Tyson", Email = "Mike@gmail.com" },
                new Customer { FirstName = "Max", LastName = "farewel", Email = "Max@gmail.com" },
                new Customer { FirstName = "Jhon", LastName = "Jones", Email = "Jhon@gmail.com" },
                new Customer { FirstName = "David", LastName = "Hallen", Email = "David@gmail.com" },
                new Customer { FirstName = "William", LastName = "Finn", Email = "William@gmail.com" },
                new Customer { FirstName = "Joe", LastName = "Rogan", Email = "Joe@gmail.com" },
                new Customer { FirstName = "Khabib", LastName = "Nurmagomedov", Email = "Khabib@gmail.com" },
            };
            foreach (Customer c in customers)
            {
                context.Customer.Add(c);
            }
            context.SaveChanges();

        }
    }
}
