using Microsoft.EntityFrameworkCore;
using SistemaDePedidoHamburgueria.Models;

namespace SistemaDePedidoHamburgueria.Context
{
    /// <summary>
    /// Contexto do banco de dados para a API da Hamburgueria
    /// Responsável por gerenciar as entidades e operações do banco de dados
    /// </summary>
    public class HamburgueriaApiDBContext : DbContext
    {
        /// <summary>
        /// Construtor que recebe as opções de configuração do DbContext
        /// </summary>
        /// <param name="options">Opções de configuração do Entity Framework</param>
        public HamburgueriaApiDBContext(DbContextOptions<HamburgueriaApiDBContext> options) : base(options)
        {

        }

        /// <summary>
        /// DbSet para gerenciar as categorias de hambúrgueres
        /// Permite operações CRUD na tabela Categories
        /// </summary>
        public DbSet<Category> Categories { get; set; }

        /// <summary>
        /// DbSet para gerenciar os hambúrgueres
        /// Permite operações CRUD na tabela Hamburgers
        /// </summary>
        public DbSet<Hamburger> Hamburgers { get; set; }
    }
}