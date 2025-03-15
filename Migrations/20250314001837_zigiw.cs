using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GoshehArtWebApp.Migrations
{
    /// <inheritdoc />
    public partial class zigiw : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "55b7536b-22bd-4179-a497-e11641ce0ada");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "30c8cd50-4b97-4805-b2f1-74e2efefefff", "37c2edd6-ef32-468f-a5c9-ed835f45142e" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "30c8cd50-4b97-4805-b2f1-74e2efefefff");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "37c2edd6-ef32-468f-a5c9-ed835f45142e");

            migrationBuilder.RenameColumn(
                name: "Container",
                table: "Contents",
                newName: "Body");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "642f0823-61ff-4342-949a-a69d2a319f51", null, "User", "USER" },
                    { "7ee290fb-105e-46cf-b177-41e9e82693f4", null, "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "e5d5656e-b35d-4cc1-a22c-736a6aad41d8", 0, "f5ca36d4-f723-4747-b928-1fb17fc0c43a", "admin@admin.com", false, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAIAAYagAAAAEJaQ8V6zKhDmEDa0DYKotSbniHmBlNZikxtmPrrEIwr0xWGiH6oVpEElXmEPy8G3IA==", null, false, "47625cd0-e333-4b04-ba17-cf15cf1b8971", false, "Admin" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "7ee290fb-105e-46cf-b177-41e9e82693f4", "e5d5656e-b35d-4cc1-a22c-736a6aad41d8" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "642f0823-61ff-4342-949a-a69d2a319f51");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "7ee290fb-105e-46cf-b177-41e9e82693f4", "e5d5656e-b35d-4cc1-a22c-736a6aad41d8" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7ee290fb-105e-46cf-b177-41e9e82693f4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e5d5656e-b35d-4cc1-a22c-736a6aad41d8");

            migrationBuilder.RenameColumn(
                name: "Body",
                table: "Contents",
                newName: "Container");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "30c8cd50-4b97-4805-b2f1-74e2efefefff", null, "Admin", "ADMIN" },
                    { "55b7536b-22bd-4179-a497-e11641ce0ada", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "37c2edd6-ef32-468f-a5c9-ed835f45142e", 0, "dbe3de43-d29b-4e00-b3ee-164ed0842c57", "admin@admin.com", false, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAIAAYagAAAAEEA+BGmVmH37UOKsVqhDSKKEXpB8xCViMZUWA/gB8zuX5VX5Sr+g3VEF/D39SnMdVw==", null, false, "86ac12bb-f6bf-4481-a87f-053cb85b9d08", false, "Admin" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "30c8cd50-4b97-4805-b2f1-74e2efefefff", "37c2edd6-ef32-468f-a5c9-ed835f45142e" });
        }
    }
}
