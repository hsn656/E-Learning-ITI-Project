using Microsoft.EntityFrameworkCore.Migrations;

namespace ELearningBackend.Migrations
{
    public partial class seedQuestionsP1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT [dbo].[Questions] ( [Content], [CreatedAt]) VALUES ( N' (البيت غرفه كثيرة)ـ ما إعراب غرفه؟', CAST(N'2021-08-03T02:40:06.4866667' AS DateTime2))");
            migrationBuilder.Sql("INSERT [dbo].[Questions] ( [Content], [CreatedAt]) VALUES ( N'(الحياة بها عبر كثيرة)، ما إعراب عبر', CAST(N'2021-08-03T02:40:19.5600000' AS DateTime2))");
            migrationBuilder.Sql("INSERT [dbo].[Questions] ( [Content], [CreatedAt]) VALUES ( N'(أفضل ما في هذا الكون وما يحتويه من أشياء محببة للنفس وغير محببة أصدقاء يعرفون معني أن تكون صديقا)، ما إعراب (أصدقاء)؟', CAST(N'2021-08-03T02:40:29.2166667' AS DateTime2))");
            migrationBuilder.Sql("INSERT [dbo].[Questions] ( [Content], [CreatedAt]) VALUES ( N'(ثمة أمل كبير منك)، ما إعراب أمل؟', CAST(N'2021-08-03T02:40:50.2833333' AS DateTime2))");
            migrationBuilder.Sql("INSERT [dbo].[Questions] ( [Content], [CreatedAt]) VALUES ( N'(لولا الخطأ ما تعلمنا)، ما إعراب الخطأ؟', CAST(N'2021-08-03T02:41:01.7300000' AS DateTime2))");
            migrationBuilder.Sql("INSERT [dbo].[Questions] ( [Content], [CreatedAt]) VALUES ( N'(لولا المشقة ساد الناس كلهم)، الخبر محذوف وتقديره؟', CAST(N'2021-08-03T02:41:10.6100000' AS DateTime2))");
            migrationBuilder.Sql("INSERT [dbo].[Questions] ( [Content], [CreatedAt]) VALUES ( N'(في البيت والدي)، حكم تأخير المبتدأ؟', CAST(N'2021-08-03T02:41:19.0800000' AS DateTime2))");
            migrationBuilder.Sql("INSERT [dbo].[Questions] ( [Content], [CreatedAt]) VALUES ( N'(ما لنا إلا الله)، ما حكم تأخير المبتدأ؟', CAST(N'2021-08-03T02:41:25.6033333' AS DateTime2))");
            migrationBuilder.Sql("INSERT [dbo].[Questions] ( [Content], [CreatedAt]) VALUES ( N'(الولد محمود خلقه)، ما إعراب خلقه؟', CAST(N'2021-08-03T02:41:36.2433333' AS DateTime2))");
            migrationBuilder.Sql("INSERT [dbo].[Questions] ( [Content], [CreatedAt]) VALUES ( N'(زرت حديقة أزهارها جميلة)، أزهارها تعرب؟', CAST(N'2021-08-03T02:41:43.5366667' AS DateTime2))");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
