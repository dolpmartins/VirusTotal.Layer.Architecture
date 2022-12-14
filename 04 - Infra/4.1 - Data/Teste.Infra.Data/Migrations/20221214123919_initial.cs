using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Teste.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CATQuickHeal",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    detected = table.Column<bool>(type: "bit", nullable: false),
                    version = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    result = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    update = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CATQuickHeal", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "McAfee",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    detected = table.Column<bool>(type: "bit", nullable: false),
                    version = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    result = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    update = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_McAfee", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NProtect",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    detected = table.Column<bool>(type: "bit", nullable: false),
                    version = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    result = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    update = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NProtect", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Scan",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    scanid = table.Column<string>(name: "scan_id", type: "nvarchar(max)", nullable: true),
                    sha1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    resource = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    responsecode = table.Column<int>(name: "response_code", type: "int", nullable: false),
                    sha256 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    permalink = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    md5 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VerboverbosemsgseMsg = table.Column<string>(name: "Verboverbose_msgseMsg", type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Scan", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TheHacker",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    detected = table.Column<bool>(type: "bit", nullable: false),
                    version = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    result = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    update = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TheHacker", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VirusBuster",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    detected = table.Column<bool>(type: "bit", nullable: false),
                    version = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    result = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    update = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VirusBuster", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Report",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    responsecode = table.Column<int>(name: "response_code", type: "int", nullable: false),
                    verbosemsg = table.Column<string>(name: "verbose_msg", type: "nvarchar(max)", nullable: true),
                    resource = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    scanid = table.Column<string>(name: "scan_id", type: "nvarchar(max)", nullable: true),
                    md5 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    sha1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    sha256 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    scandate = table.Column<string>(name: "scan_date", type: "nvarchar(max)", nullable: true),
                    permalink = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    positives = table.Column<int>(type: "int", nullable: false),
                    total = table.Column<int>(type: "int", nullable: false),
                    scansId = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Report", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Report_Scan_scansId",
                        column: x => x.scansId,
                        principalTable: "Scan",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Scans",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nProtectId = table.Column<int>(type: "int", nullable: true),
                    CATQuickHealId = table.Column<int>(type: "int", nullable: true),
                    McAfeeId = table.Column<int>(type: "int", nullable: true),
                    TheHackerId = table.Column<int>(type: "int", nullable: true),
                    VirusBusterId = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Scans", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Scans_CATQuickHeal_CATQuickHealId",
                        column: x => x.CATQuickHealId,
                        principalTable: "CATQuickHeal",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Scans_McAfee_McAfeeId",
                        column: x => x.McAfeeId,
                        principalTable: "McAfee",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Scans_NProtect_nProtectId",
                        column: x => x.nProtectId,
                        principalTable: "NProtect",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Scans_TheHacker_TheHackerId",
                        column: x => x.TheHackerId,
                        principalTable: "TheHacker",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Scans_VirusBuster_VirusBusterId",
                        column: x => x.VirusBusterId,
                        principalTable: "VirusBuster",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Report_scansId",
                table: "Report",
                column: "scansId");

            migrationBuilder.CreateIndex(
                name: "IX_Scans_CATQuickHealId",
                table: "Scans",
                column: "CATQuickHealId");

            migrationBuilder.CreateIndex(
                name: "IX_Scans_McAfeeId",
                table: "Scans",
                column: "McAfeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Scans_nProtectId",
                table: "Scans",
                column: "nProtectId");

            migrationBuilder.CreateIndex(
                name: "IX_Scans_TheHackerId",
                table: "Scans",
                column: "TheHackerId");

            migrationBuilder.CreateIndex(
                name: "IX_Scans_VirusBusterId",
                table: "Scans",
                column: "VirusBusterId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Report");

            migrationBuilder.DropTable(
                name: "Scans");

            migrationBuilder.DropTable(
                name: "Scan");

            migrationBuilder.DropTable(
                name: "CATQuickHeal");

            migrationBuilder.DropTable(
                name: "McAfee");

            migrationBuilder.DropTable(
                name: "NProtect");

            migrationBuilder.DropTable(
                name: "TheHacker");

            migrationBuilder.DropTable(
                name: "VirusBuster");
        }
    }
}
