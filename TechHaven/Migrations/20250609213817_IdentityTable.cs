using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TechHaven.Migrations
{
    /// <inheritdoc />
    public partial class IdentityTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ProductName",
                table: "OrderDetail",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<int>(
                name: "TottalPrice",
                table: "Order",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "ProductName",
                table: "Order",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Customer",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Phone",
                table: "Customer",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProductName",
                table: "OrderDetail");

            migrationBuilder.DropColumn(
                name: "ProductName",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "Address",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "Phone",
                table: "Customer");

            migrationBuilder.AlterColumn<string>(
                name: "TottalPrice",
                table: "Order",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }
    }
}
