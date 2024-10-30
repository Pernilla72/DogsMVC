namespace DogsMVC;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Stöd för controllers och views
        builder.Services.AddControllersWithViews();
        var app = builder.Build();
        app.UseStaticFiles();

        app.MapControllers();

        app.Run();

    }
}
