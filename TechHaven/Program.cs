using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Identity;
using TechHaven.Areas.Identity.Data;
var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("TechHavenContextConnection") ?? throw new InvalidOperationException("Connection string 'TechHavenContextConnection' not found.");

builder.Services.AddDbContext<TechHavenContext>(options => options.UseSqlServer(connectionString));

builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddRoles<IdentityRole>()
    .AddEntityFrameworkStores<TechHavenContext>();



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



app.UseAuthentication();



app.UseAuthorization();
app.MapRazorPages();


app.MapControllerRoute(

    name: "default",

    pattern: "{controller=Home}/{action=Index}/{id?}");

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    var userManager = services.GetRequiredService<UserManager<IdentityUser>>();
    var context = services.GetRequiredService<TechHavenContext>();
    var roleManager = services.GetRequiredService<RoleManager<IdentityRole>>();
    DBInitializer.Initialize(context); // Removed the second argument
}

app.Run();