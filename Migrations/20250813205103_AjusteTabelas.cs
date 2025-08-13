using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SistemaDePedidoHamburgueria.Migrations
{
    /// <inheritdoc />
    public partial class AjusteTabelas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Hamburgers_Categories_CategoryId",
                table: "Hamburgers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Hamburgers",
                table: "Hamburgers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Categories",
                table: "Categories");

            migrationBuilder.RenameTable(
                name: "Hamburgers",
                newName: "Hamburgueres");

            migrationBuilder.RenameTable(
                name: "Categories",
                newName: "Categorias");

            migrationBuilder.RenameColumn(
                name: "UpdatedAt",
                table: "Hamburgueres",
                newName: "DataAtualizacao");

            migrationBuilder.RenameColumn(
                name: "Price",
                table: "Hamburgueres",
                newName: "Preco");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Hamburgueres",
                newName: "Nome");

            migrationBuilder.RenameColumn(
                name: "ImageUrl",
                table: "Hamburgueres",
                newName: "UrlImagem");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Hamburgueres",
                newName: "Descricao");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "Hamburgueres",
                newName: "DataCriacao");

            migrationBuilder.RenameColumn(
                name: "CategoryId",
                table: "Hamburgueres",
                newName: "CategoriaId");

            migrationBuilder.RenameIndex(
                name: "IX_Hamburgers_CategoryId",
                table: "Hamburgueres",
                newName: "IX_Hamburgueres_CategoriaId");

            migrationBuilder.RenameColumn(
                name: "UpdatedAt",
                table: "Categorias",
                newName: "DataAtualizacao");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Categorias",
                newName: "Nome");

            migrationBuilder.RenameColumn(
                name: "ImageUrl",
                table: "Categorias",
                newName: "UrlImagem");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "Categorias",
                newName: "DataCriacao");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataAtualizacao",
                table: "Hamburgueres",
                type: "datetime(6)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldNullable: true)
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn);

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Hamburgueres",
                type: "varchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "UrlImagem",
                table: "Hamburgueres",
                type: "varchar(500)",
                maxLength: 500,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Descricao",
                table: "Hamburgueres",
                type: "varchar(500)",
                maxLength: 500,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataCriacao",
                table: "Hamburgueres",
                type: "datetime(6)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)")
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataAtualizacao",
                table: "Categorias",
                type: "datetime(6)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldNullable: true)
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn);

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Categorias",
                type: "varchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "UrlImagem",
                table: "Categorias",
                type: "varchar(500)",
                maxLength: 500,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataCriacao",
                table: "Categorias",
                type: "datetime(6)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)")
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Hamburgueres",
                table: "Hamburgueres",
                column: "HamburgerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categorias",
                table: "Categorias",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Hamburgueres_Categorias_CategoriaId",
                table: "Hamburgueres",
                column: "CategoriaId",
                principalTable: "Categorias",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Hamburgueres_Categorias_CategoriaId",
                table: "Hamburgueres");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Hamburgueres",
                table: "Hamburgueres");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Categorias",
                table: "Categorias");

            migrationBuilder.RenameTable(
                name: "Hamburgueres",
                newName: "Hamburgers");

            migrationBuilder.RenameTable(
                name: "Categorias",
                newName: "Categories");

            migrationBuilder.RenameColumn(
                name: "UrlImagem",
                table: "Hamburgers",
                newName: "ImageUrl");

            migrationBuilder.RenameColumn(
                name: "Preco",
                table: "Hamburgers",
                newName: "Price");

            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "Hamburgers",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "Descricao",
                table: "Hamburgers",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "DataCriacao",
                table: "Hamburgers",
                newName: "CreatedAt");

            migrationBuilder.RenameColumn(
                name: "DataAtualizacao",
                table: "Hamburgers",
                newName: "UpdatedAt");

            migrationBuilder.RenameColumn(
                name: "CategoriaId",
                table: "Hamburgers",
                newName: "CategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_Hamburgueres_CategoriaId",
                table: "Hamburgers",
                newName: "IX_Hamburgers_CategoryId");

            migrationBuilder.RenameColumn(
                name: "UrlImagem",
                table: "Categories",
                newName: "ImageUrl");

            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "Categories",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "DataCriacao",
                table: "Categories",
                newName: "CreatedAt");

            migrationBuilder.RenameColumn(
                name: "DataAtualizacao",
                table: "Categories",
                newName: "UpdatedAt");

            migrationBuilder.AlterColumn<string>(
                name: "ImageUrl",
                table: "Hamburgers",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(500)",
                oldMaxLength: 500)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Hamburgers",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldMaxLength: 100)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Hamburgers",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(500)",
                oldMaxLength: 500)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Hamburgers",
                type: "datetime(6)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)")
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Hamburgers",
                type: "datetime(6)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldNullable: true)
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn);

            migrationBuilder.AlterColumn<string>(
                name: "ImageUrl",
                table: "Categories",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(500)",
                oldMaxLength: 500)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Categories",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldMaxLength: 50)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Categories",
                type: "datetime(6)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)")
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Categories",
                type: "datetime(6)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldNullable: true)
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Hamburgers",
                table: "Hamburgers",
                column: "HamburgerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categories",
                table: "Categories",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Hamburgers_Categories_CategoryId",
                table: "Hamburgers",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
