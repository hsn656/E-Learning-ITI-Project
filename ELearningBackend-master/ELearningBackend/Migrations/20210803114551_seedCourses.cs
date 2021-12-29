using Microsoft.EntityFrameworkCore.Migrations;

namespace ELearningBackend.Migrations
{
    public partial class seedCourses : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT [dbo].[Courses] ( [CreatedAt], [Description], [Image], [Name], [Order]) VALUES ( CAST(N'2021-07-26T12:22:25.2100000' AS DateTime2), N'هذه أولى محاضراتنا ولن نتكلم في أول ساعة منها عن درس بعينه كالمبتدأ والخبر ولن تكون البداية تقليدية فأذكر لك فيها أن الكلمة اسم أو فعل أو حرف بل سنتجه إلى تعليمك  كيف تتعامل مع النحو وبعض القواعد بشكل مختصر سريع (سيتم شرحها تفصيلا فيما بعد) ونقوم بالتطبيق على ما تعلمناه وتصحيح بعض القواعد الخاطئة وتصليح المفاهيم المشوهة الناشئة عند بعضكم عن النحو لتعلم أن النحو علم جميل كنت محروما منه .', N'ilX7zBAWpeM', N'المحاضرة الأولى كورس رحيق النحو', 1)");
            migrationBuilder.Sql("INSERT [dbo].[Courses] ( [CreatedAt], [Description], [Image], [Name], [Order]) VALUES ( CAST(N'2021-07-27T04:17:28.5166667' AS DateTime2), N'حان الوقت لنتكلم معك عن المبتدأ والخبر بشكل مفصل لذا في هذه المحاضرة ستفهم معناهما جيدا وسنعرفك حالات حذفهما وأحكامها وأحكام تقديم المبتدأ وتأخير الخبر وستفهم لماذا شرحنا لك إعمال المشتقات في المحاضرة السابقة رغم أنك كنت في البداية وستزداد ثقتك بنا وبنفسك شيئا فشيئا فأبشر .', N'kndMZrdjzNw', N'المحاضرة الثانية كورس رحيق النحو', 2)");
            migrationBuilder.Sql("INSERT [dbo].[Courses] ( [CreatedAt], [Description], [Image], [Name], [Order]) VALUES ( CAST(N'2021-08-03T01:39:03.8600000' AS DateTime2), N'شرحنا في المحاضرة السابقة المبتدأ والخبر وسنتعرض في هذه المحاضرة لمصطلح النواسخ التي تدخل على الجملة الاسمية فتجعل المبتدأ اسمها والخبر خبرها وهذه النواسخ قد تكون أفعالا وقد تكون حروفا سنتكلم الآن عن الأفعال الناسخة وسيزداد فهمك للنحو عموما وللمبتدأ والخبر خاصة سأتركك الآن قم بالانطلاق ', N'z0oF2Xbu8VQ', N'المحاضرة الثالثة كورس رحيق النحو', 3)");
            migrationBuilder.Sql("INSERT [dbo].[Courses] ( [CreatedAt], [Description], [Image], [Name], [Order]) VALUES ( CAST(N'2021-08-03T01:39:43.1066667' AS DateTime2), N'تكلمنا عن الأفعال الناسخة وصرت مهيئا لتتعرف على الحروف الناسخة (إن وأخواتها – لا النافية للجنس) وتطبق عليها بعد هذه المحاضرة ستكون انتهيت من الجملة الاسمية سواء كانت منسوخة أو غير منسوخة ', N'S4pXa0M8_RA', N'المحاضرة الرابعة كورس رحيق النحو', 4)");
            migrationBuilder.Sql("INSERT [dbo].[Courses] ( [CreatedAt], [Description], [Image], [Name], [Order]) VALUES ( CAST(N'2021-08-03T01:40:25.7966667' AS DateTime2), N'انتهينا من شرح الجملة الاسمية ، ماذا عن الجملة الفعلية؟ سنتكلم في هذه المحاضرة عن الأفعال وإعرابها قد كبرت الآن لذا لا يصح لك أن تقول يذهب: فعل مضارع فهذا إعراب غير كامل لا بد أن تقول مثلا فعل مضارع مرفوع وعلامة رفعه ثبوت النون ستتعلم في هذه المحاضرة كيف يكون إعرابك للأفعال كاملا  وستجد الأمر سهلا كالعادة فأبشر .', N'OY4VPIuyBn0', N'المحاضرة الخامسة كورس رحيق النحو', 5)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
