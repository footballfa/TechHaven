using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TechHaven.Models;

namespace TechHaven.Areas.Identity.Data;

public class TechHavenContext : IdentityDbContext<IdentityUser>
{
    public TechHavenContext(DbContextOptions<TechHavenContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
    }

public DbSet<TechHaven.Models.Customer> Customer { get; set; } = default!;

public DbSet<TechHaven.Models.Employee> Employee { get; set; } = default!;

public DbSet<TechHaven.Models.Order> Order { get; set; } = default!;

public DbSet<TechHaven.Models.OrderDetail> OrderDetail { get; set; } = default!;

public DbSet<TechHaven.Models.Products> Products { get; set; } = default!;

public DbSet<TechHaven.Models.Suppliers> Suppliers { get; set; } = default!;
}
