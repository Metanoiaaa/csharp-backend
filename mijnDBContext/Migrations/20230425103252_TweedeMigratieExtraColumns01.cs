using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace mijnDBContext.Migrations
{
    /// <inheritdoc />
    public partial class TweedeMigratieExtraColumns01 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "GebruikersNaam",
                table: "recepten",
                newName: "Gebruikersnaam");

            migrationBuilder.AddColumn<int>(
                name: "Rating",
                table: "recepten",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "Vegan",
                table: "recepten",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Rating",
                table: "recepten");

            migrationBuilder.DropColumn(
                name: "Vegan",
                table: "recepten");

            migrationBuilder.RenameColumn(
                name: "Gebruikersnaam",
                table: "recepten",
                newName: "GebruikersNaam");
        }
    }
}
