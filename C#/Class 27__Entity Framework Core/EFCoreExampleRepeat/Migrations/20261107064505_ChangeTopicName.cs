using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreExampleRepeat.Migrations
{
    /// <inheritdoc />
    public partial class ChangeTopicName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tables_Courses_CourseId",
                table: "Tables");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tables",
                table: "Tables");

            migrationBuilder.RenameTable(
                name: "Tables",
                newName: "Topics");

            migrationBuilder.RenameIndex(
                name: "IX_Tables_CourseId",
                table: "Topics",
                newName: "IX_Topics_CourseId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Topics",
                table: "Topics",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Topics_Courses_CourseId",
                table: "Topics",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Topics_Courses_CourseId",
                table: "Topics");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Topics",
                table: "Topics");

            migrationBuilder.RenameTable(
                name: "Topics",
                newName: "Tables");

            migrationBuilder.RenameIndex(
                name: "IX_Topics_CourseId",
                table: "Tables",
                newName: "IX_Tables_CourseId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tables",
                table: "Tables",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Tables_Courses_CourseId",
                table: "Tables",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
