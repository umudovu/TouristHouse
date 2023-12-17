using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TouristHouse.Persistence.Context.Migrations
{
    public partial class mig2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_StatusAnnounces_AnnounceId",
                table: "StatusAnnounces");

            migrationBuilder.AddColumn<int>(
                name: "AnnounceStatusType",
                table: "Announces",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_StatusAnnounces_AnnounceId",
                table: "StatusAnnounces",
                column: "AnnounceId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_StatusAnnounces_AnnounceId",
                table: "StatusAnnounces");

            migrationBuilder.DropColumn(
                name: "AnnounceStatusType",
                table: "Announces");

            migrationBuilder.CreateIndex(
                name: "IX_StatusAnnounces_AnnounceId",
                table: "StatusAnnounces",
                column: "AnnounceId",
                unique: true,
                filter: "[AnnounceId] IS NOT NULL");
        }
    }
}
