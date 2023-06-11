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
                    TypeCD = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressObjectCode = table.Column<int>(type: "int", nullable: false),
                    AddressObjectTypeCode = table.Column<int>(type: "int", nullable: false),
                    AddressObjectDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CentroidXCoordinate = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CentroidYCoordinate = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CentroidDDECoordinate = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CentroidDDNCoordinate = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
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
