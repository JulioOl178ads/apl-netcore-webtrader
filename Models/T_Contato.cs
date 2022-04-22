using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebTrader.Models
{
    [Table("T_Contato")]
    public class T_Contato
    {
        [Key]
        public int IdContato { get; set; }

        [Required(ErrorMessage = "A Descrição do Contato deve ser Informado")]
        [Display(Name = "Descrição do Contato")]
        [MaxLength(25, ErrorMessage = "Descrição deve ter no máximo {1} caracteres")]        
        public string DescricaoContato { get; set; }

        [Display(Name = "Ativo?")]
        public bool Ativo { get; set; }
        

        public virtual T_Tipo_Contato TipoContato { get; set; }                
        public List<T_Usuario> Usuario { get; set; }

    }
}
