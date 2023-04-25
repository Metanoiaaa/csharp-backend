using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace mijnDBContext.Migrations
{
    /// <inheritdoc />
    public partial class EersteMigrationCSharpBackend : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Recepten",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReceptName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UploaderName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsVegan = table.Column<bool>(type: "bit", nullable: false),
                    Rating = table.Column<int>(type: "int", nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recepten", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Recepten");
        }
    }
}
