using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Teste.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class correctscansids : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Report_Scan_scansId",
                table: "Report");

            migrationBuilder.AlterColumn<string>(
                name: "scan_id",
                table: "Scan",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "scan_id",
                table: "Report",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddUniqueConstraint(
                name: "AK_Scan_scan_id",
                table: "Scan",
                column: "scan_id");

            migrationBuilder.CreateIndex(
                name: "IX_Report_scan_id",
                table: "Report",
                column: "scan_id",
                unique: true,
                filter: "[scan_id] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Report_Scan_scan_id",
                table: "Report",
                column: "scan_id",
                principalTable: "Scan",
                principalColumn: "scan_id");

            migrationBuilder.AddForeignKey(
                name: "FK_Report_Scans_scansId",
                table: "Report",
                column: "scansId",
                principalTable: "Scans",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Report_Scan_scan_id",
                table: "Report");

            migrationBuilder.DropForeignKey(
                name: "FK_Report_Scans_scansId",
                table: "Report");

            migrationBuilder.DropUniqueConstraint(
                name: "AK_Scan_scan_id",
                table: "Scan");

            migrationBuilder.DropIndex(
                name: "IX_Report_scan_id",
                table: "Report");

            migrationBuilder.AlterColumn<string>(
                name: "scan_id",
                table: "Scan",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "scan_id",
                table: "Report",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Report_Scan_scansId",
                table: "Report",
                column: "scansId",
                principalTable: "Scan",
                principalColumn: "Id");
        }
    }
}
