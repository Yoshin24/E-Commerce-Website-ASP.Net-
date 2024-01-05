using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OkZim.Data.Migrations
{
    /// <inheritdoc />
    public partial class shop : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "ProductPrice",
                table: "Cart",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.CreateIndex(
                name: "IX_Cart_ProductId",
                table: "Cart",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cart_Product_ProductId",
                table: "Cart",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "ProductID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cart_Product_ProductId",
                table: "Cart");

            migrationBuilder.DropIndex(
                name: "IX_Cart_ProductId",
                table: "Cart");

            migrationBuilder.AlterColumn<double>(
                name: "ProductPrice",
                table: "Cart",
                type: "float",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");
        }
    }
}
