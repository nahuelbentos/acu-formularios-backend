using System;
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
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MovCod = table.Column<short>(nullable: false),
                    EscInsId = table.Column<string>(nullable: true),
                    MovilKilometraje = table.Column<int>(nullable: false),
                    Desperfecto = table.Column<string>(nullable: true),
                    FechaCreacion = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormularioDesperfectoMovil", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FormularioDiarioMovil",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MovCod = table.Column<short>(nullable: false),
                    EscInsId = table.Column<string>(nullable: true),
                    MovilKilometraje = table.Column<int>(nullable: false),
                    LucesDelanterasCortasIzquierda = table.Column<bool>(nullable: false),
                    LucesDelanterasLargasIzquierda = table.Column<bool>(nullable: false),
                    LucesDelanterasSenialeroIzquierdo = table.Column<bool>(nullable: false),
                    LucesDelanterasCortasDerecha = table.Column<bool>(nullable: false),
                    LucesDelanterasLargasDerecha = table.Column<bool>(nullable: false),
                    LucesDelanterasSenialeroDerecho = table.Column<bool>(nullable: false),
                    LucesTracerasPosicionIzquierda = table.Column<bool>(nullable: false),
                    LucesTracerasPosicionDerecha = table.Column<bool>(nullable: false),
                    LucesTracerasSenialeroIzquierdo = table.Column<bool>(nullable: false),
                    LucesTracerasSenialeroDerecho = table.Column<bool>(nullable: false),
                    LucesTracerasReversa = table.Column<bool>(nullable: false),
                    LucesTracerasFreno = table.Column<bool>(nullable: false),
                    NivelAgua = table.Column<bool>(nullable: false),
                    NivelAceite = table.Column<bool>(nullable: false),
                    ObjetoAuxiliar = table.Column<bool>(nullable: false),
                    ObjetoBaliza = table.Column<bool>(nullable: false),
                    ObjetoExtintor = table.Column<bool>(nullable: false),
                    ObjetoConos = table.Column<bool>(nullable: false),
                    Combustible = table.Column<bool>(nullable: false),
                    Observaciones = table.Column<string>(nullable: true),
                    FechaCreacion = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormularioDiarioMovil", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FormularioEvaluacionAlumno",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EscInsId = table.Column<string>(nullable: true),
                    AlumnoNombreApellido = table.Column<string>(nullable: true),
                    NumeroClase = table.Column<short>(nullable: false),
                    ProgresoEnciendeVehiculo = table.Column<int>(nullable: false),
                    ProgresoMarchaVehiculo = table.Column<int>(nullable: false),
                    ProgresoEncendidoEnNeutro = table.Column<int>(nullable: false),
                    SeguridadCinturon = table.Column<int>(nullable: false),
                    SeguridadRegulaButacaApoyaCabezas = table.Column<int>(nullable: false),
                    SeguridadRegulaEspejos = table.Column<int>(nullable: false),
                    DominaUsoPedales = table.Column<int>(nullable: false),
                    DominaAdministracionCambios = table.Column<int>(nullable: false),
                    DominaUsoEspejos = table.Column<int>(nullable: false),
                    TieneBuenaTecnicaBrazos = table.Column<int>(nullable: false),
                    DominaVehiculoEnRepecho = table.Column<int>(nullable: false),
                    SenializaCorrectamenteCambioCarril = table.Column<int>(nullable: false),
                    ReconoceSentidosCirculacion = table.Column<int>(nullable: false),
                    CirculaManteniendoDerecha = table.Column<int>(nullable: false),
                    MantieneDistanciaSeguridad = table.Column<int>(nullable: false),
                    RespetaTodasSenialesTransito = table.Column<int>(nullable: false),
                    SenializaManiobrasARealizar = table.Column<int>(nullable: false),
                    RespetaSendasPeatonales = table.Column<int>(nullable: false),
                    RespetaOtrosUsuariosDeLaVia = table.Column<int>(nullable: false),
                    MantieneVelocidadAdecuada = table.Column<int>(nullable: false),
                    FrenaConSuficienteAnticipacion = table.Column<int>(nullable: false),
                    GiroUbicacionCorrectamente = table.Column<int>(nullable: false),
                    GiroSenializaCorrectamente = table.Column<int>(nullable: false),
                    GiroIngresaCorrectamenteNuevaVia = table.Column<int>(nullable: false),
                    GiroVelocidadCorrecta = table.Column<int>(nullable: false),
                    SaleConduciendoACU = table.Column<int>(nullable: false),
                    VuelveConduciendoACU = table.Column<int>(nullable: false),
                    EvaluaEnfrentaAdecuadamenteDificultades = table.Column<int>(nullable: false),
                    ToleranciaStressTransito = table.Column<int>(nullable: false),
                    AceptaIndicacionesInstructor = table.Column<int>(nullable: false),
                    MarchaAtras = table.Column<int>(nullable: false),
                    Slalom = table.Column<int>(nullable: false),
                    EstacionamientoLateralDerecho = table.Column<int>(nullable: false),
                    EstacionamientoLateralIzquierdo = table.Column<int>(nullable: false),
                    Estacionamient45GradosDerecho = table.Column<int>(nullable: false),
                    Estacionamient45GradosIzquierdo = table.Column<int>(nullable: false),
                    Observaciones = table.Column<string>(nullable: true),
                    FechaCreacion = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormularioEvaluacionAlumno", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FormularioResultadoExamenPractico",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EscInsId = table.Column<string>(nullable: true),
                    AlumnoNombreApellido = table.Column<string>(nullable: true),
                    EsAlumnoOtroInstructor = table.Column<bool>(nullable: false),
                    InstructorAlumnoId = table.Column<string>(nullable: true),
                    Resultado = table.Column<int>(nullable: false),
                    MotivoReprobacionPista = table.Column<int>(nullable: true),
                    MotivoReprobacionCalle = table.Column<int>(nullable: true),
                    DetalleMotivoPerdida = table.Column<string>(nullable: true),
                    FechaCreacion = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormularioResultadoExamenPractico", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FormularioDesperfectoMovil");

            migrationBuilder.DropTable(
                name: "FormularioDiarioMovil");

            migrationBuilder.DropTable(
                name: "FormularioEvaluacionAlumno");

            migrationBuilder.DropTable(
                name: "FormularioResultadoExamenPractico");
        }
    }
}
