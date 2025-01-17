using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace E_Commerce.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class SeedData3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Baskets",
                keyColumn: "BasketID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Baskets",
                keyColumn: "BasketID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Baskets",
                keyColumn: "BasketID",
                keyValue: 3);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Baskets",
                columns: new[] { "BasketID", "CouponCode", "TaxID", "TotalPrice", "TotalQuantity", "UserID" },
                values: new object[,]
                {
                    { 1, "123", 1, 100, 1, 1 },
                    { 2, "123", 1, 100, 1, 1 },
                    { 3, "123", 1, 100, 1, 1 }
                });
        }
    }
}
