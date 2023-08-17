using System.ComponentModel.DataAnnotations.Schema;

namespace atendimentoAlunos.Models
{
    [Table("Aluno")]
    public class Aluno
    {
        public int id { get; set; }
        public string nome { get; set; }
        public DateTime aniversario { get; set; }
        public Curso curso { get; set; }
        public string periodo { get; set; }
    }
}
