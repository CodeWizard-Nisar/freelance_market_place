using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace freelanceMarketPlace.Server.Migrations
{
    /// <inheritdoc />
    public partial class addRelations2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProjectId",
                table: "Contracts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Contracts_ProjectId",
                table: "Contracts",
                column: "ProjectId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Contracts_Projects_ProjectId",
                table: "Contracts",
                column: "ProjectId",
                principalTable: "Projects",
                principalColumn: "ProjectId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contracts_Projects_ProjectId",
                table: "Contracts");

            migrationBuilder.DropIndex(
                name: "IX_Contracts_ProjectId",
                table: "Contracts");

            migrationBuilder.DropColumn(
                name: "ProjectId",
                table: "Contracts");
        }
    }
}
