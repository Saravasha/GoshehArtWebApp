using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GoshehArtWebApp.Migrations
{
    /// <inheritdoc />
    public partial class zigiwwwww : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                keyValue: "92bc38b2-4fef-421c-a81f-a02f1168ba9d");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "00c71183-4886-4600-9617-acd9a49f9239", "52838962-89d2-43e4-b0ed-654c9b1a65f1" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "00c71183-4886-4600-9617-acd9a49f9239");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "52838962-89d2-43e4-b0ed-654c9b1a65f1");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2a8e2689-a81d-4665-b79b-2607c3abe221", null, "Admin", "ADMIN" },
                    { "86f02106-7e15-42e8-ac89-5137576eee93", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "a23fc2e3-465e-4831-9619-6e7afeede665", 0, "ba6e1a8a-d5ef-4c3f-99ce-e4fd50f52b05", "admin@admin.com", false, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAIAAYagAAAAENbtVYAHWfevKunPEVcXsdklPq22mwMf0JMZxJwFFhhPtbuPh5mp56oT1SgtIoEbJg==", null, false, "8f7d0e5a-7b7f-4324-9ef2-47ba9fc176d5", false, "Admin" });

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Body", "Title" },
                values: new object[] { "", "Welcome" });

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Body", "PageId", "Title" },
                values: new object[] { "", 2, "This is what I'm working on" });

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Body", "PageId", "Title" },
                values: new object[] { "", 3, "Biography" });

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Body", "PageId", "Title" },
                values: new object[] { "", 4, "Social Media" });

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Body", "PageId", "Title" },
                values: new object[] { "", 5, "Cookie Policy" });

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Body", "PageId", "Title" },
                values: new object[] { "", 5, "Privacy Policy" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 1,
                column: "ContentId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 2,
                column: "ContentId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 3,
                column: "ContentId",
                value: 3);

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "2a8e2689-a81d-4665-b79b-2607c3abe221", "a23fc2e3-465e-4831-9619-6e7afeede665" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "86f02106-7e15-42e8-ac89-5137576eee93");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2a8e2689-a81d-4665-b79b-2607c3abe221", "a23fc2e3-465e-4831-9619-6e7afeede665" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2a8e2689-a81d-4665-b79b-2607c3abe221");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a23fc2e3-465e-4831-9619-6e7afeede665");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "00c71183-4886-4600-9617-acd9a49f9239", null, "Admin", "ADMIN" },
                    { "92bc38b2-4fef-421c-a81f-a02f1168ba9d", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "52838962-89d2-43e4-b0ed-654c9b1a65f1", 0, "7d1f7ee5-7df9-4eec-8418-1a4705ad50fb", "admin@admin.com", false, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAIAAYagAAAAEHLStDC4axjS6q+dfvdZqZt0Vgf0aG+awnqxEHtcIrE7QzAD+6BeF+J/wDXMLJ1Qdw==", null, false, "04dd9da0-bae3-4443-a24c-5a6637b271de", false, "Admin" });

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Body", "Title" },
                values: new object[] { "blog body", "Stuff i made up" });

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Body", "PageId", "Title" },
                values: new object[] { "blog body", 5, "stuff i made up 2" });

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Body", "PageId", "Title" },
                values: new object[] { "blog body", 2, "atrocities" });

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Body", "PageId", "Title" },
                values: new object[] { "blog body", 3, "blog title" });

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Body", "PageId", "Title" },
                values: new object[] { "blog body", 4, "blog title" });

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Body", "PageId", "Title" },
                values: new object[] { "blog body", 1, "blog title" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 1,
                column: "ContentId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 2,
                column: "ContentId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 3,
                column: "ContentId",
                value: 4);

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "00c71183-4886-4600-9617-acd9a49f9239", "52838962-89d2-43e4-b0ed-654c9b1a65f1" });

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
    }
}
