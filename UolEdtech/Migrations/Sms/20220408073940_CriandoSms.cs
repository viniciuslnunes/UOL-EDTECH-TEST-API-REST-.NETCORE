using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

namespace UolEdtech.Migrations.Sms
{
    public partial class CriandoSms : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Smss",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Tipo = table.Column<string>(type: "text", nullable: false),
                    Mensagem = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    NumDestinatario = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    Assunto = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Cliente = table.Column<string>(type: "text", nullable: false),
                    NomeUsuario = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Smss", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Smss");
        }
    }
}
