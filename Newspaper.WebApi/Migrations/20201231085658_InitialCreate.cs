using Microsoft.EntityFrameworkCore.Migrations;

namespace Newspaper.WebApi.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Haberler",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Baslik = table.Column<string>(maxLength: 60, nullable: true),
                    Metin = table.Column<string>(nullable: true),
                    Yazar = table.Column<string>(maxLength: 28, nullable: true),
                    KategoriId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Haberler", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Kitaplar",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    isim = table.Column<string>(nullable: true),
                    Yazar = table.Column<string>(nullable: true),
                    Yayinevi = table.Column<string>(nullable: true),
                    Fiyat = table.Column<int>(nullable: false),
                    Stok = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kitaplar", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Haberler");

            migrationBuilder.DropTable(
                name: "Kitaplar");
        }
    }
}
