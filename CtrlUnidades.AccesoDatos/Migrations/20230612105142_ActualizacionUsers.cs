using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CtrlUnidades.Data.Migrations
{
    /// <inheritdoc />
    public partial class ActualizacionUsers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Permisos",
                table: "AspNetUsers",
                newName: "UsuarioTipo");

            migrationBuilder.RenameColumn(
                name: "IdUsu",
                table: "AspNetUsers",
                newName: "PushToken");

            migrationBuilder.AddColumn<string>(
                name: "Conductor_Id",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Estado",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Conductor_Id",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Estado",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "UsuarioTipo",
                table: "AspNetUsers",
                newName: "Permisos");

            migrationBuilder.RenameColumn(
                name: "PushToken",
                table: "AspNetUsers",
                newName: "IdUsu");
        }
    }
}
