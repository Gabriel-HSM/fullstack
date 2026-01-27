using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PraticasSolo.Migrations
{
    /// <inheritdoc />
    public partial class AddMarcaIdAndMotorIdToCarro : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Motor",
                table: "Carro",
                newName: "MotorAntigo");

            migrationBuilder.RenameColumn(
                name: "Marca",
                table: "Carro",
                newName: "MarcaAntiga");

            migrationBuilder.AddColumn<int>(
                name: "MarcaId",
                table: "Carro",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MotorId",
                table: "Carro",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Carro_MarcaId",
                table: "Carro",
                column: "MarcaId");

            migrationBuilder.CreateIndex(
                name: "IX_Carro_MotorId",
                table: "Carro",
                column: "MotorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Carro_Marcas_MarcaId",
                table: "Carro",
                column: "MarcaId",
                principalTable: "Marcas",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Carro_Motores_MotorId",
                table: "Carro",
                column: "MotorId",
                principalTable: "Motores",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Carro_Marcas_MarcaId",
                table: "Carro");

            migrationBuilder.DropForeignKey(
                name: "FK_Carro_Motores_MotorId",
                table: "Carro");

            migrationBuilder.DropIndex(
                name: "IX_Carro_MarcaId",
                table: "Carro");

            migrationBuilder.DropIndex(
                name: "IX_Carro_MotorId",
                table: "Carro");

            migrationBuilder.DropColumn(
                name: "MarcaId",
                table: "Carro");

            migrationBuilder.DropColumn(
                name: "MotorId",
                table: "Carro");

            migrationBuilder.RenameColumn(
                name: "MotorAntigo",
                table: "Carro",
                newName: "Motor");

            migrationBuilder.RenameColumn(
                name: "MarcaAntiga",
                table: "Carro",
                newName: "Marca");
        }
    }
}
