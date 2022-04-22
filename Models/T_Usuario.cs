using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebTrader.Models.Dominio;

namespace WebTrader.Models
{
    [Table("T_Usuario")]
    public class T_Usuario
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Descrição do Nome do usuário")]
        [Display(Name = "Descrição do Nome")]
        [MaxLength(200, ErrorMessage = "Descrição deve ter no máximo {1} caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Descrição da Idade")]
        [Display(Name = "Descrição da Idade")]
        [MaxLength(200, ErrorMessage = "Descrição da Idade no máximo {1} caracteres")]
        public string Idade { get; set; }

        [Required(ErrorMessage = "Descrição do Sexo")]
        [Display(Name = "Descrição do Sexo")]
        [MaxLength(200, ErrorMessage = "Descrição do Sexo deve ter no máximo {1} caracteres")]
        public string Sexo { get; set; }

        [Required(ErrorMessage = "Digite seu CPF")]
        [Display(Name = "Descrição do CPF")]
        [MaxLength(200, ErrorMessage = "Descrição deve ter no máximo {1} caracteres")]
        public string CPF { get; set; }

        [Required(ErrorMessage = "Descrição do RG")]
        [Display(Name = "Descrição do RG")]
        [MaxLength(200, ErrorMessage = "Descrição deve ter no máximo {1} caracteres")]
        public string RG { get; set; }        


        public virtual T_Contato Contatos { get; set; }
        public virtual T_Endereco Enderecos { get; set; }
        public List<T_Proposta_Negociacao> Propostas { get; set; }

    }
}
