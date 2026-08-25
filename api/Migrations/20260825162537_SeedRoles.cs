using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace api.Migrations
{
    /// <inheritdoc />
    public partial class SeedRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "4ddf6c55-5336-4e8e-a094-df1cef5f1cf9", "8dcd0c54-2514-4eda-9fe3-c2586a824be4", "Admin", "ADMIN" },
                    { "9edb8271-b484-4639-bb1a-ca72cc55b195", "de55012f-6090-4d7f-865a-2a8c68ae1d07", "User", "USER" }
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
