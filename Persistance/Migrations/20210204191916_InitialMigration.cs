using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistance.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FormularioDesperfectoMovil",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MovCod = table.Column<string>(nullable: true),
                    EscInsId = table.Column<string>(nullable: true),
                    MovilKilometraje = table.Column<int>(nullable: false),
                    Desperfecto = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormularioDesperfectoMovil", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FormularioDiarioMovil",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MovCod = table.Column<string>(nullable: true),
                    EscInsId = table.Column<string>(nullable: true),
                    MovilKilometraje = table.Column<int>(nullable: false),
                    LucesDelanterasCortasIzquierda = table.Column<string>(nullable: true),
                    LucesDelanterasLargasIzquierda = table.Column<string>(nullable: true),
                    LucesDelanterasSenialeroIzquierdo = table.Column<string>(nullable: true),
                    LucesDelanterasCortasDerecha = table.Column<string>(nullable: true),
                    LucesDelanterasLargasDerecha = table.Column<string>(nullable: true),
                    LucesDelanterasSenialeroDerecho = table.Column<string>(nullable: true),
                    LucesTracerasPosicionIzquierda = table.Column<string>(nullable: true),
                    LucesTracerasPosicionDerecha = table.Column<string>(nullable: true),
                    LucesTracerasSenialeroIzquierdo = table.Column<string>(nullable: true),
                    LucesTracerasSenialeroDerecho = table.Column<string>(nullable: true),
                    LucesTracerasReversa = table.Column<string>(nullable: true),
                    LucesTracerasFreno = table.Column<string>(nullable: true),
                    NivelAgua = table.Column<string>(nullable: true),
                    NivelAceite = table.Column<string>(nullable: true),
                    ObjetoAuxiliar = table.Column<string>(nullable: true),
                    ObjetoBaliza = table.Column<string>(nullable: true),
                    ObjetoExtintor = table.Column<string>(nullable: true),
                    ObjetoConos = table.Column<string>(nullable: true),
                    Combustible = table.Column<string>(nullable: true),
                    Observaciones = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormularioDiarioMovil", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FormularioDesperfectoMovil");

            migrationBuilder.DropTable(
                name: "FormularioDiarioMovil");
        }
    }
}
