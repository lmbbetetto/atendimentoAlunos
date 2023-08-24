using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace atendimentoAlunos.Migrations
{
    /// <inheritdoc />
    public partial class Atendimento_v2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Atendimento_Aluno_alunoid",
                table: "Atendimento");

            migrationBuilder.DropForeignKey(
                name: "FK_Atendimento_Sala_salaid",
                table: "Atendimento");

            migrationBuilder.RenameColumn(
                name: "salaid",
                table: "Atendimento",
                newName: "salaID");

            migrationBuilder.RenameColumn(
                name: "alunoid",
                table: "Atendimento",
                newName: "alunoID");

            migrationBuilder.RenameIndex(
                name: "IX_Atendimento_salaid",
                table: "Atendimento",
                newName: "IX_Atendimento_salaID");

            migrationBuilder.RenameIndex(
                name: "IX_Atendimento_alunoid",
                table: "Atendimento",
                newName: "IX_Atendimento_alunoID");

            migrationBuilder.AlterColumn<int>(
                name: "salaID",
                table: "Atendimento",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "alunoID",
                table: "Atendimento",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "nome",
                table: "Aluno",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Atendimento_Aluno_alunoID",
                table: "Atendimento",
                column: "alunoID",
                principalTable: "Aluno",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Atendimento_Sala_salaID",
                table: "Atendimento",
                column: "salaID",
                principalTable: "Sala",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Atendimento_Aluno_alunoID",
                table: "Atendimento");

            migrationBuilder.DropForeignKey(
                name: "FK_Atendimento_Sala_salaID",
                table: "Atendimento");

            migrationBuilder.RenameColumn(
                name: "salaID",
                table: "Atendimento",
                newName: "salaid");

            migrationBuilder.RenameColumn(
                name: "alunoID",
                table: "Atendimento",
                newName: "alunoid");

            migrationBuilder.RenameIndex(
                name: "IX_Atendimento_salaID",
                table: "Atendimento",
                newName: "IX_Atendimento_salaid");

            migrationBuilder.RenameIndex(
                name: "IX_Atendimento_alunoID",
                table: "Atendimento",
                newName: "IX_Atendimento_alunoid");

            migrationBuilder.AlterColumn<int>(
                name: "salaid",
                table: "Atendimento",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "alunoid",
                table: "Atendimento",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "nome",
                table: "Aluno",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddForeignKey(
                name: "FK_Atendimento_Aluno_alunoid",
                table: "Atendimento",
                column: "alunoid",
                principalTable: "Aluno",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Atendimento_Sala_salaid",
                table: "Atendimento",
                column: "salaid",
                principalTable: "Sala",
                principalColumn: "id");
        }
    }
}
