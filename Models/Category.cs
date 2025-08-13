using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace SistemaDePedidoHamburgueria.Models
{
    /// <summary>
    /// Representa uma categoria de produtos no sistema
    /// Uma categoria pode conter múltiplos hambúrgueres (relacionamento 1:N)
    /// </summary>
    [Table("Categorias")]
    public class Category
    {

        public Category()
        {
            Hamburgers = new Collection<Hamburger>();
        }

        /// <summary>
        /// Identificador único da categoria
        /// Chave primária auto-incrementada
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CategoryId { get; set; }

        /// <summary>
        /// Nome da categoria (ex: Hambúrgueres, Bebidas, Acompanhamentos)
        /// Campo obrigatório com validação de tamanho
        /// </summary>
        [Required(ErrorMessage = "O Campo \"Nome\" é obrigatório")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "O nome deve ter entre 2 e 50 caracteres")]
        [Column("Nome")]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// URL da imagem representativa da categoria
        /// Campo opcional com validação de URL
        /// </summary>
        [Url(ErrorMessage = "A URL da imagem deve ser válida")]
        [StringLength(500, ErrorMessage = "A URL da imagem não pode exceder 500 caracteres")]
        [Column("UrlImagem")]
        public string ImageUrl { get; set; } = string.Empty;

        /// <summary>
        /// Data e hora de criação da categoria
        /// Preenchida automaticamente na criação
        /// </summary>
        [Required]
        [Column("DataCriacao")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        /// <summary>
        /// Data e hora da última atualização da categoria (null se nunca foi atualizada)
        /// Atualizada automaticamente quando o registro é modificado
        /// </summary>
        [Column("DataAtualizacao")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Coleção de hambúrgueres pertencentes a esta categoria
        /// Relacionamento 1:N: Uma categoria pode ter múltiplos hambúrgueres
        /// </summary>
        public ICollection<Hamburger>? Hamburgers { get; set; }

    }
}