using Microsoft.EntityFrameworkCore;
using Mission06_Hatch.Models;

var builder = WebApplication.CreateBuilder(args);

// Add SQLite Database Connection
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    // changed the DB parameter to point to the new one for the assignment
    options.UseSqlite("Data Source=JoelHiltonMovieCollection.db"));

builder.Services.AddControllersWithViews();

var app = builder.Build();

app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
