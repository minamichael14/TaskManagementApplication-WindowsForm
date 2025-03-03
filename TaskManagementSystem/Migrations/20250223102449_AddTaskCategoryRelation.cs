using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaskManagementSystem.Migrations
{
    /// <inheritdoc />
    public partial class AddTaskCategoryRelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CategoryID",
                table: "TaskItems",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_TaskItems_CategoryID",
                table: "TaskItems",
                column: "CategoryID");

            migrationBuilder.AddForeignKey(
                name: "FK_TaskItems_Categories_CategoryID",
                table: "TaskItems",
                column: "CategoryID",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TaskItems_Categories_CategoryID",
                table: "TaskItems");

            migrationBuilder.DropIndex(
                name: "IX_TaskItems_CategoryID",
                table: "TaskItems");

            migrationBuilder.DropColumn(
                name: "CategoryID",
                table: "TaskItems");
        }
    }
}
