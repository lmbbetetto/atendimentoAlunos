using Microsoft.EntityFrameworkCore;

namespace atendimentoAlunos.Models
{
    public class Contexto: DbContext
    {
        public Contexto(DbContextOptions<Contexto> options): base(options) { }

        public DbSet<Curso> Cursos { get; set; }
        public DbSet<Sala> Sala { get; set; }
        public DbSet<Aluno> Aluno { get; set; }
        public DbSet<Atendimento> Atendimento { get; set; }
    }
}
