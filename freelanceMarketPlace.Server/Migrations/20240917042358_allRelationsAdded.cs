using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace freelanceMarketPlace.Server.Migrations
{
    /// <inheritdoc />
    public partial class allRelationsAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AdminId",
                table: "Users",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Users",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ContractId",
                table: "Transactions",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ReviewedByAdminId",
                table: "Transactions",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Skills",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ContractId",
                table: "Reviews",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProjectId",
                table: "Reviews",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TransactionId",
                table: "Reviews",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ApprovedByAdminId",
                table: "Projects",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ContractId",
                table: "Payments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ProjectId",
                table: "Payments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ManagedByAdminId",
                table: "Categories",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_AdminId",
                table: "Users",
                column: "AdminId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_CategoryId",
                table: "Users",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_ContractId",
                table: "Transactions",
                column: "ContractId");

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_ReviewedByAdminId",
                table: "Transactions",
                column: "ReviewedByAdminId");

            migrationBuilder.CreateIndex(
                name: "IX_Skills_CategoryId",
                table: "Skills",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_ContractId",
                table: "Reviews",
                column: "ContractId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_ProjectId",
                table: "Reviews",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_TransactionId",
                table: "Reviews",
                column: "TransactionId",
                unique: true,
                filter: "[TransactionId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Projects_ApprovedByAdminId",
                table: "Projects",
                column: "ApprovedByAdminId");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_ContractId",
                table: "Payments",
                column: "ContractId");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_ProjectId",
                table: "Payments",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Categories_ManagedByAdminId",
                table: "Categories",
                column: "ManagedByAdminId");

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_Admins_ManagedByAdminId",
                table: "Categories",
                column: "ManagedByAdminId",
                principalTable: "Admins",
                principalColumn: "AdminId");

            migrationBuilder.AddForeignKey(
                name: "FK_Payments_Contracts_ContractId",
                table: "Payments",
                column: "ContractId",
                principalTable: "Contracts",
                principalColumn: "ContractId");

            migrationBuilder.AddForeignKey(
                name: "FK_Payments_Projects_ProjectId",
                table: "Payments",
                column: "ProjectId",
                principalTable: "Projects",
                principalColumn: "ProjectId");

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_Admins_ApprovedByAdminId",
                table: "Projects",
                column: "ApprovedByAdminId",
                principalTable: "Admins",
                principalColumn: "AdminId");

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_Contracts_ContractId",
                table: "Reviews",
                column: "ContractId",
                principalTable: "Contracts",
                principalColumn: "ContractId");

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_Projects_ProjectId",
                table: "Reviews",
                column: "ProjectId",
                principalTable: "Projects",
                principalColumn: "ProjectId");

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_Transactions_TransactionId",
                table: "Reviews",
                column: "TransactionId",
                principalTable: "Transactions",
                principalColumn: "TransactionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Skills_Categories_CategoryId",
                table: "Skills",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_Transactions_Admins_ReviewedByAdminId",
                table: "Transactions",
                column: "ReviewedByAdminId",
                principalTable: "Admins",
                principalColumn: "AdminId");

            migrationBuilder.AddForeignKey(
                name: "FK_Transactions_Contracts_ContractId",
                table: "Transactions",
                column: "ContractId",
                principalTable: "Contracts",
                principalColumn: "ContractId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Admins_AdminId",
                table: "Users",
                column: "AdminId",
                principalTable: "Admins",
                principalColumn: "AdminId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Categories_CategoryId",
                table: "Users",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.SetNull);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categories_Admins_ManagedByAdminId",
                table: "Categories");

            migrationBuilder.DropForeignKey(
                name: "FK_Payments_Contracts_ContractId",
                table: "Payments");

            migrationBuilder.DropForeignKey(
                name: "FK_Payments_Projects_ProjectId",
                table: "Payments");

            migrationBuilder.DropForeignKey(
                name: "FK_Projects_Admins_ApprovedByAdminId",
                table: "Projects");

            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_Contracts_ContractId",
                table: "Reviews");

            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_Projects_ProjectId",
                table: "Reviews");

            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_Transactions_TransactionId",
                table: "Reviews");

            migrationBuilder.DropForeignKey(
                name: "FK_Skills_Categories_CategoryId",
                table: "Skills");

            migrationBuilder.DropForeignKey(
                name: "FK_Transactions_Admins_ReviewedByAdminId",
                table: "Transactions");

            migrationBuilder.DropForeignKey(
                name: "FK_Transactions_Contracts_ContractId",
                table: "Transactions");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Admins_AdminId",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Categories_CategoryId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_AdminId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_CategoryId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Transactions_ContractId",
                table: "Transactions");

            migrationBuilder.DropIndex(
                name: "IX_Transactions_ReviewedByAdminId",
                table: "Transactions");

            migrationBuilder.DropIndex(
                name: "IX_Skills_CategoryId",
                table: "Skills");

            migrationBuilder.DropIndex(
                name: "IX_Reviews_ContractId",
                table: "Reviews");

            migrationBuilder.DropIndex(
                name: "IX_Reviews_ProjectId",
                table: "Reviews");

            migrationBuilder.DropIndex(
                name: "IX_Reviews_TransactionId",
                table: "Reviews");

            migrationBuilder.DropIndex(
                name: "IX_Projects_ApprovedByAdminId",
                table: "Projects");

            migrationBuilder.DropIndex(
                name: "IX_Payments_ContractId",
                table: "Payments");

            migrationBuilder.DropIndex(
                name: "IX_Payments_ProjectId",
                table: "Payments");

            migrationBuilder.DropIndex(
                name: "IX_Categories_ManagedByAdminId",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "AdminId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "ContractId",
                table: "Transactions");

            migrationBuilder.DropColumn(
                name: "ReviewedByAdminId",
                table: "Transactions");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "ContractId",
                table: "Reviews");

            migrationBuilder.DropColumn(
                name: "ProjectId",
                table: "Reviews");

            migrationBuilder.DropColumn(
                name: "TransactionId",
                table: "Reviews");

            migrationBuilder.DropColumn(
                name: "ApprovedByAdminId",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "ContractId",
                table: "Payments");

            migrationBuilder.DropColumn(
                name: "ProjectId",
                table: "Payments");

            migrationBuilder.DropColumn(
                name: "ManagedByAdminId",
                table: "Categories");
        }
    }
}
