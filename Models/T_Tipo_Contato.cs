using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebTrader.Models
{
    [Table("T_Tipo_Contato")]
    public class T_Tipo_Contato
    {
        [Key]
        public int IdTipoContato { get; set; }

        [Required(ErrorMessage = "Descrição curta do tipo de contato")]
        [Display(Name = "Descrição do Tipo de Produto")]
        [MaxLength(200, ErrorMessage = "Descrição deve ter no máximo {1} caracteres")]
        public string Descricao { get; set; }
        public List<T_Contato> Contato { get; set; }
    }
}
