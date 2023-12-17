using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TouristHouse.Persistence.Context.Migrations
{
    public partial class mig1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Announces_StatusAnnounces_StatusId",
                table: "Announces");

            migrationBuilder.DropIndex(
                name: "IX_Announces_StatusId",
                table: "Announces");

            migrationBuilder.DropColumn(
                name: "StatusId",
                table: "Announces");

            migrationBuilder.AddColumn<string>(
                name: "AnnounceId",
                table: "StatusAnnounces",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_StatusAnnounces_AnnounceId",
                table: "StatusAnnounces",
                column: "AnnounceId",
                unique: true,
                filter: "[AnnounceId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_StatusAnnounces_Announces_AnnounceId",
                table: "StatusAnnounces",
                column: "AnnounceId",
                principalTable: "Announces",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StatusAnnounces_Announces_AnnounceId",
                table: "StatusAnnounces");

            migrationBuilder.DropIndex(
                name: "IX_StatusAnnounces_AnnounceId",
                table: "StatusAnnounces");

            migrationBuilder.DropColumn(
                name: "AnnounceId",
                table: "StatusAnnounces");

            migrationBuilder.AddColumn<string>(
                name: "StatusId",
                table: "Announces",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Announces_StatusId",
                table: "Announces",
                column: "StatusId");

            migrationBuilder.AddForeignKey(
                name: "FK_Announces_StatusAnnounces_StatusId",
                table: "Announces",
                column: "StatusId",
                principalTable: "StatusAnnounces",
                principalColumn: "Id");
        }
    }
}
