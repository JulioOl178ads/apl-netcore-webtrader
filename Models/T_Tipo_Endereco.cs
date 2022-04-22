using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebTrader.Models
{
    [Table("T_Tipo_Endereco")]
    public class T_Tipo_Endereco
    {
        [Key]
        public int IdEndereco { get; set; }

        [Required(ErrorMessage = "Descrição curta do tipo de contato")]
        [Display(Name = "Descrição do Tipo de Produto")]
        [MaxLength(200, ErrorMessage = "Descrição deve ter no máximo {1} caracteres")]
        public string Descricao { get; set; }
        public List<T_Contato> Contatos { get; set; }
    }
}
