using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class mig2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_accounts_teams_TeamId",
                table: "accounts");

            migrationBuilder.DropForeignKey(
                name: "FK_projects_categories_CategoryId",
                table: "projects");

            migrationBuilder.DropIndex(
                name: "IX_accounts_TeamId",
                table: "accounts");

            migrationBuilder.DropColumn(
                name: "TeamId",
                table: "accounts");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "categories",
                newName: "CategoryId");

            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "projects",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TeamId",
                table: "projects",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "teamOfAccounts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccountId = table.Column<int>(type: "int", nullable: false),
                    TeamId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_teamOfAccounts", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_projects_TeamId",
                table: "projects",
                column: "TeamId");

            migrationBuilder.AddForeignKey(
                name: "FK_projects_categories_CategoryId",
                table: "projects",
                column: "CategoryId",
                principalTable: "categories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_projects_teams_TeamId",
                table: "projects",
                column: "TeamId",
                principalTable: "teams",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_projects_categories_CategoryId",
                table: "projects");

            migrationBuilder.DropForeignKey(
                name: "FK_projects_teams_TeamId",
                table: "projects");

            migrationBuilder.DropTable(
                name: "teamOfAccounts");

            migrationBuilder.DropIndex(
                name: "IX_projects_TeamId",
                table: "projects");

            migrationBuilder.DropColumn(
                name: "TeamId",
                table: "projects");

            migrationBuilder.RenameColumn(
                name: "CategoryId",
                table: "categories",
                newName: "Id");

            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "projects",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "TeamId",
                table: "accounts",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_accounts_TeamId",
                table: "accounts",
                column: "TeamId");

            migrationBuilder.AddForeignKey(
                name: "FK_accounts_teams_TeamId",
                table: "accounts",
                column: "TeamId",
                principalTable: "teams",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_projects_categories_CategoryId",
                table: "projects",
                column: "CategoryId",
                principalTable: "categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
