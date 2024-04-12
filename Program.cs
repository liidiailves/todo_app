using Microsoft.EntityFrameworkCore;
using System.Globalization;
using Todo_app.Data;
using Todo_app.Services;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add SQLite database context
        builder.Services.AddDbContext<AppDbContext>(options =>
        {
            options.UseSqlite("Data Source=app.db");
        });

        //builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("AppDbContext") ?? throw new InvalidOperationException("Connection string 'AppDbContext' not found.")));


        // Add services to the container
        builder.Services.AddControllersWithViews();
        builder.Services.AddScoped<ITodoItemService, TodoItemService>();


        var app = builder.Build();

        // Configure the HTTP request pipeline
        if (!app.Environment.IsDevelopment())
        {
            app.UseExceptionHandler("/Home/Error");
        }

        app.UseStaticFiles();

        app.UseRouting();

        app.UseAuthorization();

        app.MapControllerRoute(
            name: "default",
            pattern: "{controller=TodoItems}/{action=Index}/{id?}");

        using (var serviceScope = app.Services.CreateScope())
        {
            var context = serviceScope.ServiceProvider.GetService<AppDbContext>();
            AppDbInitializer.Seed(context);
        }

        // Set estonian language
        CultureInfo culture = new CultureInfo("et-EE");
        CultureInfo.DefaultThreadCurrentCulture = culture;
        CultureInfo.DefaultThreadCurrentUICulture = culture;

        app.Run();
    }
}