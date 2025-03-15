using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GoshehArtWebApp.Migrations
{
    /// <inheritdoc />
    public partial class zigi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f17e7278-95fe-45a1-a4e4-0c947ce2ef09");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "08d68e25-84eb-4005-b584-e3d903491854", "cedea83c-28e1-4e93-a0ef-9236105bce4e" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "08d68e25-84eb-4005-b584-e3d903491854");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cedea83c-28e1-4e93-a0ef-9236105bce4e");

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

            migrationBuilder.CreateIndex(
                name: "IX_Pages_ContentId",
                table: "Pages",
                column: "ContentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pages_Contents_ContentId",
                table: "Pages",
                column: "ContentId",
                principalTable: "Contents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pages_Contents_ContentId",
                table: "Pages");

            migrationBuilder.DropIndex(
                name: "IX_Pages_ContentId",
                table: "Pages");

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
                    { "08d68e25-84eb-4005-b584-e3d903491854", null, "Admin", "ADMIN" },
                    { "f17e7278-95fe-45a1-a4e4-0c947ce2ef09", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "cedea83c-28e1-4e93-a0ef-9236105bce4e", 0, "ad1e3ba1-0342-4b54-bfc0-57c286bd604c", "admin@admin.com", false, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAIAAYagAAAAEIQUouH0pK9rVqqM3kdrfHiIF3sJ31Miz3OarHvb9dL2GcAFHSQvTqQFYOoMoNCLSA==", null, false, "d0711217-8c7e-4101-b1e1-76651866843e", false, "Admin" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "08d68e25-84eb-4005-b584-e3d903491854", "cedea83c-28e1-4e93-a0ef-9236105bce4e" });
        }
    }
}
