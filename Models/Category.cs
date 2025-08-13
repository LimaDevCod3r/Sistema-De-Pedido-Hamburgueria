using System.Collections.ObjectModel;


namespace SistemaDePedidoHamburgueria.Models
{
    /// <summary>
    /// Representa uma categoria de produtos no sistema
    /// Uma categoria pode conter múltiplos hambúrgueres (relacionamento 1:N)
    /// </summary>
    public class Category
    {

        public Category()
        {
            Hamburgers = new Collection<Hamburger>();
        }
        /// <summary>
        /// Identificador único da categoria
        /// </summary>
        public int CategoryId { get; set; }

        /// <summary>
        /// Nome da categoria (ex: Hambúrgueres, Bebidas, Acompanhamentos)
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// URL da imagem representativa da categoria
        /// </summary>
        public string ImageUrl { get; set; } = string.Empty;

        /// <summary>
        /// Data e hora de criação da categoria
        /// </summary>
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        /// <summary>
        /// Data e hora da última atualização da categoria (null se nunca foi atualizada)
        /// </summary>
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Coleção de hambúrgueres pertencentes a esta categoria
        /// Relacionamento 1:N: Uma categoria pode ter múltiplos hambúrgueres
        /// </summary>
        public ICollection<Hamburger>? Hamburgers { get; set; }

    }
}