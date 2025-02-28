using GoshehArtWebApp.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.FileProviders;
using System.Drawing.Text;
using System.IO;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = "";
if (builder.Environment.IsDevelopment())  
{
    connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
} else
{
    connectionString = Environment.GetEnvironmentVariable("CONNECTION_STRING");
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

// Fileprovider för Uploads utanför webrooten
void UploadDirectoryAsserter()
{
    // Gets App root path's parent directory and does a combine with Uploads, checks if directory Uploads exists under parent directory, if not then it creates it => Adds a new PhysicalFileProvider for Upload Path.
    string path = Path.Combine(Directory.GetParent(Environment.CurrentDirectory).ToString(),"Uploads");
    if (!Directory.Exists(path))
    {
        Directory.CreateDirectory(path);
    }

    app.UseStaticFiles(new StaticFileOptions()
    {
        FileProvider = new PhysicalFileProvider(
        Path.Combine(path, "Uploads")),
        RequestPath = "/Uploads"
    });
}

UploadDirectoryAsserter();

// Fileprovider för Assets rekursivt
var baseDirectory = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Assets");
AddStaticFilesRecursively(baseDirectory, app);

void AddStaticFilesRecursively(string directory, WebApplication app)
{
    var fileProvider = new PhysicalFileProvider(directory);

    app.UseStaticFiles(new StaticFileOptions
    {
        FileProvider = fileProvider,
        RequestPath = "/" + Path.GetFileName(directory) 
    });

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
