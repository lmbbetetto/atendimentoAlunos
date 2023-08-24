using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace atendimentoAlunos.Models
{
    public class Atendimento
    {
        [Key]
        [Display(Name = "Código")]
        public int id { get; set; }

        public int alunoID { get; set; }
        [ForeignKey("alunoID")]
        [Display(Name = "Código do Aluno")]
        public Aluno aluno { get; set; }

        public int salaID { get; set; }
        [ForeignKey("salaID")]
        [Display(Name = "Código da Sala")]
        public Sala sala { get; set; }

        [DataType(DataType.DateTime)]
        [Display(Name = "Data e Hora")]
        public DateTime dataHora { get; set; }
    }
}
