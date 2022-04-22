using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebTrader.Models.Dominio
{
    [Table("T_Endereco")]
    public class T_Endereco
    {
        [Key]
        public int IdEndereco { get; set; }

        [Required(ErrorMessage = "A descrição do Bairro deve ser preenchida")]
        [Display(Name = "Descrição do Bairro")]
        [MaxLength(50, ErrorMessage = "Descrição deve ter no máximo {1} caracteres")]
        public string Bairro { get; set; }

        [Required(ErrorMessage = "A descrição da Cidade deve ser Informado")]
        [Display(Name = "Descrição da Cidade")]
        [MaxLength(50, ErrorMessage = "Descrição deve ter no máximo {1} caracteres")]
        public string Cidade { get; set; }

        [Required(ErrorMessage = "A descrição do Estado deve ser Informado")]
        [Display(Name = "Descrição do Estado")]
        [MaxLength(50, ErrorMessage = "Descrição deve ter no máximo {1} caracteres")]
        public string Estado { get; set; }

        [Required(ErrorMessage = "A descrição do País deve ser Informado")]
        [Display(Name = "Descrição do País")]
        [MaxLength(50, ErrorMessage = "Descrição deve ter no máximo {1} caracteres")]
        public string País { get; set; }

        [Required(ErrorMessage = "O número da casa deve ser Informado")]
        [Display(Name = "Número da casa")]
        [MaxLength(5, ErrorMessage = "Descrição deve ter no máximo {1} caracteres")]
        public int NumeroCasa { get; set; }

        [Required(ErrorMessage = "A complemento deve ser Informado")]
        [Display(Name = "Descrição do Contato")]
        [MaxLength(2, ErrorMessage = "Descrição deve ter no máximo {1} caracteres")]
        public string Complemento { get; set; }

        [Required(ErrorMessage = "O Status de atividade deve ser ativado")]
        [Display(Name = "Endereco Ativo atual")]
        [MaxLength(1, ErrorMessage = "Descrição deve ter no máximo {1} caracteres")]
        public bool Ativo { get; set; }


        public List<T_Usuario> Usuario { get; set; }
    }
}
