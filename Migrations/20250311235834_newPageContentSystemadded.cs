using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GoshehArtWebApp.Migrations
{
    /// <inheritdoc />
    public partial class newPageContentSystemadded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Pages",
                table: "Pages");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c3e3e75a-be8c-456c-a14b-15f9bcfe3f43");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "386df6cf-f1ed-4adf-8db4-9f74fd90b24e", "f86f187d-8507-497e-8da9-298de439145b" });

            migrationBuilder.DeleteData(
                table: "Pages",
                keyColumn: "Title",
                keyValue: "About");

            migrationBuilder.DeleteData(
                table: "Pages",
                keyColumn: "Title",
                keyValue: "Contact");

            migrationBuilder.DeleteData(
                table: "Pages",
                keyColumn: "Title",
                keyValue: "Home");

            migrationBuilder.DeleteData(
                table: "Pages",
                keyColumn: "Title",
                keyValue: "Production");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "386df6cf-f1ed-4adf-8db4-9f74fd90b24e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f86f187d-8507-497e-8da9-298de439145b");

            migrationBuilder.RenameColumn(
                name: "Content",
                table: "Pages",
                newName: "Header");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Pages",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Pages",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Pages",
                table: "Pages",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Contents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Body = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PageId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Contents_Pages_PageId",
                        column: x => x.PageId,
                        principalTable: "Pages",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "459b6cc8-e1d5-4123-a63c-1322576cd87b", null, "Admin", "ADMIN" },
                    { "4a70932c-510b-4c5f-8a17-88e3380473ae", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "f33d9252-cc61-4390-84d8-92cc6b873f50", 0, "a3c44743-a125-4830-b1d8-08d150ee5520", "admin@admin.com", false, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAIAAYagAAAAEMzTqTWGRw+L19zrQYvp42gFWBbeXVjbMGyJ2v+cXFlvl3PD3DYDHvGfzfxiUs6BoA==", null, false, "79216c9e-1557-4c11-815d-f02eae8f4c9b", false, "Admin" });

            migrationBuilder.InsertData(
                table: "Pages",
                columns: new[] { "Id", "Header", "Title" },
                values: new object[,]
                {
                    { 1, "", "Home" },
                    { 2, "", "Production" },
                    { 3, "", "About" },
                    { 4, "", "Contact" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "459b6cc8-e1d5-4123-a63c-1322576cd87b", "f33d9252-cc61-4390-84d8-92cc6b873f50" });

            migrationBuilder.InsertData(
                table: "Contents",
                columns: new[] { "Id", "Body", "PageId", "Title" },
                values: new object[] { 1, "blog body", 1, "blog title" });

            migrationBuilder.CreateIndex(
                name: "IX_Contents_PageId",
                table: "Contents",
                column: "PageId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contents");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Pages",
                table: "Pages");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4a70932c-510b-4c5f-8a17-88e3380473ae");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "459b6cc8-e1d5-4123-a63c-1322576cd87b", "f33d9252-cc61-4390-84d8-92cc6b873f50" });

            migrationBuilder.DeleteData(
                table: "Pages",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Pages",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Pages",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Pages",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "459b6cc8-e1d5-4123-a63c-1322576cd87b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f33d9252-cc61-4390-84d8-92cc6b873f50");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Pages");

            migrationBuilder.RenameColumn(
                name: "Header",
                table: "Pages",
                newName: "Content");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Pages",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Pages",
                table: "Pages",
                column: "Title");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "386df6cf-f1ed-4adf-8db4-9f74fd90b24e", null, "Admin", "ADMIN" },
                    { "c3e3e75a-be8c-456c-a14b-15f9bcfe3f43", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "f86f187d-8507-497e-8da9-298de439145b", 0, "20c64ec0-517d-47b1-9172-672903ef9304", "admin@admin.com", false, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAIAAYagAAAAEEyr75eZL9ODETsZaXRMipN5cTZ+5JS2etRvQul/9vicPomhuET98X1QkjQfH7ilUQ==", null, false, "8d8eb9c2-b9b3-4c68-b4ac-3da473cdae1c", false, "Admin" });

            migrationBuilder.InsertData(
                table: "Pages",
                columns: new[] { "Title", "Content" },
                values: new object[,]
                {
                    { "About", "" },
                    { "Contact", "" },
                    { "Home", "" },
                    { "Production", "" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "386df6cf-f1ed-4adf-8db4-9f74fd90b24e", "f86f187d-8507-497e-8da9-298de439145b" });
        }
    }
}
