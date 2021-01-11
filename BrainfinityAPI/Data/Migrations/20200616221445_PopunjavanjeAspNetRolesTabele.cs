using Microsoft.EntityFrameworkCore.Migrations;

namespace BrainfinityAPI.Data.Migrations
{
    public partial class PopunjavanjeAspNetRolesTabele : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO aspNetRoles (Id, Name, NormalizedName) VALUES (1,'Supervizor', 'SUPERVIZOR')");
            migrationBuilder.Sql("INSERT INTO aspNetRoles (Id, Name, NormalizedName) VALUES (2,'Pregledac', 'PREGLEDAC')");
            migrationBuilder.Sql("INSERT INTO aspNetRoles (Id, Name, NormalizedName) VALUES (3,'Glavni pregledac', 'GLAVNIPREGLEDAC')");
            migrationBuilder.Sql("INSERT INTO aspNetRoles (Id, Name, NormalizedName) VALUES (4,'Tim', 'TIM')");
            migrationBuilder.Sql("INSERT INTO aspNetRoles (Id, Name, NormalizedName) VALUES (5,'Dizajner', 'DIZAJNER')");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUserTokens",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserTokens",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 128);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUserTokens",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserTokens",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string));
        }
    }
}