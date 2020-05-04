using Microsoft.EntityFrameworkCore.Migrations;

namespace BrainfinityAPI.Data.Migrations
{
    public partial class TakmicenjeRequiredPolja : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Naziv",
                table: "Takmicenjes",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Naziv",
                table: "Takmicenjes",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 255);
        }
    }
}
