using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CtrlUnidades.Data.Migrations
{
    /// <inheritdoc />
    public partial class TipoUnidades : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TipoUnidad",
                columns: table => new
                {
                    IdTUni = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Observaciones = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoUnidad", x => x.IdTUni);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TipoUnidad");
        }
    }
}
