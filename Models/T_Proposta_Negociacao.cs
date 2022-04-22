using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebTrader.Models.Tipo;

namespace WebTrader.Models
{
    [Table("T_Proposta_Negociacao")]
    public class T_Proposta_Negociacao
    {
        [Key]
        public int IdPropostaNegociacao { get; set; }

        [Required(ErrorMessage = "A Descrição do produto deve ser Informado")]
        [Display(Name = "Descrição do Produto")]
        [MaxLength(50, ErrorMessage = "Descrição deve ter no máximo {1} caracteres")]
        public string Produto { get; set; }

        [Display(Name = "Descrição da Marca")]
        [MaxLength(25, ErrorMessage = "Descrição deve ter no máximo {1} caracteres")]
        public string Marca { get; set; }

        [Required(ErrorMessage = "Permite Usado deve ser Preenchido")]
        [Display(Name = "Permite que o produto seja usado")]
        [MaxLength(3, ErrorMessage = "Descrição deve ter no máximo {1} caracteres")]
        public string PermiteUsado { get; set; }

        [Required(ErrorMessage = "A Marca deve ser Informado")]
        [Display(Name = "Descrição da Marca")]
        [MaxLength(25, ErrorMessage = "Descrição deve ter no máximo {1} caracteres")]
        [Range(1, 99999.99, ErrorMessage = "O preço deve estar entre 1 e 999,99")]
        public decimal Preco { get; set; }

        [Required(ErrorMessage = "Quantidade deve ser Preenchido")]
        [Display(Name = "Quantidade?")]
        [MaxLength(5, ErrorMessage = "Descrição deve ter no máximo {1} caracteres")]
        public int Quantidade { get; set; }
        
        [Display(Name = "Empresa")]
        [MaxLength(50, ErrorMessage = "Descrição deve ter no máximo {1} caracteres")]
        public string Empresa { get; set; }

        [Required(ErrorMessage = "Descrição curta do produto")]
        [Display(Name = "Descrição do Produto?")]
        [MaxLength(200, ErrorMessage = "Descrição deve ter no máximo {1} caracteres")]
        public string DescricaoCurta { get; set; }

        [Display(Name = "Caminho Imagem Normal")]
        [StringLength(200, ErrorMessage = "O {0} deve ter no máximo {1} caracteres")]
        public string ImagemThumbnailUrl { get; set; }        
        

        public virtual T_Usuario Usuario { get; set; }  
        public virtual T_Tipo_Produto TipoProduto { get; set; }   

    }
}

