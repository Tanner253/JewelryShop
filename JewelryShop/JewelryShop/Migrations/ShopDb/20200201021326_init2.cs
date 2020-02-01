using Microsoft.EntityFrameworkCore.Migrations;

namespace JewelryShop.Migrations.ShopDb
{
    public partial class init2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "InStock",
                table: "JewelryItem",
                nullable: true,
                oldClrType: typeof(bool));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "InStock",
                table: "JewelryItem",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
