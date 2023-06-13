using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVC_leaflet.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Places",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<int>(type: "int", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LocationCode = table.Column<int>(type: "int", nullable: false),
                    LocationType = table.Column<int>(type: "int", nullable: false),
                    GeoAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Long = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Lat = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DDE = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DDN = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Places", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Places");
        }
    }
}
