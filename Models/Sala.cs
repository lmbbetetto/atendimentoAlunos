using System.ComponentModel.DataAnnotations.Schema;

namespace atendimentoAlunos.Models
{
    [Table("Sala")]
    public class Sala
    {
        public int id { get; set; }
        public string descricao { get; set; }
        public int equipamentos { get; set; }
        public char situacao { get; set; }
    }
}
