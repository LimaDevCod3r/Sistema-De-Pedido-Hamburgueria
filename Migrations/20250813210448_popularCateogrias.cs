using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SistemaDePedidoHamburgueria.Migrations
{
    /// <inheritdoc />
    public partial class popularCateogrias : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Categorias (Nome, UrlImagem) VALUES('Hambúrgueres Tradicionais', 'https://exemplo.com/tradicionais.jpg')");
            migrationBuilder.Sql("INSERT INTO Categorias (Nome, UrlImagem) VALUES('Hambúrgueres Gourmet', 'https://exemplo.com/gourmet.jpg')");
            migrationBuilder.Sql("INSERT INTO Categorias (Nome, UrlImagem) VALUES('Hambúrgueres Vegetarianos', 'https://exemplo.com/vegetarianos.jpg')");
            migrationBuilder.Sql("INSERT INTO Categorias (Nome, UrlImagem) VALUES('Hambúrgueres Vegetarianos', 'https://exemplo.com/vegetarianos.jpg')");
            migrationBuilder.Sql("INSERT INTO Categorias (Nome, UrlImagem) VALUES('Bebidas', 'https://exemplo.com/bebidas.jpg')");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Categorias");
        }
    }
}
