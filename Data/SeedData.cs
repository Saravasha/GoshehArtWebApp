using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace GoshehArtWebApp.Data
{
    public static class SeedData
    {
        public static async Task InitializeAsync(IServiceProvider serviceProvider, IConfiguration configuration)
        {
            var userManager = serviceProvider.GetRequiredService<UserManager<IdentityUser>>();
            var roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();

            string adminEmail = "admin@admin.com";
            string adminUserName = "Admin";
            string adminRole = "Admin";

            // Get password from secrets or environment
            string? adminPassword;

            if (Environment.GetEnvironmentVariable("DOTNET_ENVIRONMENT") == "Production" ||
                Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") == "Production")
            {
                adminPassword = Environment.GetEnvironmentVariable("ADMIN_PASSWORD");
            }
            else
            {
                adminPassword = configuration["Passwords:Admin"];
            }

            if (string.IsNullOrWhiteSpace(adminPassword))
            {
                throw new InvalidOperationException("Admin password not configured.");
            }

            // Ensure Admin role exists
            if (!await roleManager.RoleExistsAsync(adminRole))
            {
                await roleManager.CreateAsync(new IdentityRole(adminRole));
            }

            // Find admin user
            var adminUser = await userManager.FindByEmailAsync(adminEmail);

            if (adminUser == null)
            {
                // Create new admin user
                adminUser = new IdentityUser
                {
                    UserName = adminUserName,
                    Email = adminEmail,
                    EmailConfirmed = true
                };

                var createResult = await userManager.CreateAsync(adminUser, adminPassword);
                if (!createResult.Succeeded)
                {
                    throw new Exception("Failed to create admin user: " + string.Join(", ", createResult.Errors.Select(e => e.Description)));
                }
            }
            else
            {
                // Reset password if user already exists
                var token = await userManager.GeneratePasswordResetTokenAsync(adminUser);
                var resetResult = await userManager.ResetPasswordAsync(adminUser, token, adminPassword);
                if (!resetResult.Succeeded)
                {
                    throw new Exception("Failed to reset admin password: " + string.Join(", ", resetResult.Errors.Select(e => e.Description)));
                }
            }

            // Add to Admin role if not already
            if (!await userManager.IsInRoleAsync(adminUser, adminRole))
            {
                await userManager.AddToRoleAsync(adminUser, adminRole);
            }

        }
    }
}
