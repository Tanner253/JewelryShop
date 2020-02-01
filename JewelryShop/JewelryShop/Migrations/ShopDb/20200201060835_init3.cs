using Microsoft.EntityFrameworkCore.Migrations;

namespace JewelryShop.Migrations.ShopDb
{
    public partial class init3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "JewelryItem",
                columns: new[] { "ID", "Description", "InStock", "Name", "Picture1", "Picture2", "Picture3", "Price" },
                values: new object[] { 1, "Expertly hand crafted earrings perfect for a night out", "Yes - Limited", "Blue Earring Set", "~/wwwroot/Assets/Set1.1.jpg", "~/wwwroot/Assets/Set1.2.jpg", "~/wwwroot/Assets/Set1.3.jpg", null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "JewelryItem",
                keyColumn: "ID",
                keyValue: 1);
        }
    }
}
