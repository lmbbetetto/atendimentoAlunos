using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace atendimentoAlunos.Migrations
{
    /// <inheritdoc />
    public partial class Alunos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Aluno",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    aniversario = table.Column<DateTime>(type: "datetime2", nullable: false),
                    cursoid = table.Column<int>(type: "int", nullable: true),
                    periodo = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Aluno", x => x.id);
                    table.ForeignKey(
                        name: "FK_Aluno_Cursos_cursoid",
                        column: x => x.cursoid,
                        principalTable: "Cursos",
                        principalColumn: "id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Aluno_cursoid",
                table: "Aluno",
                column: "cursoid");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Aluno");
        }
    }
}
