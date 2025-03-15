using GoshehArtWebApp.Models;
using GoshehArtWebApp.Secrets;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace GoshehArtWebApp.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Page> Pages { get; set; } = default!;
        public DbSet<Content> Contents { get; set; } = default!;
        public DbSet<Category> Categories { get; set; } = default!;
        public DbSet<Asset> Assets { get; set; } = default!;


        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            base.OnModelCreating(modelbuilder);


            modelbuilder.Entity<Page>().HasData(
                new Page { Id = 1, Title = "Home", Container = "", ContentId = 1 },
                new Page { Id = 2, Title = "Production", Container = "", ContentId = 2 },
                new Page { Id = 3, Title = "About", Container = "" , ContentId = 3 },
                new Page { Id = 4, Title = "Contact", Container = "" , ContentId = 5 },
                new Page { Id = 5, Title = "Privacy", Container = "" , ContentId = 1 }
            );

            modelbuilder.Entity<Content>().HasData(
                new Content { Id = 1, Body = "", Title = "Welcome", PageId = 1 },
                new Content { Id = 2, Body = "", Title = "This is what I'm working on", PageId = 2 },
                new Content { Id = 3, Body = "", Title = "Biography", PageId = 3 },
                new Content { Id = 4, Body = "", Title = "Social Media", PageId = 4 },
                new Content { Id = 5, Body = "", Title = "Cookie Policy", PageId = 5 },
                new Content { Id = 6, Body = "", Title = "Privacy Policy", PageId = 5 }
            );


            modelbuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Film" },
                new Category { Id = 2, Name = "Liljevalchs 2001" },
                new Category { Id = 3, Name = "Stop-motion" },
                new Category { Id = 4, Name = "Press" },
                new Category { Id = 5, Name = "Foto" },
                new Category { Id = 6, Name = "Kontroversiell Konst" },
                new Category { Id = 7, Name = "Abstrakt Konst" },
                new Category { Id = 8, Name = "Akvarell Konst" }
            );

            modelbuilder.Entity<Asset>().HasData(
                new Asset { Id = 1, Name = "Dans under Vita Lakan", Author = "Fateme Gosheh", Description = "Inte sett än", ImageUrl = "/Assets/Filmproduktion/image (287).jpg", CategoryId = 8 },
                new Asset { Id = 2, Name = "Aisha's Art", Author = "Fateme Gosheh", Description = "Gods butt from above", ImageUrl = "/Assets/Kontroversiell Konst/image (3).jpg", CategoryId = 6 },
                new Asset { Id = 3, Name = "Kari - Jag är elak", Author = "Fateme Gosheh", Description = "Helt fantastiskt", ImageUrl = "/Assets/Filmproduktion/image (304).jpg", CategoryId = 8 }
            );


            modelbuilder.Entity<Page>()
                .HasMany(e => e.Contents)
                .WithOne(e => e.Page)
                .HasForeignKey(e => e.PageId)
                .IsRequired(false)
            ;

            modelbuilder.Entity<Asset>()
               .HasMany(p => p.Categories)
               .WithMany(c => c.Assets)
               .UsingEntity(j => j.HasData(
                   new { CategoriesId = 8, AssetsId = 1 },
                   new { CategoriesId = 6, AssetsId = 2 },
                   new { CategoriesId = 8, AssetsId = 3 }
           ));




            //modelbuilder.Entity<Page>()
            //    .HasMany(c => c.Contents)
            //    .WithOne(p => p.Page)
            //    .HasForeignKey(k => k.PageId)
            //    .IsRequired(false);

            string adminRoleId = Guid.NewGuid().ToString();
            string userRoleId = Guid.NewGuid().ToString();
            string userId = Guid.NewGuid().ToString();

            modelbuilder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = adminRoleId,
                Name = "Admin",
                NormalizedName = "ADMIN"
            });
            modelbuilder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = userRoleId,
                Name = "User",
                NormalizedName = "USER"

            });

            // Changing Password injector based on environment variable instead of storing it in source control.
            var secret = "";
            if (Environment.GetEnvironmentVariable("DOTNET_ENVIRONMENT") == "Production" || Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") == "Production")
            {
                secret = Environment.GetEnvironmentVariable("ADMIN_PASSWORD");
            } else
            {
                IConfigurationRoot conf = new ConfigurationBuilder().AddUserSecrets<Password>().Build();
                secret = conf["Passwords:Admin"];
            }

            // Ensure secret is not null or empty
            if (string.IsNullOrEmpty(secret))
            {
                throw new InvalidOperationException("Password cannot be null or empty.");
            }

            PasswordHasher<IdentityUser> passwordHasher = new PasswordHasher<IdentityUser>();


            modelbuilder.Entity<IdentityUser>().HasData(new IdentityUser
            {
                Id = userId,
                Email = "admin@admin.com",
                NormalizedEmail = "ADMIN@ADMIN.COM",
                UserName = "Admin",
                NormalizedUserName = "ADMIN@ADMIN.COM",
                PasswordHash = passwordHasher.HashPassword(null, secret)
            });

            modelbuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = adminRoleId,
                UserId = userId,
            });

        }
    }
}
