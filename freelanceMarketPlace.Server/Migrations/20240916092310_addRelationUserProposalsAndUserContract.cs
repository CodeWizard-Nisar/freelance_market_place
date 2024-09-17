using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace freelanceMarketPlace.Server.Migrations
{
    /// <inheritdoc />
    public partial class addRelationUserProposalsAndUserContract : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Proposals",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Contracts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Proposals_UserId",
                table: "Proposals",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Contracts_UserId",
                table: "Contracts",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Contracts_Users_UserId",
                table: "Contracts",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Proposals_Users_UserId",
                table: "Proposals",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contracts_Users_UserId",
                table: "Contracts");

            migrationBuilder.DropForeignKey(
                name: "FK_Proposals_Users_UserId",
                table: "Proposals");

            migrationBuilder.DropIndex(
                name: "IX_Proposals_UserId",
                table: "Proposals");

            migrationBuilder.DropIndex(
                name: "IX_Contracts_UserId",
                table: "Contracts");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Proposals");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Contracts");
        }
    }
}
