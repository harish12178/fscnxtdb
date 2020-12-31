using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace TruckTracking.API.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            

            migrationBuilder.CreateTable(
                name: "Trans_H",
                columns: table => new
                {
                    TransID = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Type = table.Column<string>(nullable: true),
                    TransporterID = table.Column<string>(nullable: true),
                    PartnerID = table.Column<string>(nullable: true),
                    RecordDate = table.Column<DateTime>(nullable: false),
                    OTP = table.Column<string>(nullable: true),
                    FromAddress = table.Column<string>(nullable: true),
                    ToAddress = table.Column<string>(nullable: true),
                    FromPlant = table.Column<string>(nullable: true),
                    ToPlant = table.Column<string>(nullable: true),
                    MaterialGroup = table.Column<string>(nullable: true),
                    Truck = table.Column<string>(nullable: true),
                    Driver = table.Column<string>(nullable: true),
                    Helper = table.Column<string>(nullable: true),
                    TruckType = table.Column<string>(nullable: true),
                    ContactNumber1 = table.Column<string>(nullable: true),
                    ContactNumber2 = table.Column<string>(nullable: true),
                    TripStartDate = table.Column<DateTime>(nullable: false),
                    TripStartLoc = table.Column<string>(nullable: true),
                    DeviceID = table.Column<string>(nullable: true),
                    LastReportedDateTime = table.Column<DateTime>(nullable: false),
                    LastReportedLocation = table.Column<string>(nullable: true),
                    TripEndDate = table.Column<DateTime>(nullable: false),
                    TripEndLoc = table.Column<string>(nullable: true),
                    isExceptionOccured = table.Column<string>(nullable: true),
                    PoDRefDoc = table.Column<string>(nullable: true),
                    Status = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trans_H", x => x.TransID);
                    table.ForeignKey(
                        name: "FK_Trans_H_m_device_DeviceID",
                        column: x => x.DeviceID,
                        principalTable: "m_device",
                        principalColumn: "DeviceID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Trans_I",
                columns: table => new
                {
                    TransID = table.Column<int>(nullable: false),
                    RefDoc = table.Column<string>(nullable: false),
                    Item = table.Column<string>(nullable: true),
                    Material = table.Column<string>(nullable: true),
                    MaterialGroup = table.Column<string>(nullable: true),
                    Quantity = table.Column<int>(nullable: false),
                    uOM = table.Column<string>(nullable: true),
                    Value = table.Column<int>(nullable: false),
                    Currency = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trans_I", x => new { x.TransID, x.RefDoc });
                    table.ForeignKey(
                        name: "FK_Trans_I_Trans_H_TransID",
                        column: x => x.TransID,
                        principalTable: "Trans_H",
                        principalColumn: "TransID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Trans_Loc",
                columns: table => new
                {
                    TransID = table.Column<int>(nullable: false),
                    SINo = table.Column<int>(nullable: false),
                    DateTime = table.Column<DateTime>(nullable: false),
                    GeoLoc = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trans_Loc", x => new { x.TransID, x.SINo });
                    table.ForeignKey(
                        name: "FK_Trans_Loc_Trans_H_TransID",
                        column: x => x.TransID,
                        principalTable: "Trans_H",
                        principalColumn: "TransID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Trans_H_DeviceID",
                table: "Trans_H",
                column: "DeviceID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Trans_I");

            migrationBuilder.DropTable(
                name: "Trans_Loc");

            migrationBuilder.DropTable(
                name: "Trans_H");

            migrationBuilder.DropTable(
                name: "m_device");
        }
    }
}
