using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Identity;
using TechHaven.Areas.Identity.Data;
var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("TechHavenContextConnection") ?? throw new InvalidOperationException("Connection string 'TechHavenContextConnection' not found.");

builder.Services.AddDbContext<TechHavenContext>(options => options.UseSqlServer(connectionString));

builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true).AddEntityFrameworkStores<TechHavenContext>();


builder.Services.AddControllersWithViews();

var app = builder.Build();






// Configure the HTTP request pipeline. 

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");

    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts. 

    app.UseHsts();

}



app.UseHttpsRedirection();

app.UseStaticFiles();


app.UseRouting();



app.UseAuthorization();



app.UseAuthorization();
app.MapRazorPages();


app.MapControllerRoute(

    name: "default",

    pattern: "{controller=Home}/{action=Index}/{id?}");

Initializer.Add(app);

app.Run();