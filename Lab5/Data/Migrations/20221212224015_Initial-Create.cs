using Microsoft.EntityFrameworkCore.Migrations;

namespace Lab5.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Skills_jobId",
                table: "Skills",
                column: "jobId");

            migrationBuilder.AddForeignKey(
                name: "FK_Skills_Jobs_jobId",
                table: "Skills",
                column: "jobId",
                principalTable: "Jobs",
                principalColumn: "JobId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Skills_Jobs_jobId",
                table: "Skills");

            migrationBuilder.DropIndex(
                name: "IX_Skills_jobId",
                table: "Skills");
        }
    }
}
