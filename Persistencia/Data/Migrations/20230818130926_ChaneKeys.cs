using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistencia.Data.Migrations
{
    /// <inheritdoc />
    public partial class ChaneKeys : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_sucursal_automovil_automovil_AutomovilID_Automovil",
                table: "sucursal_automovil");

            migrationBuilder.DropForeignKey(
                name: "FK_sucursal_automovil_sucursal_SucursalID_Sucursal",
                table: "sucursal_automovil");

            migrationBuilder.DropPrimaryKey(
                name: "PK_sucursal_automovil",
                table: "sucursal_automovil");

            migrationBuilder.DropIndex(
                name: "IX_sucursal_automovil_SucursalID_Sucursal",
                table: "sucursal_automovil");

            migrationBuilder.DropColumn(
                name: "AutomovilID_Automovil",
                table: "sucursal_automovil");

            migrationBuilder.DropColumn(
                name: "SucursalID_Sucursal",
                table: "sucursal_automovil");

            migrationBuilder.AddPrimaryKey(
                name: "PK_sucursal_automovil",
                table: "sucursal_automovil",
                columns: new[] { "ID_Automovil", "ID_Sucursal" });

            migrationBuilder.CreateIndex(
                name: "IX_sucursal_automovil_ID_Sucursal",
                table: "sucursal_automovil",
                column: "ID_Sucursal");

            migrationBuilder.AddForeignKey(
                name: "FK_sucursal_automovil_automovil_ID_Automovil",
                table: "sucursal_automovil",
                column: "ID_Automovil",
                principalTable: "automovil",
                principalColumn: "ID_Automovil",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_sucursal_automovil_sucursal_ID_Sucursal",
                table: "sucursal_automovil",
                column: "ID_Sucursal",
                principalTable: "sucursal",
                principalColumn: "ID_Sucursal",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_sucursal_automovil_automovil_ID_Automovil",
                table: "sucursal_automovil");

            migrationBuilder.DropForeignKey(
                name: "FK_sucursal_automovil_sucursal_ID_Sucursal",
                table: "sucursal_automovil");

            migrationBuilder.DropPrimaryKey(
                name: "PK_sucursal_automovil",
                table: "sucursal_automovil");

            migrationBuilder.DropIndex(
                name: "IX_sucursal_automovil_ID_Sucursal",
                table: "sucursal_automovil");

            migrationBuilder.AddColumn<int>(
                name: "AutomovilID_Automovil",
                table: "sucursal_automovil",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SucursalID_Sucursal",
                table: "sucursal_automovil",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_sucursal_automovil",
                table: "sucursal_automovil",
                columns: new[] { "AutomovilID_Automovil", "SucursalID_Sucursal" });

            migrationBuilder.CreateIndex(
                name: "IX_sucursal_automovil_SucursalID_Sucursal",
                table: "sucursal_automovil",
                column: "SucursalID_Sucursal");

            migrationBuilder.AddForeignKey(
                name: "FK_sucursal_automovil_automovil_AutomovilID_Automovil",
                table: "sucursal_automovil",
                column: "AutomovilID_Automovil",
                principalTable: "automovil",
                principalColumn: "ID_Automovil",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_sucursal_automovil_sucursal_SucursalID_Sucursal",
                table: "sucursal_automovil",
                column: "SucursalID_Sucursal",
                principalTable: "sucursal",
                principalColumn: "ID_Sucursal",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
