using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistance.Migrations
{
    public partial class EvaluacionYResultadoExamen : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FormularioEvaluacionAlumno",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
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
                    Observaciones = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormularioEvaluacionAlumno", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FormularioResultadoExamenPractico",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EscInsId = table.Column<string>(nullable: true),
                    AlumnoNombreApellido = table.Column<string>(nullable: true),
                    EsAlumnoOtroInstructor = table.Column<bool>(nullable: false),
                    InstructorAlumnoId = table.Column<string>(nullable: true),
                    Resultado = table.Column<int>(nullable: false),
                    MotivoReprobacionPista = table.Column<int>(nullable: false),
                    MotivoReprobacionCalle = table.Column<int>(nullable: false),
                    DetalleMotivoPerdida = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormularioResultadoExamenPractico", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FormularioEvaluacionAlumno");

            migrationBuilder.DropTable(
                name: "FormularioResultadoExamenPractico");
        }
    }
}
