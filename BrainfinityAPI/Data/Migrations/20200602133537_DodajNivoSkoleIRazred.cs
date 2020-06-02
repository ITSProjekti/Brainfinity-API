using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BrainfinityAPI.Data.Migrations
{
    public partial class DodajNivoSkoleIRazred : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RazredId",
                table: "GrupaZadatakas",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "NivoSkoles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NivoSkoleNaziv = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NivoSkoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Razreds",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RazredNaziv = table.Column<string>(nullable: true),
                    NivoSkoleId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Razreds", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Razreds_NivoSkoles_NivoSkoleId",
                        column: x => x.NivoSkoleId,
                        principalTable: "NivoSkoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_GrupaZadatakas_RazredId",
                table: "GrupaZadatakas",
                column: "RazredId");

            migrationBuilder.CreateIndex(
                name: "IX_Razreds_NivoSkoleId",
                table: "Razreds",
                column: "NivoSkoleId");

            migrationBuilder.AddForeignKey(
                name: "FK_GrupaZadatakas_Razreds_RazredId",
                table: "GrupaZadatakas",
                column: "RazredId",
                principalTable: "Razreds",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GrupaZadatakas_Razreds_RazredId",
                table: "GrupaZadatakas");

            migrationBuilder.DropTable(
                name: "Razreds");

            migrationBuilder.DropTable(
                name: "NivoSkoles");

            migrationBuilder.DropIndex(
                name: "IX_GrupaZadatakas_RazredId",
                table: "GrupaZadatakas");

            migrationBuilder.DropColumn(
                name: "RazredId",
                table: "GrupaZadatakas");

            migrationBuilder.AddColumn<string>(
                name: "NivoSkole",
                table: "GrupaZadatakas",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Razred",
                table: "GrupaZadatakas",
                nullable: true);
        }
    }
}