using Microsoft.EntityFrameworkCore.Migrations;

namespace BrainfinityAPI.Data.Migrations
{
    public partial class PopuniTabeluNivoSkole : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO NivoSkoles (NivoSkoleNaziv) VALUES ('Osnovna škola')");
            migrationBuilder.Sql("INSERT INTO NivoSkoles (NivoSkoleNaziv) VALUES ('Srednja škola')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
        }
    }
}