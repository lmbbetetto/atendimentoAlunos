namespace atendimentoAlunos.Models
{
    public class Atendimento
    {
        public int id { get; set; }
        public Aluno aluno { get; set; }
        public Sala sala { get; set; }
        public DateTime dataHora { get; set; }
    }
}
