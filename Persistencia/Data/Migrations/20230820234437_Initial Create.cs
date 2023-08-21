using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistencia.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "automovil",
                columns: table => new
                {
                    ID_Automovil = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Marca = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Modelo = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Anio = table.Column<int>(type: "int", nullable: false),
                    Tipo = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Capacidad = table.Column<int>(type: "int", nullable: false),
                    Precio_Diario = table.Column<decimal>(type: "decimal(10,2)", precision: 10, scale: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_automovil", x => x.ID_Automovil);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "cliente",
                columns: table => new
                {
                    ID_Cliente = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Apellido = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DNI = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Direccion = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Telefono = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cliente", x => x.ID_Cliente);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "empleado",
                columns: table => new
                {
                    ID_Empleado = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Apellido = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DNI = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Direccion = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Telefono = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Cargo = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_empleado", x => x.ID_Empleado);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "sucursal",
                columns: table => new
                {
                    ID_Sucursal = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Direccion = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Telefono = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sucursal", x => x.ID_Sucursal);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "alquiler",
                columns: table => new
                {
                    ID_Alquiler = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ID_Cliente = table.Column<int>(type: "int", nullable: false),
                    ID_Automovil = table.Column<int>(type: "int", nullable: false),
                    Fecha_Incio = table.Column<DateTime>(type: "date", nullable: false),
                    Fecha_Fin = table.Column<DateTime>(type: "date", nullable: false),
                    Costo_Total = table.Column<decimal>(type: "decimal(10,2)", precision: 10, scale: 2, nullable: false),
                    Estado = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_alquiler", x => x.ID_Alquiler);
                    table.ForeignKey(
                        name: "FK_alquiler_automovil_ID_Automovil",
                        column: x => x.ID_Automovil,
                        principalTable: "automovil",
                        principalColumn: "ID_Automovil",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_alquiler_cliente_ID_Cliente",
                        column: x => x.ID_Cliente,
                        principalTable: "cliente",
                        principalColumn: "ID_Cliente",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "reserva",
                columns: table => new
                {
                    ID_Reserva = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ID_Cliente = table.Column<int>(type: "int", nullable: false),
                    ClienteID_Cliente = table.Column<int>(type: "int", nullable: false),
                    ID_Automovil = table.Column<int>(type: "int", nullable: false),
                    AutomovilID_Automovil = table.Column<int>(type: "int", nullable: false),
                    Fecha_Reserva = table.Column<DateTime>(type: "date", nullable: false),
                    Fecha_Inicio = table.Column<DateTime>(type: "date", nullable: false),
                    Fecha_Fin = table.Column<DateTime>(type: "date", nullable: false),
                    Estado = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_reserva", x => x.ID_Reserva);
                    table.ForeignKey(
                        name: "FK_reserva_automovil_AutomovilID_Automovil",
                        column: x => x.AutomovilID_Automovil,
                        principalTable: "automovil",
                        principalColumn: "ID_Automovil",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_reserva_cliente_ClienteID_Cliente",
                        column: x => x.ClienteID_Cliente,
                        principalTable: "cliente",
                        principalColumn: "ID_Cliente",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "sucursal_automovil",
                columns: table => new
                {
                    ID_Sucursal = table.Column<int>(type: "int", nullable: false),
                    ID_Automovil = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sucursal_automovil", x => new { x.ID_Automovil, x.ID_Sucursal });
                    table.ForeignKey(
                        name: "FK_sucursal_automovil_automovil_ID_Automovil",
                        column: x => x.ID_Automovil,
                        principalTable: "automovil",
                        principalColumn: "ID_Automovil",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_sucursal_automovil_sucursal_ID_Sucursal",
                        column: x => x.ID_Sucursal,
                        principalTable: "sucursal",
                        principalColumn: "ID_Sucursal",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "registro_devolucion",
                columns: table => new
                {
                    ID_Registro = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ID_Alquiler = table.Column<int>(type: "int", nullable: false),
                    ID_Empleado = table.Column<int>(type: "int", nullable: false),
                    Fecha_Devolucion = table.Column<DateTime>(type: "date", nullable: false),
                    Combustible_Devuelto = table.Column<decimal>(type: "decimal(5,2)", precision: 5, scale: 2, nullable: false),
                    Kilometraje_Devuelto = table.Column<int>(type: "int", nullable: false),
                    Monto_Adicional = table.Column<decimal>(type: "decimal(10,2)", precision: 10, scale: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_registro_devolucion", x => x.ID_Registro);
                    table.ForeignKey(
                        name: "FK_registro_devolucion_alquiler_ID_Alquiler",
                        column: x => x.ID_Alquiler,
                        principalTable: "alquiler",
                        principalColumn: "ID_Alquiler",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_registro_devolucion_empleado_ID_Empleado",
                        column: x => x.ID_Empleado,
                        principalTable: "empleado",
                        principalColumn: "ID_Empleado",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "registro_entrega",
                columns: table => new
                {
                    ID_Registro = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ID_Alquiler = table.Column<int>(type: "int", nullable: false),
                    ID_Empleado = table.Column<int>(type: "int", nullable: false),
                    Fecha_Entrega = table.Column<DateTime>(type: "date", nullable: false),
                    Combustible_Entregado = table.Column<decimal>(type: "decimal(5,2)", precision: 5, scale: 2, nullable: false),
                    Kilometraje_Entregado = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_registro_entrega", x => x.ID_Registro);
                    table.ForeignKey(
                        name: "FK_registro_entrega_alquiler_ID_Alquiler",
                        column: x => x.ID_Alquiler,
                        principalTable: "alquiler",
                        principalColumn: "ID_Alquiler",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_registro_entrega_empleado_ID_Empleado",
                        column: x => x.ID_Empleado,
                        principalTable: "empleado",
                        principalColumn: "ID_Empleado",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_alquiler_ID_Automovil",
                table: "alquiler",
                column: "ID_Automovil");

            migrationBuilder.CreateIndex(
                name: "IX_alquiler_ID_Cliente",
                table: "alquiler",
                column: "ID_Cliente");

            migrationBuilder.CreateIndex(
                name: "IX_registro_devolucion_ID_Alquiler",
                table: "registro_devolucion",
                column: "ID_Alquiler");

            migrationBuilder.CreateIndex(
                name: "IX_registro_devolucion_ID_Empleado",
                table: "registro_devolucion",
                column: "ID_Empleado");

            migrationBuilder.CreateIndex(
                name: "IX_registro_entrega_ID_Alquiler",
                table: "registro_entrega",
                column: "ID_Alquiler");

            migrationBuilder.CreateIndex(
                name: "IX_registro_entrega_ID_Empleado",
                table: "registro_entrega",
                column: "ID_Empleado");

            migrationBuilder.CreateIndex(
                name: "IX_reserva_AutomovilID_Automovil",
                table: "reserva",
                column: "AutomovilID_Automovil");

            migrationBuilder.CreateIndex(
                name: "IX_reserva_ClienteID_Cliente",
                table: "reserva",
                column: "ClienteID_Cliente");

            migrationBuilder.CreateIndex(
                name: "IX_sucursal_automovil_ID_Sucursal",
                table: "sucursal_automovil",
                column: "ID_Sucursal");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "registro_devolucion");

            migrationBuilder.DropTable(
                name: "registro_entrega");

            migrationBuilder.DropTable(
                name: "reserva");

            migrationBuilder.DropTable(
                name: "sucursal_automovil");

            migrationBuilder.DropTable(
                name: "alquiler");

            migrationBuilder.DropTable(
                name: "empleado");

            migrationBuilder.DropTable(
                name: "sucursal");

            migrationBuilder.DropTable(
                name: "automovil");

            migrationBuilder.DropTable(
                name: "cliente");
        }
    }
}
