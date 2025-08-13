namespace SistemaDePedidoHamburgueria.Models
{
    /// <summary>
    /// Representa um hambúrguer no sistema de pedidos
    /// </summary>
    public class Hamburger
    {
        /// <summary>
        /// Identificador único do hambúrguer
        /// </summary>
        public int HamburgerId { get; set; }

        /// <summary>
        /// Nome do hambúrguer (ex: X-Bacon, X-Salada, X-Tudo)
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Descrição detalhada dos ingredientes e preparo
        /// Ex: Pão, 2 carnes, bacon, queijo, alface, tomate
        /// </summary>
        public string Description { get; set; } = string.Empty;

        /// <summary>
        /// Preço do hambúrguer em reais (R$)
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// URL da imagem do hambúrguer para exibição no cardápio
        /// </summary>
        public string ImageUrl { get; set; } = string.Empty;

        /// <summary>
        /// Data e hora de criação do registro
        /// </summary>
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        /// <summary>
        /// Data e hora da última atualização do registro (null se nunca foi atualizado)
        /// </summary>
        public DateTime? UpdatedAt { get; set; }
    }
}