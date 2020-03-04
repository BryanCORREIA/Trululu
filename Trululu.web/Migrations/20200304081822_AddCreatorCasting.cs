using Microsoft.EntityFrameworkCore.Migrations;

namespace Trululu.web.Migrations
{
    public partial class AddCreatorCasting : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CreatorId",
                table: "casting",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_casting_CreatorId",
                table: "casting",
                column: "CreatorId");

            migrationBuilder.AddForeignKey(
                name: "FK_casting_user_CreatorId",
                table: "casting",
                column: "CreatorId",
                principalTable: "user",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_casting_user_CreatorId",
                table: "casting");

            migrationBuilder.DropIndex(
                name: "IX_casting_CreatorId",
                table: "casting");

            migrationBuilder.DropColumn(
                name: "CreatorId",
                table: "casting");
        }
    }
}
