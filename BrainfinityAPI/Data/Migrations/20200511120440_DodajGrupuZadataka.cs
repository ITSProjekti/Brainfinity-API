using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BrainfinityAPI.Data.Migrations
{
    public partial class DodajGrupuZadataka : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GrupaZadatakas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Razred = table.Column<string>(nullable: true),
                    NivoSkole = table.Column<string>(nullable: true),
                    TakmicenjeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GrupaZadatakas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GrupaZadatakas_Takmicenjes_TakmicenjeId",
                        column: x => x.TakmicenjeId,
                        principalTable: "Takmicenjes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_GrupaZadatakas_TakmicenjeId",
                table: "GrupaZadatakas",
                column: "TakmicenjeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GrupaZadatakas");
        }
    }
}
