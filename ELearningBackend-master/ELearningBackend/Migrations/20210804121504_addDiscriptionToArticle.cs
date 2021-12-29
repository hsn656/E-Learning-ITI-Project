using Microsoft.EntityFrameworkCore.Migrations;

namespace ELearningBackend.Migrations
{
    public partial class addDiscriptionToArticle : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Discription",
                table: "Lesson",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Discription",
                table: "Lesson");
        }
    }
}
