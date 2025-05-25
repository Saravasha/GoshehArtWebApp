using GoshehArtWebApp.Models;
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
        public DbSet<Color> Colors { get; set; } = default!;


        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            base.OnModelCreating(modelbuilder);

            modelbuilder.Entity<Color>().HasData(
                new Color { Id = 1, Name = "Background Color", StartColor = "#000000", EndColor = "#000000", DarkStartColor = "#000000", DarkEndColor = "#000000" },
                new Color { Id = 2, Name = "Header Text", StartColor = "#000000", EndColor = "#000000", DarkStartColor = "#000000", DarkEndColor = "#000000" });


            modelbuilder.Entity<Page>().HasData(
                new Page { Id = 1, Title = "Home", Container = "Home"},
                new Page { Id = 2, Title = "Production", Container = "Production"},
                new Page { Id = 3, Title = "About", Container = "About" },
                new Page { Id = 4, Title = "Contact", Container = "Contact" },
                new Page { Id = 5, Title = "Privacy", Container = "Privacy" }
            );

            modelbuilder.Entity<Content>().HasData(
                new Content { Id = 1, Title = "Welcome", Container = "Welcome",  PageId = 1 },
                new Content { Id = 2, Title = "This is what I'm working on", Container = "Process:",  PageId = 2 },
                new Content { Id = 3, Title = "Biography", Container = "Early Life", PageId = 3 },
                new Content { Id = 4, Title = "Social Media", Container = "Faceberrk", PageId = 4 },
                new Content { Id = 5, Title = "Cookie Policy", Container = "We don't use cookies", PageId = 5 },
                new Content { Id = 6, Title = "Privacy Policy", Container = "Pending", PageId = 5 }
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
                new Asset { Id = 1, Name = "Dans under Vita Lakan", Author = "Fateme Gosheh", Description = "Inte sett än", FileUrl= "/Assets/Filmproduktion/image (287).jpg", CategoryId = 8, Type = 0 },
                new Asset { Id = 2, Name = "Aisha's Art", Author = "Fateme Gosheh", Description = "Gods butt from above", FileUrl = "/Assets/Kontroversiell Konst/image (3).jpg", CategoryId = 6, Type = 0 },
                new Asset { Id = 3, Name = "Kari - Jag är elak", Author = "Fateme Gosheh", Description = "Helt fantastiskt", FileUrl = "/Assets/Filmproduktion/image (304).jpg", CategoryId = 8, Type = 0 }
            );


            modelbuilder.Entity<Page>()
                .HasMany(c => c.Contents)
                .WithOne(p => p.Page)
                .HasForeignKey(p => p.PageId)
                .OnDelete(DeleteBehavior.SetNull);
            ;

            modelbuilder.Entity<Asset>()
               .HasMany(p => p.Categories)
               .WithMany(c => c.Assets)
               .UsingEntity(j => j.HasData(
                   new { CategoriesId = 8, AssetsId = 1 },
                   new { CategoriesId = 6, AssetsId = 2 },
                   new { CategoriesId = 8, AssetsId = 3 }
           ));

            modelbuilder.Entity<Asset>()
                .Property(e => e.Date)
                .HasColumnType("date");
            modelbuilder.Entity<Content>()
                .Property(e => e.Date)
                .HasColumnType("date");

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

        }
    }
}
