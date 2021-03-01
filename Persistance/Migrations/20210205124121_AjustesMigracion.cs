using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistance.Migrations
{
    public partial class AjustesMigracion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<short>(
                name: "MovCod",
                table: "FormularioDiarioMovil",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaCreacion",
                table: "FormularioDiarioMovil",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AlterColumn<short>(
                name: "MovCod",
                table: "FormularioDesperfectoMovil",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaCreacion",
                table: "FormularioDesperfectoMovil",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FechaCreacion",
                table: "FormularioDiarioMovil");

            migrationBuilder.DropColumn(
                name: "FechaCreacion",
                table: "FormularioDesperfectoMovil");

            migrationBuilder.AlterColumn<string>(
                name: "MovCod",
                table: "FormularioDiarioMovil",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(short));

            migrationBuilder.AlterColumn<string>(
                name: "MovCod",
                table: "FormularioDesperfectoMovil",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(short));
        }
    }
}
