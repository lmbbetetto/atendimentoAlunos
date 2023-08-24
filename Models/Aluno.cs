using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace atendimentoAlunos.Models
{
    [Table("Aluno")]
    public class Aluno
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Código")]
        [Required(ErrorMessage = "Campo Obrigatório!")]
        public int id { get; set; }

        [Display(Name = "Nome")]
        [Required(ErrorMessage = "Campo obrigatório!")]
        public string nome { get; set; }

        [Display(Name = "Data de nascimento")]
        [Required(ErrorMessage = "Campo obrigatório!")]
        public DateTime aniversario { get; set; }

        public int cursoID { get; set; }
        [Required(ErrorMessage = "Campo Obrigatório!")]
        [Display(Name = "Curso")]
        public Curso curso { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório!")]
        [Display(Name = "Período")]
        public string periodo { get; set; }
    }
}
