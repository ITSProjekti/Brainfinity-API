using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BrainfinityAPI.Data.Migrations
{
    public partial class DodajZadatak : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Zadataks",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ZadatakNaziv = table.Column<string>(nullable: true),
                    Bodovi = table.Column<int>(nullable: false),
                    GrupaZadatakaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Zadataks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Zadataks_GrupaZadatakas_GrupaZadatakaId",
                        column: x => x.GrupaZadatakaId,
                        principalTable: "GrupaZadatakas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Zadataks_GrupaZadatakaId",
                table: "Zadataks",
                column: "GrupaZadatakaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Zadataks");
        }
    }
}
