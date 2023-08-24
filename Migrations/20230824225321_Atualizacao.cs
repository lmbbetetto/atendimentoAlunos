using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace atendimentoAlunos.Migrations
{
    /// <inheritdoc />
    public partial class Atualizacao : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Aluno_Cursos_cursoid",
                table: "Aluno");

            migrationBuilder.RenameColumn(
                name: "cursoid",
                table: "Aluno",
                newName: "cursoID");

            migrationBuilder.RenameIndex(
                name: "IX_Aluno_cursoid",
                table: "Aluno",
                newName: "IX_Aluno_cursoID");

            migrationBuilder.AlterColumn<string>(
                name: "descricao",
                table: "Sala",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "monitor",
                table: "Sala",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "periodo",
                table: "Aluno",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "cursoID",
                table: "Aluno",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Aluno_Cursos_cursoID",
                table: "Aluno",
                column: "cursoID",
                principalTable: "Cursos",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Aluno_Cursos_cursoID",
                table: "Aluno");

            migrationBuilder.DropColumn(
                name: "monitor",
                table: "Sala");

            migrationBuilder.RenameColumn(
                name: "cursoID",
                table: "Aluno",
                newName: "cursoid");

            migrationBuilder.RenameIndex(
                name: "IX_Aluno_cursoID",
                table: "Aluno",
                newName: "IX_Aluno_cursoid");

            migrationBuilder.AlterColumn<string>(
                name: "descricao",
                table: "Sala",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "periodo",
                table: "Aluno",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "cursoid",
                table: "Aluno",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Aluno_Cursos_cursoid",
                table: "Aluno",
                column: "cursoid",
                principalTable: "Cursos",
                principalColumn: "id");
        }
    }
}
