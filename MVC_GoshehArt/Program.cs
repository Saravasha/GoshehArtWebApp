using Microsoft.AspNetCore.Identity;
using System.Text.Json.Serialization;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using MVC_GoshehArt.Data;
using MVC_GoshehArt.Models;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("MVC_GoshehArt_DbContextConnection") ?? throw new InvalidOperationException("Connection string 'MVC_GoshehArt_DbContextConnection' not found.");
// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddMvc();
builder.Services.AddRazorPages();
builder.Services.AddControllers().AddJsonOptions(x =>
                x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);

builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options
    .UseSqlServer(builder.Configuration
    .GetConnectionString("MVC_GoshehArt_DbContextConnection") ?? throw new InvalidOperationException("Connection string 'MVC_GoshehArt_DbContext' not found.")));

builder.Services.AddDefaultIdentity<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = false).AddRoles<IdentityRole>().AddEntityFrameworkStores<ApplicationDbContext>();

builder.Services.AddCors(p => p.AddPolicy("corsPolicy", builder => {
    builder.WithOrigins("http://localhost:3000")
    .AllowAnyMethod()
    .AllowAnyHeader();
}));

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
    options.Cookie.HttpOnly = true;
    options.ExpireTimeSpan = TimeSpan.FromMinutes(5);

    options.LoginPath = "/Identity/Account/Login";
    options.AccessDeniedPath = "/Identity/Account/AccessDenied";
    options.SlidingExpiration = true;
});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseStaticFiles();

app.UseRouting();
app.UseCors("corsPolicy");

app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.MapRazorPages();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}",
    defaults: new { controller = "Home", action = "Index" });
app.Run();
