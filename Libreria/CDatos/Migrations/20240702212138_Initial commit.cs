using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CDatos.Migrations
{
    /// <inheritdoc />
    public partial class Initialcommit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Autor",
                columns: table => new
                {
                    IdAutor = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Biografia = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CantidadLibroEscrito = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ID_AUTOR", x => x.IdAutor);
                });

            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    IdCliente = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TieneMembrecia = table.Column<bool>(type: "bit", nullable: false),
                    PagaIva = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ID_CLIENTE", x => x.IdCliente);
                });

            migrationBuilder.CreateTable(
                name: "CopiaLibro",
                columns: table => new
                {
                    IdCopiaLibro = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PrecioPrestamo = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ID_COPIA_LIBRO", x => x.IdCopiaLibro);
                });

            migrationBuilder.CreateTable(
                name: "Editorial",
                columns: table => new
                {
                    IdEditorial = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ID_EDITORIAL", x => x.IdEditorial);
                });

            migrationBuilder.CreateTable(
                name: "Empleado",
                columns: table => new
                {
                    IdEmpleado = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Sueldo = table.Column<double>(type: "float", nullable: false),
                    Puesto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaIngreso = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ID_EMPLEADO", x => x.IdEmpleado);
                });

            migrationBuilder.CreateTable(
                name: "FormaPago",
                columns: table => new
                {
                    IdFormaPago = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ID_FORMA_PAGO", x => x.IdFormaPago);
                });

            migrationBuilder.CreateTable(
                name: "Genero",
                columns: table => new
                {
                    IdGenero = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ID_GENERO", x => x.IdGenero);
                });

            migrationBuilder.CreateTable(
                name: "GeneroLibro",
                columns: table => new
                {
                    IdGeneroLibro = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdLibro = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ID_GENERO_LIBRO", x => x.IdGeneroLibro);
                });

            migrationBuilder.CreateTable(
                name: "Libro",
                columns: table => new
                {
                    IdLibro = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Isbn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaPublicacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Titulo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Stock = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ID_LIBRO", x => x.IdLibro);
                });

            migrationBuilder.CreateTable(
                name: "Persona",
                columns: table => new
                {
                    IdPersona = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Apellido = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Dni = table.Column<long>(type: "bigint", nullable: false),
                    Documento = table.Column<int>(type: "int", nullable: false),
                    TipoDocumento = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefono = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ID_PERSONA", x => x.IdPersona);
                });

            migrationBuilder.CreateTable(
                name: "Prestamo",
                columns: table => new
                {
                    IdPrestamo = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FechaPrestamo = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ID_PRESTAMO", x => x.IdPrestamo);
                });

            migrationBuilder.CreateTable(
                name: "Venta",
                columns: table => new
                {
                    IdVenta = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaVenta = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ID_VENTA", x => x.IdVenta);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Autor");

            migrationBuilder.DropTable(
                name: "Cliente");

            migrationBuilder.DropTable(
                name: "CopiaLibro");

            migrationBuilder.DropTable(
                name: "Editorial");

            migrationBuilder.DropTable(
                name: "Empleado");

            migrationBuilder.DropTable(
                name: "FormaPago");

            migrationBuilder.DropTable(
                name: "Genero");

            migrationBuilder.DropTable(
                name: "GeneroLibro");

            migrationBuilder.DropTable(
                name: "Libro");

            migrationBuilder.DropTable(
                name: "Persona");

            migrationBuilder.DropTable(
                name: "Prestamo");

            migrationBuilder.DropTable(
                name: "Venta");
        }
    }
}
