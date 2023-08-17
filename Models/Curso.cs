using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace atendimentoAlunos.Models
{
    [Table("Cursos")]
    public class Curso
    {
        [Key]
        public int id { get; set; }

        [Required]
        [StringLength(35)]
        public string descricao { get; set; }
    }
}
