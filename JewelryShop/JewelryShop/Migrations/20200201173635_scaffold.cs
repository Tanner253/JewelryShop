using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace JewelryShop.Migrations
{
    public partial class scaffold : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "JewelryItem",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false),
                    InStock = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: false),
                    Picture1 = table.Column<string>(nullable: false),
                    Picture2 = table.Column<string>(nullable: true),
                    Picture3 = table.Column<string>(nullable: true),
                    Price = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JewelryItem", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "JewelryItem",
                columns: new[] { "ID", "Description", "InStock", "Name", "Picture1", "Picture2", "Picture3", "Price" },
                values: new object[] { 1, "Expertly hand crafted earrings perfect for a night out", "Yes - Limited", "Blue Earring Set", "~/Assets/Set1.1.jpg", "~/Assets/Set1.2.jpg", "~/Assets/Set1.3.jpg", "50$" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "JewelryItem");
        }
    }
}
