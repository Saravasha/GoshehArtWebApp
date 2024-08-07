using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GoshehArtWebApp.Migrations
{
    /// <inheritdoc />
    public partial class finalizingImageUrl : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "23e528e2-2827-473d-a468-eb8d9c13bd03");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "5a3f860d-566b-45ca-9b73-25510efbded5", "0566a226-c9a8-400a-b7a9-31a5aa3adebe" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5a3f860d-566b-45ca-9b73-25510efbded5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0566a226-c9a8-400a-b7a9-31a5aa3adebe");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "14857add-5cef-45ea-b4f7-10b74e134eeb", null, "User", "USER" },
                    { "77d08c37-2005-4711-b66f-9e573477c532", null, "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "13d8efcc-54d8-456b-8e25-eafa3f1654d9", 0, "356ac614-7c06-4e85-af24-c423b7b121fa", "admin@admin.com", false, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAIAAYagAAAAEJq6AZjX0zDIrY+F51fy5dYu2AWNHgirja3qr+ipQoCUaT3P+4WO6Vz/3Ds/xJ/AvQ==", null, false, "0ad92ddd-b56d-4e6f-953e-d042ed444015", false, "Admin" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "77d08c37-2005-4711-b66f-9e573477c532", "13d8efcc-54d8-456b-8e25-eafa3f1654d9" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "14857add-5cef-45ea-b4f7-10b74e134eeb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "77d08c37-2005-4711-b66f-9e573477c532", "13d8efcc-54d8-456b-8e25-eafa3f1654d9" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "77d08c37-2005-4711-b66f-9e573477c532");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "13d8efcc-54d8-456b-8e25-eafa3f1654d9");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "23e528e2-2827-473d-a468-eb8d9c13bd03", null, "User", "USER" },
                    { "5a3f860d-566b-45ca-9b73-25510efbded5", null, "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "0566a226-c9a8-400a-b7a9-31a5aa3adebe", 0, "f86970c5-fab4-43a1-9b5d-686d332aad8b", "admin@admin.com", false, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAIAAYagAAAAEDbamVsulnum9hlqqtMml6QGKLVfYDbp2MHj+ybnjjnlQKg41PUdw6+1KPCkI+DzsQ==", null, false, "91d5790b-2845-429c-a6bc-b10e41590466", false, "Admin" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "5a3f860d-566b-45ca-9b73-25510efbded5", "0566a226-c9a8-400a-b7a9-31a5aa3adebe" });
        }
    }
}
