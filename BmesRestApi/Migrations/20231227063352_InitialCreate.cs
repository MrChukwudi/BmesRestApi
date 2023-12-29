using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BmesRestApi.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Brands_BrandId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "BrabdId",
                table: "Products");

            migrationBuilder.RenameColumn(
                name: "Quantity",
                table: "Products",
                newName: "QuantityInStock");

            migrationBuilder.RenameColumn(
                name: "ModiefiedDate",
                table: "Products",
                newName: "ModifiedDate");

            migrationBuilder.RenameColumn(
                name: "ModiefiedDate",
                table: "Categories",
                newName: "ModifiedDate");

            migrationBuilder.RenameColumn(
                name: "ModiefiedDate",
                table: "Brands",
                newName: "ModifiedDate");

            migrationBuilder.RenameColumn(
                name: "BrabdStatus",
                table: "Brands",
                newName: "BrandStatus");

            migrationBuilder.AlterColumn<long>(
                name: "BrandId",
                table: "Products",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Brands_BrandId",
                table: "Products",
                column: "BrandId",
                principalTable: "Brands",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Brands_BrandId",
                table: "Products");

            migrationBuilder.RenameColumn(
                name: "QuantityInStock",
                table: "Products",
                newName: "Quantity");

            migrationBuilder.RenameColumn(
                name: "ModifiedDate",
                table: "Products",
                newName: "ModiefiedDate");

            migrationBuilder.RenameColumn(
                name: "ModifiedDate",
                table: "Categories",
                newName: "ModiefiedDate");

            migrationBuilder.RenameColumn(
                name: "ModifiedDate",
                table: "Brands",
                newName: "ModiefiedDate");

            migrationBuilder.RenameColumn(
                name: "BrandStatus",
                table: "Brands",
                newName: "BrabdStatus");

            migrationBuilder.AlterColumn<long>(
                name: "BrandId",
                table: "Products",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "INTEGER");

            migrationBuilder.AddColumn<long>(
                name: "BrabdId",
                table: "Products",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Brands_BrandId",
                table: "Products",
                column: "BrandId",
                principalTable: "Brands",
                principalColumn: "Id");
        }
    }
}
