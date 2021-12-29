using Microsoft.EntityFrameworkCore.Migrations;

namespace ELearningBackend.Migrations
{
    public partial class seedLessonsP1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT [dbo].[Lesson] ( [Title], [Image], [CreatedAt], [Discriminator], [Content], [Link], [Order], [CourseId]) VALUES ( N'إعمال اسم الفاعل', N'8QZ-TNuGNg8', CAST(N'2021-08-03T02:15:41.2566667' AS DateTime2), N'Video', NULL, N'8QZ-TNuGNg8', 4, 1)");
            migrationBuilder.Sql("INSERT [dbo].[Lesson] ( [Title], [Image], [CreatedAt], [Discriminator], [Content], [Link], [Order], [CourseId]) VALUES ( N'إعمال صيغة المبالغة وبعض التعليقات', N'ilX7zBAWpeM', CAST(N'2021-08-03T02:16:37.3633333' AS DateTime2), N'Video', NULL, N'ilX7zBAWpeM', 5, 1)");
            migrationBuilder.Sql("INSERT [dbo].[Lesson] ( [Title], [Image], [CreatedAt], [Discriminator], [Content], [Link], [Order], [CourseId]) VALUES ( N'إعمال اسم المفعول', N'-LZWWMSu2SM', CAST(N'2021-08-03T02:17:22.4466667' AS DateTime2), N'Video', NULL, N'-LZWWMSu2SM', 6, 1)");
            migrationBuilder.Sql("INSERT [dbo].[Lesson] ( [Title], [Image], [CreatedAt], [Discriminator], [Content], [Link], [Order], [CourseId]) VALUES ( N'الفرق بين الفاعل والمفعول', N'_3v8ZNvjN2Y', CAST(N'2021-08-03T02:18:27.1100000' AS DateTime2), N'Video', NULL, N'_3v8ZNvjN2Y', 7, 1)");
            migrationBuilder.Sql("INSERT [dbo].[Lesson] ( [Title], [Image], [CreatedAt], [Discriminator], [Content], [Link], [Order], [CourseId]) VALUES ( N'المبتدأ والخبر (الجزء الأول)', N'bRfILfOrNvk', CAST(N'2021-08-03T02:19:32.0700000' AS DateTime2), N'Video', NULL, N'bRfILfOrNvk', 1, 2)");
            migrationBuilder.Sql("INSERT [dbo].[Lesson] ( [Title], [Image], [CreatedAt], [Discriminator], [Content], [Link], [Order], [CourseId]) VALUES ( N'المبتدأ والخبر (الجزء الثاني)', N'kndMZrdjzNw', CAST(N'2021-08-03T02:20:02.3800000' AS DateTime2), N'Video', NULL, N'kndMZrdjzNw', 2, 2)");
            migrationBuilder.Sql("INSERT [dbo].[Lesson] ( [Title], [Image], [CreatedAt], [Discriminator], [Content], [Link], [Order], [CourseId]) VALUES ( N'حكم  تأخير المبتدأ', N'mVaL4wykmZU', CAST(N'2021-08-03T02:20:32.6300000' AS DateTime2), N'Video', NULL, N'mVaL4wykmZU', 3, 2)");
            migrationBuilder.Sql("INSERT [dbo].[Lesson] ( [Title], [Image], [CreatedAt], [Discriminator], [Content], [Link], [Order], [CourseId]) VALUES ( N'أحكام حذف المبتدأ والخبر', N'JEpX2-fhB-M', CAST(N'2021-08-03T02:21:04.7333333' AS DateTime2), N'Video', NULL, N'JEpX2-fhB-M', 4, 2)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
