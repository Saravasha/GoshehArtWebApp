using GoshehArtWebApp.Models;
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
        public DbSet<Category> Categories { get; set; } = default!;
        public DbSet<Asset> Assets { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            base.OnModelCreating(modelbuilder);


            modelbuilder.Entity<Page>().HasData(new Page { Title = "Home", Content = "" });
            modelbuilder.Entity<Page>().HasData(new Page { Title = "Production", Content = "" });
            modelbuilder.Entity<Page>().HasData(new Page { Title = "About", Content = "" });
            modelbuilder.Entity<Page>().HasData(new Page { Title = "Contact", Content = "" });

            modelbuilder.Entity<Category>().HasData(new Category { Id = 1, Name = "Film" });
            modelbuilder.Entity<Category>().HasData(new Category { Id = 2, Name = "Liljevalchs 2001" });
            modelbuilder.Entity<Category>().HasData(new Category { Id = 3, Name = "Stop-motion" });
            modelbuilder.Entity<Category>().HasData(new Category { Id = 4, Name = "Press" });
            modelbuilder.Entity<Category>().HasData(new Category { Id = 5, Name = "Foto" });
            modelbuilder.Entity<Category>().HasData(new Category { Id = 6, Name = "Kontroversiell Konst" });
            modelbuilder.Entity<Category>().HasData(new Category { Id = 7, Name = "Abstrakt Konst" });
            modelbuilder.Entity<Category>().HasData(new Category { Id = 8, Name = "Akvarell Konst" });

            modelbuilder.Entity<Asset>().HasData(new Asset { Id = 1, Name = "Dans under Vita Lakan", Author = "Fateme Gosheh", Description = "Inte sett än", ImageUrl = "", CategoryId = 1 });
            modelbuilder.Entity<Asset>().HasData(new Asset { Id = 2, Name = "Aisha's Art", Author = "Fateme Gosheh", Description = "Gods butt from above", ImageUrl = "placeholder", CategoryId = 2 });
            modelbuilder.Entity<Asset>().HasData(new Asset { Id = 3, Name = "Kari - Jag är elak", Author = "Fateme Gosheh", Description = "Helt fantastiskt", ImageUrl = "placeholder", CategoryId = 3 });

            modelbuilder.Entity<Asset>()
               .HasMany(p => p.Categories)
               .WithMany(c => c.Assets)
               .UsingEntity(j => j.HasData(
                   new { CategoriesId = 1, AssetsId = 3 },
                   new { CategoriesId = 2, AssetsId = 1 },
                   new { CategoriesId = 3, AssetsId = 2 }
           ));


            //modelbuilder.Entity<Person>().HasData(new Person { Id = 1, Name = "Siavash Gosheh", PhoneNumber = "xxxx-xxx666", CityId = 1 });
            //modelbuilder.Entity<Person>().HasData(new Person { Id = 2, Name = "Maxwell T Bird", PhoneNumber = "Mr. Max Tv @ Youtube", CityId = 2 });
            //modelbuilder.Entity<Person>().HasData(new Person { Id = 3, Name = "Nergal", PhoneNumber = "666", CityId = 3 });
            //modelbuilder.Entity<Person>()
            //    .HasMany(l => l.Languages)
            //    .WithMany(p => p.People)
            //    .UsingEntity(j => j.HasData(new { LanguagesId = 2, PeopleId = 2 }));
            //modelbuilder.Entity<Person>()
            //    .HasMany(l => l.Languages)
            //    .WithMany(p => p.People)
            //    .UsingEntity(j => j.HasData(new { LanguagesId = 3, PeopleId = 3 }));

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

            PasswordHasher<IdentityUser> passwordHasher = new PasswordHasher<IdentityUser>();
            modelbuilder.Entity<IdentityUser>().HasData(new IdentityUser
            {
                Id = userId,
                Email = "admin@admin.com",
                NormalizedEmail = "ADMIN@ADMIN.COM",
                UserName = "Admin",
                NormalizedUserName = "ADMIN@ADMIN.COM",
                PasswordHash = passwordHasher.HashPassword(null, "password")
            });

            modelbuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = adminRoleId,
                UserId = userId,
            });

        }
    }
}