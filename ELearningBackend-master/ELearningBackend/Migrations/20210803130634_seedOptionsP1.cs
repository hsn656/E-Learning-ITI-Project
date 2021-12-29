using Microsoft.EntityFrameworkCore.Migrations;

namespace ELearningBackend.Migrations
{
    public partial class seedOptionsP1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT [dbo].[Options] ( [Content], [IsCorrect], [QuestionId]) VALUES ( N'مبتدأ', 1, 1)");
            migrationBuilder.Sql("INSERT [dbo].[Options] ( [Content], [IsCorrect], [QuestionId]) VALUES ( N'بدل', 0, 1)");
            migrationBuilder.Sql("INSERT [dbo].[Options] ( [Content], [IsCorrect], [QuestionId]) VALUES ( N'فاعل', 0, 1)");
            migrationBuilder.Sql("INSERT [dbo].[Options] ( [Content], [IsCorrect], [QuestionId]) VALUES ( N'مضاف إليه', 0, 1)");
            migrationBuilder.Sql("INSERT [dbo].[Options] ( [Content], [IsCorrect], [QuestionId]) VALUES ( N'مبتدأ', 1, 2)");
            migrationBuilder.Sql("INSERT [dbo].[Options] ( [Content], [IsCorrect], [QuestionId]) VALUES ( N'مضاف إليه', 0, 2)");
            migrationBuilder.Sql("INSERT [dbo].[Options] ( [Content], [IsCorrect], [QuestionId]) VALUES ( N'نعت', 0, 2)");
            migrationBuilder.Sql("INSERT [dbo].[Options] ( [Content], [IsCorrect], [QuestionId]) VALUES ( N'خبر', 0, 2)");
            migrationBuilder.Sql("INSERT [dbo].[Options] ( [Content], [IsCorrect], [QuestionId]) VALUES ( N'مفعول به', 0, 3)");
            migrationBuilder.Sql("INSERT [dbo].[Options] ( [Content], [IsCorrect], [QuestionId]) VALUES ( N'مبتدأ', 0, 3)");
            migrationBuilder.Sql("INSERT [dbo].[Options] ( [Content], [IsCorrect], [QuestionId]) VALUES ( N'خبر', 1, 3)");
            migrationBuilder.Sql("INSERT [dbo].[Options] ( [Content], [IsCorrect], [QuestionId]) VALUES ( N'فاعل', 0, 3)");
            migrationBuilder.Sql("INSERT [dbo].[Options] ( [Content], [IsCorrect], [QuestionId]) VALUES ( N'مضاف إليه', 0, 4)");
            migrationBuilder.Sql("INSERT [dbo].[Options] ( [Content], [IsCorrect], [QuestionId]) VALUES ( N'مبتدأ مؤخر', 1, 4)");
            migrationBuilder.Sql("INSERT [dbo].[Options] ( [Content], [IsCorrect], [QuestionId]) VALUES ( N'خبر', 0, 4)");
            migrationBuilder.Sql("INSERT [dbo].[Options] ( [Content], [IsCorrect], [QuestionId]) VALUES ( N'مبتدأ', 1, 5)");
            migrationBuilder.Sql("INSERT [dbo].[Options] ( [Content], [IsCorrect], [QuestionId]) VALUES ( N'خبر', 0, 5)");
            migrationBuilder.Sql("INSERT [dbo].[Options] ( [Content], [IsCorrect], [QuestionId]) VALUES ( N'فاعل', 0, 5)");
            migrationBuilder.Sql("INSERT [dbo].[Options] ( [Content], [IsCorrect], [QuestionId]) VALUES ( N'مضاف إليه', 0, 5)");
            migrationBuilder.Sql("INSERT [dbo].[Options] ( [Content], [IsCorrect], [QuestionId]) VALUES ( N'ضرورية', 0, 6)");
            migrationBuilder.Sql("INSERT [dbo].[Options] ( [Content], [IsCorrect], [QuestionId]) VALUES ( N'مهمة', 0, 6)");
            migrationBuilder.Sql("INSERT [dbo].[Options] ( [Content], [IsCorrect], [QuestionId]) VALUES ( N'موجودة', 1, 6)");
            migrationBuilder.Sql("INSERT [dbo].[Options] ( [Content], [IsCorrect], [QuestionId]) VALUES ( N'متعبة', 0, 6)");
            migrationBuilder.Sql("INSERT [dbo].[Options] ( [Content], [IsCorrect], [QuestionId]) VALUES ( N'واجب', 0, 7)");
            migrationBuilder.Sql("INSERT [dbo].[Options] ( [Content], [IsCorrect], [QuestionId]) VALUES ( N'جائز', 1, 7)");
            migrationBuilder.Sql("INSERT [dbo].[Options] ( [Content], [IsCorrect], [QuestionId]) VALUES ( N'واجب', 1, 8)");
            migrationBuilder.Sql("INSERT [dbo].[Options] ( [Content], [IsCorrect], [QuestionId]) VALUES ( N'جائز', 0, 8)");
            migrationBuilder.Sql("INSERT [dbo].[Options] ( [Content], [IsCorrect], [QuestionId]) VALUES ( N'فاعل', 0, 9)");
            migrationBuilder.Sql("INSERT [dbo].[Options] ( [Content], [IsCorrect], [QuestionId]) VALUES ( N'مبتدأ ثان', 0, 9)");
            migrationBuilder.Sql("INSERT [dbo].[Options] ( [Content], [IsCorrect], [QuestionId]) VALUES ( N'بدل', 0, 9)");
            migrationBuilder.Sql("INSERT [dbo].[Options] ( [Content], [IsCorrect], [QuestionId]) VALUES ( N'نائب فاعل', 1, 9)");
            migrationBuilder.Sql("INSERT [dbo].[Options] ( [Content], [IsCorrect], [QuestionId]) VALUES ( N'فاعل', 0, 10)");
            migrationBuilder.Sql("INSERT [dbo].[Options] ( [Content], [IsCorrect], [QuestionId]) VALUES ( N'بدل', 0, 10)");
            migrationBuilder.Sql("INSERT [dbo].[Options] ( [Content], [IsCorrect], [QuestionId]) VALUES ( N'مبتدأ', 1, 10)");
            migrationBuilder.Sql("INSERT [dbo].[Options] ( [Content], [IsCorrect], [QuestionId]) VALUES ( N'نعت', 0, 10)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
