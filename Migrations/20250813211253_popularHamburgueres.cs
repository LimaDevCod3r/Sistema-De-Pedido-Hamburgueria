using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SistemaDePedidoHamburgueria.Migrations
{
    /// <inheritdoc />
    public partial class popularHamburgueres : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Hamburgueres(Nome, Descricao, Preco, UrlImagem, CategoriaId) VALUES('X-Bacon', 'Pão, hambúrguer, queijo, bacon crocante, alface e tomate', 25.90, 'https://exemplo.com/x-bacon.jpg', 1)");
            migrationBuilder.Sql("INSERT INTO Hamburgueres(Nome, Descricao, Preco, UrlImagem, CategoriaId) VALUES('X-Salada', 'Pão, hambúrguer, queijo, alface, tomate, cebola e maionese', 22.50, 'https://exemplo.com/x-salada.jpg', 1)");
            migrationBuilder.Sql("INSERT INTO Hamburgueres(Nome, Descricao, Preco, UrlImagem, CategoriaId) VALUES('X-Tudo', 'Pão, 2 hambúrgueres, queijo, bacon, ovo, alface, tomate, cebola e maionese', 32.90, 'https://exemplo.com/x-tudo.jpg', 1)");
            migrationBuilder.Sql("INSERT INTO Hamburgueres(Nome, Descricao, Preco, UrlImagem, CategoriaId) VALUES('Gourmet Trufado', 'Pão brioche, hambúrguer artesanal, queijo trufado, cogumelos e molho especial', 45.00, 'https://exemplo.com/gourmet-trufado.jpg', 2)");
            migrationBuilder.Sql("INSERT INTO Hamburgueres(Nome, Descricao, Preco, UrlImagem, CategoriaId) VALUES('Veggie Burger', 'Hambúrguer de grão-de-bico, queijo vegano, alface, tomate e molho especial', 28.90, 'https://exemplo.com/veggie.jpg', 3)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Hamburgueres");
        }
    }
}
