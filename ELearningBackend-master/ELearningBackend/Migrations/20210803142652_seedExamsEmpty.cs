using Microsoft.EntityFrameworkCore.Migrations;

namespace ELearningBackend.Migrations
{
    public partial class seedExamsEmpty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT [dbo].[Exams] ( [Name], [CreatedAt], [CourseId]) VALUES ( N'امتحان المحاضرة الأولى ', CAST(N'2021-08-03T04:22:25.4033333' AS DateTime2), 1)");
            migrationBuilder.Sql("INSERT [dbo].[Exams] ( [Name], [CreatedAt], [CourseId]) VALUES ( N'امتحان المحاضرة الثانية', CAST(N'2021-08-03T04:22:47.6933333' AS DateTime2), 2)");
            migrationBuilder.Sql("INSERT [dbo].[Exams] ( [Name], [CreatedAt], [CourseId]) VALUES ( N'امتحان المحاضرة الثالثة', CAST(N'2021-08-03T04:23:04.0700000' AS DateTime2), 3)");
            migrationBuilder.Sql("INSERT [dbo].[Exams] ( [Name], [CreatedAt], [CourseId]) VALUES ( N'امتحان المحاضرة الرابعة', CAST(N'2021-08-03T04:23:29.2233333' AS DateTime2), 4)");
            migrationBuilder.Sql("INSERT [dbo].[Exams] ( [Name], [CreatedAt], [CourseId]) VALUES ( N'امتحان المحاضرة الخامسة', CAST(N'2021-08-03T04:23:36.9233333' AS DateTime2), 5)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
