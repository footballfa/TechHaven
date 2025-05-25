using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TechHaven.Models;

    public class TechHavenContext : DbContext
    {
        public TechHavenContext (DbContextOptions<TechHavenContext> options)
            : base(options)
        {
        }

        public DbSet<TechHaven.Models.Customer> Customer { get; set; } = default!;

public DbSet<TechHaven.Models.Order> Order { get; set; } = default!;

public DbSet<TechHaven.Models.OrderDetail> OrderDetail { get; set; } = default!;

public DbSet<TechHaven.Models.Products> Products { get; set; } = default!;

public DbSet<TechHaven.Models.Suppliers> Suppliers { get; set; } = default!;

public DbSet<TechHaven.Models.Employee> Employee { get; set; } = default!;
    }
