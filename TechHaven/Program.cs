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

CreateDbIfNotExists(app);

static void CreateDbIfNotExists(IHost host)

{
    using (var scope = host.Services.CreateScope())
    {
        var services = scope.ServiceProvider;
        try
        {
            var context = services.GetRequiredService<TechHavenContext>();
            DBInitializer.Initialize(context);
        }

        catch (Exception ex)

        {

            var logger = services.GetRequiredService<ILogger<Program>>();

            logger.LogError(ex, "An error occured creating the DB");

        }

    }

}



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


app.Run();