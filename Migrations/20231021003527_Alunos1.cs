using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Alunos1.Migrations
{
    public partial class Alunos1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Alunos1",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Idade = table.Column<int>(type: "int", nullable: false),
                    NumeroSala = table.Column<int>(type: "int", nullable: false),
                    NomeProf = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NotaPrimeiroSemestre = table.Column<double>(type: "float", nullable: false),
                    NotaSegundoSemestre = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alunos1", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Alunos1");
        }
    }
}
