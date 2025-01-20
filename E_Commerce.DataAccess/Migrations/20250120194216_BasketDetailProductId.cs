using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace E_Commerce.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class BasketDetailProductId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "productId",
                table: "BasketDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "BasketDetails",
                keyColumn: "basketDetailId",
                keyValue: 2000,
                column: "productId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "BasketDetails",
                keyColumn: "basketDetailId",
                keyValue: 2001,
                column: "productId",
                value: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "productId",
                table: "BasketDetails");
        }
    }
}
