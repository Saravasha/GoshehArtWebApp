using GoshehArtWebApp.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.FileProviders;
using System.Drawing.Text;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = "";
if (builder.Environment.IsDevelopment())  
{
    connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
} else
{
    connectionString = builder.Configuration.GetConnectionString(Environment.GetEnvironmentVariable("CONNECTION_STRING")) ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
    Console.WriteLine(connectionString);
}

builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();
builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = false)
    .AddEntityFrameworkStores<ApplicationDbContext>();
builder.Services.AddControllersWithViews();

builder.Services.AddDirectoryBrowser();

var app = builder.Build();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
   
    app.UseMigrationsEndPoint();
}
else
{
    //app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();


var baseDirectory = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot");

// Recursively find all subdirectories and add them
AddStaticFilesRecursively(baseDirectory, app);

void AddStaticFilesRecursively(string directory, WebApplication app)
{
    // Create a PhysicalFileProvider for this directory
    var fileProvider = new PhysicalFileProvider(directory);

    // Serve static files from this directory
    app.UseStaticFiles(new StaticFileOptions
    {
        FileProvider = fileProvider,
        RequestPath = "/" + Path.GetFileName(directory)  // You can adjust the request path here
    });

    // Recursively add subdirectories
    var subdirectories = Directory.GetDirectories(directory);
    foreach (var subdirectory in subdirectories)
    {
        AddStaticFilesRecursively(subdirectory, app);
    }
}

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapRazorPages();

app.Run();
