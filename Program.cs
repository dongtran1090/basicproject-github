using cham.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services
builder.Services.AddControllersWithViews();
builder.Services.Configure<GeminiConfig>(builder.Configuration.GetSection("Gemini"));
builder.Services.AddHttpClient();

var app = builder.Build();

// Use middleware
app.UseStaticFiles();
app.UseRouting();
app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}");
    endpoints.MapControllers(); // Ð?m b?o map API controller
});

app.Run();
