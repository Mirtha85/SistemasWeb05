using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SistemasWeb01.Migrations
{
    public partial class CategoriaProducto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categoriasdb",
                columns: table => new
                {
                    CategoriaId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    NombreCategoria = table.Column<string>(type: "TEXT", nullable: false),
                    DescripcionCategoria = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categoriasdb", x => x.CategoriaId);
                });

            migrationBuilder.CreateTable(
                name: "Productosdb",
                columns: table => new
                {
                    ProductoId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    NombreProducto = table.Column<string>(type: "TEXT", nullable: true),
                    DescripcionProducto = table.Column<string>(type: "TEXT", nullable: true),
                    PrecioProducto = table.Column<decimal>(type: "TEXT", nullable: false),
                    ImagenProducto = table.Column<string>(type: "TEXT", nullable: true),
                    Talla = table.Column<int>(type: "INTEGER", nullable: false),
                    CategoriaId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Productosdb", x => x.ProductoId);
                    table.ForeignKey(
                        name: "FK_Productosdb_Categoriasdb_CategoriaId",
                        column: x => x.CategoriaId,
                        principalTable: "Categoriasdb",
                        principalColumn: "CategoriaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Productosdb_CategoriaId",
                table: "Productosdb",
                column: "CategoriaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Productosdb");

            migrationBuilder.DropTable(
                name: "Categoriasdb");
        }
    }
}
