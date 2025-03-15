using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GoshehArtWebApp.Migrations
{
    /// <inheritdoc />
    public partial class movingToContent : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "95dc0f15-895f-4de5-93ac-39af475901a9");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9d736b4a-df6b-445b-a8bf-bf3285a680a3", "51667b73-b567-4758-ac65-37acc80e6a92" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9d736b4a-df6b-445b-a8bf-bf3285a680a3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "51667b73-b567-4758-ac65-37acc80e6a92");

            migrationBuilder.AlterColumn<string>(
                name: "Body",
                table: "Contents",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "57d93dd1-bc59-42f1-98d5-18215f1dec59", null, "Admin", "ADMIN" },
                    { "9d5a3490-d385-4830-9618-e1aeb6ffdd4b", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "44babcd0-39ed-4323-8e8d-715b7503c813", 0, "9dd4a984-2dc7-4ec8-a728-68215f29e268", "admin@admin.com", false, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAIAAYagAAAAEGxGIuNSgdGXIwAQ/NGJhHBbCEDURn6LNDV8h12bTXGgVR1B2Y9q2INndSlIHB7Jdg==", null, false, "cd043688-b9b3-4c90-9153-3e7c30e7e32f", false, "Admin" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "57d93dd1-bc59-42f1-98d5-18215f1dec59", "44babcd0-39ed-4323-8e8d-715b7503c813" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9d5a3490-d385-4830-9618-e1aeb6ffdd4b");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "57d93dd1-bc59-42f1-98d5-18215f1dec59", "44babcd0-39ed-4323-8e8d-715b7503c813" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "57d93dd1-bc59-42f1-98d5-18215f1dec59");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44babcd0-39ed-4323-8e8d-715b7503c813");

            migrationBuilder.AlterColumn<string>(
                name: "Body",
                table: "Contents",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "95dc0f15-895f-4de5-93ac-39af475901a9", null, "User", "USER" },
                    { "9d736b4a-df6b-445b-a8bf-bf3285a680a3", null, "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "51667b73-b567-4758-ac65-37acc80e6a92", 0, "6afb1efc-3264-4433-9d51-ff6b78b55a73", "admin@admin.com", false, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAIAAYagAAAAELYHZMeP7tmdXQD7jUoWjrBKDvQmu73oOJxt2+rBPBFVa1b2y8QIbNAvePMFP4og9g==", null, false, "03fbc8eb-950e-4b3e-9b14-146a4d5037dd", false, "Admin" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "9d736b4a-df6b-445b-a8bf-bf3285a680a3", "51667b73-b567-4758-ac65-37acc80e6a92" });
        }
    }
}
