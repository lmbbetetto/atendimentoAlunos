using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace atendimentoAlunos.Models
{
    [Table("Sala")]
    public class Sala
    {
        [Key]
        [Display(Name = "Código")]
        [Required(ErrorMessage = "Campo Obrigatório!")]
        public int id { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório!")]
        [Display(Name = "Descrição")]
        public string descricao { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório!")]
        [Display(Name = "Instrutor")]
        public string monitor { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório!")]
        [Display(Name = "Equipamentos")]
        public int equipamentos { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório!")]
        [Display(Name = "Siatuação")]
        public char situacao { get; set; }
    }
}
