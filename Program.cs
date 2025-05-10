using GoshehArtWebApp.Data;
using GoshehArtWebApp.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.FileProviders;
using System.Text.Json.Serialization;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = "";
if (builder.Environment.IsDevelopment())  
{
    connectionString = builder.Configuration.GetConnectionString("DatabaseConnection") ?? throw new InvalidOperationException("Connection string 'DatabaseConnection' not found.");
    builder.Services.AddDatabaseDeveloperPageExceptionFilter();
} else
{
    connectionString = Environment.GetEnvironmentVariable("CONNECTION_STRING") ?? throw new InvalidOperationException("Connection string 'CONNECTION_STRING' not found.");
}

builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));
builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = false)
    .AddRoles<IdentityRole>()
    .AddEntityFrameworkStores<ApplicationDbContext>();
builder.Services.AddControllersWithViews().AddJsonOptions(x =>
                x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);

builder.Services.AddDirectoryBrowser();


var allowedOrigins = builder.Configuration.GetSection("AllowedOrigins").Get<string[]>();

builder.Services.AddCors(options =>
    options.AddPolicy("corsPolicy",
        policy =>
    {
    policy.WithOrigins(allowedOrigins)
          .AllowAnyMethod()
          .AllowAnyHeader();
    })
);

builder.Services.Configure<IdentityOptions>(options =>
{
    options.Password.RequireDigit = false;
    options.Password.RequireNonAlphanumeric = false;
    options.Password.RequireLowercase = false;
    options.Password.RequiredUniqueChars = 1;
    options.Password.RequireUppercase = false;
    options.Password.RequiredLength = 6;
});

builder.Services.ConfigureApplicationCookie(options =>
{
    // Cookie settings
    options.ExpireTimeSpan = TimeSpan.FromMinutes(5);

    options.Cookie.SecurePolicy = CookieSecurePolicy.Always;
    options.LoginPath = "/Identity/Account/Login";
    options.AccessDeniedPath = "/Identity/Account/AccessDenied";
    options.SlidingExpiration = true;
});


builder.Services.AddTransient<IEmailSender, SmtpEmailSender>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{

    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for wproduction wscenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
    app.UseHttpsRedirection();

}


if (app.Environment.IsProduction())

{
    var smtpSettings = builder.Configuration.GetSection("Smtp").Get<SmtpSettings>();
    if (smtpSettings == null)
    {
        Console.WriteLine("SMTP settings are null.");
    }
    if (string.IsNullOrWhiteSpace(smtpSettings.Host) ||
        string.IsNullOrWhiteSpace(smtpSettings.Username) ||
        string.IsNullOrWhiteSpace(smtpSettings.Password) ||
        string.IsNullOrWhiteSpace(smtpSettings.From) ||
        smtpSettings.Port == 0)
    {
        throw new InvalidOperationException("Missing required SMTP configuration values.");
    }
}

app.UseStaticFiles();

// Fileprovider f�r Uploads utanf�r webrooten
void UploadDirectoryAsserter()
{
    // Gets App root path's parent directory and does a combine with Uploads, checks if directory Uploads exists under parent directory, if not then it creates it => Adds a new PhysicalFileProvider for Upload Path...
    string path = Path.Combine(Directory.GetParent(Environment.CurrentDirectory).ToString(),"Uploads");
    if (!Directory.Exists(path))
    {
        Directory.CreateDirectory(path);
    }

    app.UseStaticFiles(new StaticFileOptions()
    {
        FileProvider = new PhysicalFileProvider(
        path),
        RequestPath = "/Uploads"
    });
}

UploadDirectoryAsserter();

// Fileprovider f�r Assets rekursivt
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

    try
    {
        var subdirectories = Directory.GetDirectories(directory);
        foreach (var subdirectory in subdirectories)
        {
            AddStaticFilesRecursively(subdirectory, app);
        }
    }
    catch (Exception ex)
    {
        // Log error in case of issues
        Console.WriteLine($"Error reading directory {directory}: {ex.Message}");
    }
}


app.UseRouting();

app.UseCors("corsPolicy");

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapRazorPages();

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    var config = services.GetRequiredService<IConfiguration>();
    try
    {
        await SeedData.InitializeAsync(services, config);
    }
    catch (Exception ex)
    {
        // Log error if seed data initialization fails
        Console.WriteLine($"Error initializing seed data: {ex.Message}");
    }
}


app.Run();
