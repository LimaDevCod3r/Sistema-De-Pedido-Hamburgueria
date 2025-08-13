using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaDePedidoHamburgueria.Models
{
    /// <summary>
    /// Representa um hambúrguer no sistema de pedidos
    /// Cada hambúrguer pertence a uma categoria específica (relacionamento N:1)
    /// </summary>
    [Table("Hamburgueres")]
    public class Hamburger
    {
        /// <summary>
        /// Identificador único do hambúrguer
        /// Chave primária auto-incrementada
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int HamburgerId { get; set; }

        /// <summary>
        /// Nome do hambúrguer (ex: X-Bacon, X-Salada, X-Tudo)
        /// Campo obrigatório com validação de tamanho
        /// </summary>
        [Required(ErrorMessage = "O Campo \"Nome\" é obrigatório")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "O nome deve ter entre 3 e 100 caracteres")]
        [Column("Nome")]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Descrição detalhada dos ingredientes e preparo
        /// Ex: Pão, 2 carnes, bacon, queijo, alface, tomate
        /// Campo obrigatório com validação de tamanho
        /// </summary>
        [Required(ErrorMessage = "O Campo \"Descrição\" é obrigatório")]
        [StringLength(500, MinimumLength = 10, ErrorMessage = "A descrição deve ter entre 10 e 500 caracteres")]
        [Column("Descricao")]
        public string Description { get; set; } = string.Empty;

        /// <summary>
        /// Preço do hambúrguer em reais (R$)
        /// Campo obrigatório com validação de valor mínimo
        /// </summary>
        [Required(ErrorMessage = "O Campo \"Preço\" é obrigatório")]
        [Range(0.01, 999.99, ErrorMessage = "O preço deve estar entre R$ 0,01 e R$ 999,99")]
        [Column("Preco")]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }

        /// <summary>
        /// URL da imagem do hambúrguer para exibição no cardápio
        /// Campo opcional com validação de URL
        /// </summary>
        [Url(ErrorMessage = "A URL da imagem deve ser válida")]
        [StringLength(500, ErrorMessage = "A URL da imagem não pode exceder 500 caracteres")]
        [Column("UrlImagem")]
        public string ImageUrl { get; set; } = string.Empty;

        /// <summary>
        /// Data e hora de criação do registro
        /// Preenchida automaticamente na criação
        /// </summary>
        [Required]
        [Column("DataCriacao")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        /// <summary>
        /// Data e hora da última atualização do registro (null se nunca foi atualizado)
        /// Atualizada automaticamente quando o registro é modificado
        /// </summary>
        [Column("DataAtualizacao")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Chave estrangeira que referencia a categoria à qual o hambúrguer pertence
        /// Relacionamento N:1: Múltiplos hambúrgueres podem pertencer à mesma categoria
        /// </summary>
        [Required(ErrorMessage = "O Campo \"Categoria\" é obrigatório")]
        [Column("CategoriaId")]
        public int CategoryId { get; set; }

        /// <summary>
        /// Propriedade de navegação para a categoria do hambúrguer
        /// Permite acessar os dados da categoria relacionada
        /// </summary>
        [ForeignKey("CategoryId")]
        public Category? Category { get; set; }
    }
}