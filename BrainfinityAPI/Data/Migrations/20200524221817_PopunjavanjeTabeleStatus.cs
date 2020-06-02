using Microsoft.EntityFrameworkCore.Migrations;

namespace BrainfinityAPI.Data.Migrations
{
    public partial class PopunjavanjeTabeleStatus : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO statuses (nazivStatusa) VALUES ('Arhivirano')");
            migrationBuilder.Sql("INSERT INTO statuses (nazivStatusa) VALUES ('Aktivno')");
            migrationBuilder.Sql("INSERT INTO statuses (nazivStatusa) VALUES ('Nastupajuce')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
        }
    }
}