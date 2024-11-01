using DogsMVC.Models;

namespace DogsMVC;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // St�d f�r controllers och views
        builder.Services.AddControllersWithViews();
        builder.Services.AddSingleton<DataService>();
        var app = builder.Build();
        app.UseStaticFiles();

        app.MapControllers();

        //app.MapControllerRoute()

        app.Run();

    }
}
