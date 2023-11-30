using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KartverkCase.Migrations
{
    public partial class Addmigrationinit2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Brukere",
                table: "Brukere");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Brukere",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Brukere",
                table: "Brukere",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Brukere",
                table: "Brukere");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Brukere");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Brukere",
                table: "Brukere",
                column: "Fødselsdato");
        }
    }
}
