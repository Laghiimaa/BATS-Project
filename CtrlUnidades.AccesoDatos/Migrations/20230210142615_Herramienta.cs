using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CtrlUnidades.Data.Migrations
{
    /// <inheritdoc />
    public partial class Herramienta : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Herramienta",
                columns: table => new
                {
                    IdHerr = table.Column<string>(name: "Id_Herr", type: "nvarchar(450)", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Herramientas", x => x.IdHerr);
                });
        }

    }
}
