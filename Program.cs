using GoshehArtWebApp.Data;
using GoshehArtWebApp.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.FileProviders;
using System.Text.Json.Serialization;


var builder = WebApplication.CreateBuilder(args);

builder.Configuration.AddEnvironmentVariables();
// Add services to the container.
var connectionString = "";
if (builder.Environment.IsDevelopment())  
{
    connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
    builder.Services.AddDatabaseDeveloperPageExceptionFilter();
} else if (builder.Environment.IsStaging())
{
    connectionString = Environment.GetEnvironmentVariable("CONNECTION_STRING") ?? throw new InvalidOperationException("Connection string 'CONNECTION_STRING' (Staging from Github Secrets) not found.");
}
else
{
    connectionString = Environment.GetEnvironmentVariable("CONNECTION_STRING") ?? throw new InvalidOperationException("Connection string 'CONNECTION_STRING' not found."); 
}
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));
builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = false)
    .AddRoles<IdentityRole>()
    .AddEntityFrameworkStores<ApplicationDbContext>();
builder.Services.AddControllersWithViews().AddJsonOptions(x =>
{
    x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
    x.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
});

builder.Services.AddDirectoryBrowser();

builder.Services.AddScoped<FilePathProvider>();
builder.Services.AddScoped<VideoThumbnailProvider>();
builder.Services.AddScoped<AssetTypeProvider>();


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

    Console.WriteLine("AccessDeniedPath: " + options.AccessDeniedPath); // Debug output
    // Cookie settings
    options.LoginPath = "/Identity/Account/Login";
    options.AccessDeniedPath = "/Identity/Account/AccessDenied";
    options.ExpireTimeSpan = TimeSpan.FromMinutes(5);

    options.Cookie.SecurePolicy = CookieSecurePolicy.Always;
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


SmtpSettings smtpSettings = builder.Configuration.GetSection("Smtp").Get<SmtpSettings>();

Console.WriteLine("SMTP Host from env: " + Environment.GetEnvironmentVariable("Smtp__Host"));

Console.WriteLine($"SMTP_HOST: {smtpSettings?.Host}");
Console.WriteLine($"SMTP_PORT: {smtpSettings?.Port}");
Console.WriteLine($"SMTP_USERNAME: {smtpSettings?.Username}");
Console.WriteLine($"SMTP_FROM: {smtpSettings?.From}");

if (smtpSettings == null ||
    string.IsNullOrWhiteSpace(smtpSettings.Host) ||
    string.IsNullOrWhiteSpace(smtpSettings.Username) ||
    string.IsNullOrWhiteSpace(smtpSettings.Password) ||
    string.IsNullOrWhiteSpace(smtpSettings.From) ||
    smtpSettings.Port == 0)
{
    throw new InvalidOperationException("Missing required SMTP configuration values.");
}



app.UseStaticFiles();

// Fileprovider för Uploads utanför webrooten

void DirectoryAsserter(string path,string NewRequestPath)
{

    if (!Directory.Exists(path))
    {
        Directory.CreateDirectory(path);
    }

    app.UseStaticFiles(new StaticFileOptions()
    {
        FileProvider = new PhysicalFileProvider(
        path),
        RequestPath = NewRequestPath
    });
}


using (var scope = app.Services.CreateScope())
{
    var filePathProvider = scope.ServiceProvider.GetRequiredService<FilePathProvider>();

    DirectoryAsserter(filePathProvider.UploadsRoot, "/Uploads");

    AddStaticFilesRecursively(filePathProvider.WebAssetsRoot, app);
    Console.WriteLine($"UploadsRoot: {filePathProvider.UploadsRoot}");
    Console.WriteLine($"WebAssetsRoot: {filePathProvider.WebAssetsRoot}");
}
void AddStaticFilesRecursively(string directory, WebApplication app)
{
    DirectoryAsserter(directory, "/" + Path.GetFileName(directory));
    
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

if (app.Environment.IsStaging())

{
    using var scope = app.Services.CreateScope();
    var dbContext = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
    Console.WriteLine(dbContext.Database.GetConnectionString());
    
    var filePathProvider = scope.ServiceProvider.GetRequiredService<FilePathProvider>();

    var robotsPath = filePathProvider.RobotsTxtPath;

    try
    {
        if (!File.Exists(robotsPath))
        {
            Directory.CreateDirectory(Path.GetDirectoryName(robotsPath)!);
            File.WriteAllText(robotsPath, "User-agent: *\nDisallow: /");
            Console.WriteLine("Created staging robots.txt to block crawlers.");
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine("Failed to write robots.txt: " + ex.Message);
    }


    try
    {
        dbContext.Database.Migrate();
        Console.WriteLine("EF Core migrations applied successfully to staging database.");
    }
    catch (Exception ex)
    {
        Console.WriteLine("Failed to apply EF Core migrations:");
        Console.WriteLine(ex.Message); 
        app.Logger.LogError(ex, "Exception during SeedData initialization.");
        // Optional: rethrow or log to file
    }
}

app.Run();
