using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace atendimentoAlunos.Models
{
    public class Atendimento
    {
        [Key]
        [Display(Name = "Código")]
        [Required(ErrorMessage = "Campo Obrigatório!")]
        public int id { get; set; }

        public int alunoID { get; set; }
        [ForeignKey("alunoID")]
        [Display(Name = "Código do Aluno")]
        [Required(ErrorMessage = "Campo Obrigatório!")]
        public Aluno aluno { get; set; }

        public int salaID { get; set; }
        [ForeignKey("salaID")]
        [Display(Name = "Código da Sala")]
        [Required(ErrorMessage = "Campo Obrigatório!")]
        public Sala sala { get; set; }

        [DataType(DataType.DateTime)]
        [Display(Name = "Data e Hora")]
        [Required(ErrorMessage = "Campo Obrigatório!")]
        public DateTime dataHora { get; set; }
    }
}
