using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OkZim.Data.Migrations
{
    /// <inheritdoc />
    public partial class productPrice : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Price",
                table: "Product");

            migrationBuilder.AddColumn<double>(
                name: "ProductPrice",
                table: "Product",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProductPrice",
                table: "Product");

            migrationBuilder.AddColumn<int>(
                name: "Price",
                table: "Product",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
