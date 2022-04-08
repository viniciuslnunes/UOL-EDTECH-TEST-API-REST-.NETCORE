using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

namespace UolEdtech.Migrations
{
    public partial class CriandoEmail : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Emails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Tipo = table.Column<string>(type: "text", nullable: false),
                    Mensagem = table.Column<string>(type: "text", nullable: false),
                    EmailDestinatario = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    EmailOrigem = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    Assunto = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Cliente = table.Column<string>(type: "text", nullable: false),
                    NomeUsuario = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Emails", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Emails");
        }
    }
}
