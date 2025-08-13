namespace SistemaDePedidoHamburgueria.Models
{
    /// <summary>
    /// Representa uma categoria de produtos no sistema
    /// </summary>
    public class Category
    {
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
    }
}