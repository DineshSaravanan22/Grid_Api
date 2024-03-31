using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Angular_Grid_Api_Task2022.Migrations
{
    /// <inheritdoc />
    public partial class lastmitration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AgGrids",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Yard = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LinerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReferenceNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BookingDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BookingValidity = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ReleaceTo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VesselCarrier = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VesselName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VoyageNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ArrivalDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DepartureDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LoadingPort = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DischargePort = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Distination = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OutContract = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BLNumber = table.Column<int>(type: "int", nullable: false),
                    Remarks = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AgGrids", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AgGrids");
        }
    }
}
