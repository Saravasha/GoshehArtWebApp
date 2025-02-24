using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GoshehArtWebApp.Migrations
{
    /// <inheritdoc />
    public partial class cmonman2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "016506ac-19ac-4a9a-9ee8-00d1e33793c9");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "a12f4b74-beef-4e30-9766-496ea23652fb", "2cbeb0d8-09c6-4333-9db8-caf25911cba8" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a12f4b74-beef-4e30-9766-496ea23652fb");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2cbeb0d8-09c6-4333-9db8-caf25911cba8");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "443a799e-f631-4e0b-9f11-ea0ba541fd91", null, "Admin", "ADMIN" },
                    { "ffa4864a-68c8-48e5-92aa-9c954938f709", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "9b62d17c-762b-4178-9257-78533483cd30", 0, "6722e1c6-46fd-40b2-98f6-9094cd3e2d6a", "admin@admin.com", false, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAIAAYagAAAAEM7O4o4P0uPWdb8zpROz1zaJLh3TI1LIjQGWVT7TOFCo170luC1G+r17r91ZHluxGw==", null, false, "f37ed9fc-3f33-458d-b460-f3948c97a781", false, "Admin" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "443a799e-f631-4e0b-9f11-ea0ba541fd91", "9b62d17c-762b-4178-9257-78533483cd30" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ffa4864a-68c8-48e5-92aa-9c954938f709");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "443a799e-f631-4e0b-9f11-ea0ba541fd91", "9b62d17c-762b-4178-9257-78533483cd30" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "443a799e-f631-4e0b-9f11-ea0ba541fd91");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9b62d17c-762b-4178-9257-78533483cd30");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "016506ac-19ac-4a9a-9ee8-00d1e33793c9", null, "User", "USER" },
                    { "a12f4b74-beef-4e30-9766-496ea23652fb", null, "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "2cbeb0d8-09c6-4333-9db8-caf25911cba8", 0, "793a7afa-b37f-4879-a17f-71cba685f223", "admin@admin.com", false, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAIAAYagAAAAEMo9yEvdZQsHLNaiUh0GO7eQrH4vycMzYxFYigXP+JM1bYRhjefGQ3KqMYlks2t4bw==", null, false, "d0f10591-af87-4602-b9d7-e045941d32e6", false, "Admin" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "a12f4b74-beef-4e30-9766-496ea23652fb", "2cbeb0d8-09c6-4333-9db8-caf25911cba8" });
        }
    }
}
