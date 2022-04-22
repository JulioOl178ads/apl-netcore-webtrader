using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebTrader.Models.Tipo
{
    [Table("T_Tipo_Produto")]
    public class T_Tipo_Produto
    {
        [Key]
        public int IdTipoProduto { get; set; }

        [Required(ErrorMessage = "Descrição curta do tipo de produto")]
        [Display(Name = "Descrição do tipo de Produto")]
        [MaxLength(200, ErrorMessage = "Descrição deve ter no máximo {1} caracteres")]
        public string Descricao { get; set; }

        public List<T_Proposta_Negociacao> TiposProduto { get; set; }
    }
}
