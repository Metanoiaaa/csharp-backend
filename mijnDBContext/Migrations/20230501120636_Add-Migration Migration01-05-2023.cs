using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace mijnDBContext.Migrations
{
    /// <inheritdoc />
    public partial class AddMigrationMigration01052023 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DateEdited",
                table: "Recepten",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateEdited",
                table: "Recepten");
        }
    }
}
