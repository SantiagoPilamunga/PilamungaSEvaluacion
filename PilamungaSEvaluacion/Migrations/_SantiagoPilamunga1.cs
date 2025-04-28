using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PilamungaSEvaluacion.Migrations
{
    /// <inheritdoc />
    public partial class SantiagoPilamunga1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Puntos",
                table: "Clientes",
                type: "int",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Puntos",
                table: "Clientes");
        }
    }
}
