using Microsoft.EntityFrameworkCore.Migrations;

namespace ELearningBackend.Migrations
{
    public partial class seedQstnP2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT [dbo].[Questions] (  [Content], [CreatedAt]) VALUES ( N'(ذهبت إلى مساجد المدينة)، كلمة مساجد مجرورة؟', CAST(N'2021-08-03T06:15:24.4466667' AS DateTime2))");
            migrationBuilder.Sql("INSERT [dbo].[Questions] (  [Content], [CreatedAt]) VALUES ( N'(ذهبت إلى مساجد كثيرة)، كلمة مساجد مجرورة؟', CAST(N'2021-08-03T06:15:33.2500000' AS DateTime2))");
            migrationBuilder.Sql("INSERT [dbo].[Questions] (  [Content], [CreatedAt]) VALUES ( N'(يجب عليك أن تجتهد لإعلاء شأن مصر)، ما محل المصدر المؤول؟', CAST(N'2021-08-03T06:15:43.9600000' AS DateTime2))");
            migrationBuilder.Sql("INSERT [dbo].[Questions] (  [Content], [CreatedAt]) VALUES ( N'(يجب عليك أن تجتهد لإعلاء شأن مصر)، ما إعراب (لإعلاء)؟', CAST(N'2021-08-03T06:15:56.3233333' AS DateTime2))");
            migrationBuilder.Sql("INSERT [dbo].[Questions] (  [Content], [CreatedAt]) VALUES ( N'(أحب أن أذهب وحدي إلى المدرسة)، ما إعراب وحدي؟', CAST(N'2021-08-03T06:16:18.3000000' AS DateTime2))");
            migrationBuilder.Sql("INSERT [dbo].[Questions] (  [Content], [CreatedAt]) VALUES ( N'(أحب أن أذهب وحدي إلى المدرسة)، ما محل المصدر المؤول؟', CAST(N'2021-08-03T06:16:27.1333333' AS DateTime2))");
            migrationBuilder.Sql("INSERT [dbo].[Questions] (  [Content], [CreatedAt]) VALUES ( N' أي الكلمات التالية ليس ممنوعا من الصرف', CAST(N'2021-08-03T06:16:48.6933333' AS DateTime2))");
            migrationBuilder.Sql("INSERT [dbo].[Questions] (  [Content], [CreatedAt]) VALUES ( N'(أحبك مؤديا واجبك)، ما إعراب واجبك؟', CAST(N'2021-08-03T06:17:11.8866667' AS DateTime2))");
            migrationBuilder.Sql("INSERT [dbo].[Questions] (  [Content], [CreatedAt]) VALUES ( N'(المتفوق ممنوح جائزة)، ما إعراب جائزة؟', CAST(N'2021-08-03T06:17:19.1533333' AS DateTime2))");
            migrationBuilder.Sql("INSERT [dbo].[Questions] (  [Content], [CreatedAt]) VALUES ( N'(أستاذك رقيق قلبه)، ما إعراب قلبه؟', CAST(N'2021-08-03T06:17:25.8700000' AS DateTime2))");
            migrationBuilder.Sql("INSERT [dbo].[Questions] (  [Content], [CreatedAt]) VALUES ( N'(الهاتف مستخدم بواسطتي) نوع المشتق في مستخدم؟', CAST(N'2021-08-03T06:17:38.4566667' AS DateTime2))");
            migrationBuilder.Sql("INSERT [dbo].[Questions] (  [Content], [CreatedAt]) VALUES ( N'(محمد كاتب درسه أمس)، ما إعراب درسه؟', CAST(N'2021-08-03T06:17:53.1533333' AS DateTime2))");
            migrationBuilder.Sql("INSERT [dbo].[Questions] (  [Content], [CreatedAt]) VALUES ( N'(هو قاتل أبيك)، ما إعراب أبيك؟', CAST(N'2021-08-03T06:17:58.3200000' AS DateTime2))");
            migrationBuilder.Sql("INSERT [dbo].[Questions] (  [Content], [CreatedAt]) VALUES ( N'(هو قاتل أباك، ما إعراب أباك؟', CAST(N'2021-08-03T06:18:04.6066667' AS DateTime2))");
            migrationBuilder.Sql("INSERT [dbo].[Questions] (  [Content], [CreatedAt]) VALUES ( N'(نسعى لمبادئ سامية أركانها)، ما إعراب أركانها؟', CAST(N'2021-08-03T06:18:14.5733333' AS DateTime2))");
            migrationBuilder.Sql("INSERT [dbo].[Questions] (  [Content], [CreatedAt]) VALUES ( N' (هو شخص مشهورة كتبه)، ما إعراب كتبه؟', CAST(N'2021-08-03T06:18:26.4133333' AS DateTime2))");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
