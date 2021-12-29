using Microsoft.EntityFrameworkCore.Migrations;

namespace ELearningBackend.Migrations
{
    public partial class seedExam2And1Full : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT [dbo].[ExamQuestion] ([ExamsId], [QuestionsId]) VALUES (1, 1)");
            migrationBuilder.Sql("INSERT [dbo].[ExamQuestion] ([ExamsId], [QuestionsId]) VALUES (2, 1)");
            migrationBuilder.Sql("INSERT [dbo].[ExamQuestion] ([ExamsId], [QuestionsId]) VALUES (1, 2)");
            migrationBuilder.Sql("INSERT [dbo].[ExamQuestion] ([ExamsId], [QuestionsId]) VALUES (2, 2)");
            migrationBuilder.Sql("INSERT [dbo].[ExamQuestion] ([ExamsId], [QuestionsId]) VALUES (1, 3)");
            migrationBuilder.Sql("INSERT [dbo].[ExamQuestion] ([ExamsId], [QuestionsId]) VALUES (2, 3)");
            migrationBuilder.Sql("INSERT [dbo].[ExamQuestion] ([ExamsId], [QuestionsId]) VALUES (1, 4)");
            migrationBuilder.Sql("INSERT [dbo].[ExamQuestion] ([ExamsId], [QuestionsId]) VALUES (2, 4)");
            migrationBuilder.Sql("INSERT [dbo].[ExamQuestion] ([ExamsId], [QuestionsId]) VALUES (1, 5)");
            migrationBuilder.Sql("INSERT [dbo].[ExamQuestion] ([ExamsId], [QuestionsId]) VALUES (2, 5)");
            migrationBuilder.Sql("INSERT [dbo].[ExamQuestion] ([ExamsId], [QuestionsId]) VALUES (1, 6)");
            migrationBuilder.Sql("INSERT [dbo].[ExamQuestion] ([ExamsId], [QuestionsId]) VALUES (2, 6)");
            migrationBuilder.Sql("INSERT [dbo].[ExamQuestion] ([ExamsId], [QuestionsId]) VALUES (1, 7)");
            migrationBuilder.Sql("INSERT [dbo].[ExamQuestion] ([ExamsId], [QuestionsId]) VALUES (2, 7)");
            migrationBuilder.Sql("INSERT [dbo].[ExamQuestion] ([ExamsId], [QuestionsId]) VALUES (1, 8)");
            migrationBuilder.Sql("INSERT [dbo].[ExamQuestion] ([ExamsId], [QuestionsId]) VALUES (2, 8)");
            migrationBuilder.Sql("INSERT [dbo].[ExamQuestion] ([ExamsId], [QuestionsId]) VALUES (1, 9)");
            migrationBuilder.Sql("INSERT [dbo].[ExamQuestion] ([ExamsId], [QuestionsId]) VALUES (2, 9)");
            migrationBuilder.Sql("INSERT [dbo].[ExamQuestion] ([ExamsId], [QuestionsId]) VALUES (1, 10)");
            migrationBuilder.Sql("INSERT [dbo].[ExamQuestion] ([ExamsId], [QuestionsId]) VALUES (2, 10)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
