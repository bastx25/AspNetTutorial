using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace api.Migrations
{
    /// <inheritdoc />
    public partial class SeedRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "4ddf6c55-5336-4e8e-a094-df1cef5f1cf9", "873599f2-55f8-45e7-a716-ffe09872b5bf", "Admin", "ADMIN" },
                    { "9edb8271-b484-4639-bb1a-ca72cc55b195", "7468a642-6a07-488a-98fb-70657c92b0a2", "User", "USER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4ddf6c55-5336-4e8e-a094-df1cef5f1cf9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9edb8271-b484-4639-bb1a-ca72cc55b195");
        }
    }
}
