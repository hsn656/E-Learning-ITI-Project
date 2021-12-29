using Microsoft.EntityFrameworkCore.Migrations;

namespace ELearningBackend.Migrations
{
    public partial class seedTopicsP1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT [dbo].[Topics] ( [Title], [YearNo], [UnitNo], [LessonNo]) VALUES ( N'المبتدأ والخبر', 3, 2, 1)");
            migrationBuilder.Sql("INSERT [dbo].[Topics] ( [Title], [YearNo], [UnitNo], [LessonNo]) VALUES ( N'حكم تأخير المبتدأ', 3, 2, 2)");
            migrationBuilder.Sql("INSERT [dbo].[Topics] ( [Title], [YearNo], [UnitNo], [LessonNo]) VALUES ( N'حالات حذف المبتدأ والخبر', 3, 2, 3)");
            migrationBuilder.Sql("INSERT [dbo].[Topics] ( [Title], [YearNo], [UnitNo], [LessonNo]) VALUES ( N'إعمال المشتقات', 1, 2, 1)");
            migrationBuilder.Sql("INSERT [dbo].[Topics] ( [Title], [YearNo], [UnitNo], [LessonNo]) VALUES ( N'إعمال اسم الفاعل', 1, 2, 2)");
            migrationBuilder.Sql("INSERT [dbo].[Topics] ( [Title], [YearNo], [UnitNo], [LessonNo]) VALUES ( N'إعمال اسم المفعول', 1, 2, 3)");
            migrationBuilder.Sql("INSERT [dbo].[Topics] ( [Title], [YearNo], [UnitNo], [LessonNo]) VALUES ( N'إعمال صيغة المبالغة', 1, 2, 4)");
            migrationBuilder.Sql("INSERT [dbo].[Topics] ( [Title], [YearNo], [UnitNo], [LessonNo]) VALUES ( N'الممنوع من الصرف', 3, 6, 1)");
            migrationBuilder.Sql("INSERT [dbo].[Topics] ( [Title], [YearNo], [UnitNo], [LessonNo]) VALUES ( N'المصدر المؤول', 2, 4, 1)");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
