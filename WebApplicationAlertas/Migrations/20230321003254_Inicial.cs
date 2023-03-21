using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplicationAlertas.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Correos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Destinatarios = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Copias = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Asunto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cuerpo = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Correos", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Correos");
        }
    }
}
