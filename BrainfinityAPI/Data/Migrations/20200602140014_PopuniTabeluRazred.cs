using Microsoft.EntityFrameworkCore.Migrations;

namespace BrainfinityAPI.Data.Migrations
{
    public partial class PopuniTabeluRazred : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Razreds (RazredNaziv, NivoSkoleId) VALUES ('5. razred', 1)");
            migrationBuilder.Sql("INSERT INTO Razreds (RazredNaziv, NivoSkoleId) VALUES ('6. razred', 1)");
            migrationBuilder.Sql("INSERT INTO Razreds (RazredNaziv, NivoSkoleId) VALUES ('7. razred', 1)");
            migrationBuilder.Sql("INSERT INTO Razreds (RazredNaziv, NivoSkoleId) VALUES ('8. razred', 1)");
            migrationBuilder.Sql("INSERT INTO Razreds (RazredNaziv, NivoSkoleId) VALUES ('1. razred', 2)");
            migrationBuilder.Sql("INSERT INTO Razreds (RazredNaziv, NivoSkoleId) VALUES ('2. razred', 2)");
            migrationBuilder.Sql("INSERT INTO Razreds (RazredNaziv, NivoSkoleId) VALUES ('3. razred', 2)");
            migrationBuilder.Sql("INSERT INTO Razreds (RazredNaziv, NivoSkoleId) VALUES ('4. razred', 2)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
        }
    }
}