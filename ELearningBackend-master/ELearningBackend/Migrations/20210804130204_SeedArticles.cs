using Microsoft.EntityFrameworkCore.Migrations;

namespace ELearningBackend.Migrations
{
    public partial class SeedArticles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT [dbo].[Lesson] (  [Title], [Image], [CreatedAt], [Discriminator], [Content], [Link], [Order], [CourseId], [Discription]) VALUES ( N'اسم الفاعل', N'صورة', CAST(N'2021-08-04T02:50:02.9366667' AS DateTime2), N'Article', NULL, NULL, NULL, NULL, N'اسم الفاعل ... دا اسم مشتق بنطلقه على اللي بيعمل الفعل أو بيتصف بيه ... وبيكون مشتق من الفعل المبني للمعلوم ... مثلا اللي بيحكم في المحكمة ... يقضي بالقانون عشان كدة سميناه (قاضي) ... والطالب بيطلب فسميناه طالب وهكذا')");
            migrationBuilder.Sql("INSERT [dbo].[Lesson] (  [Title], [Image], [CreatedAt], [Discriminator], [Content], [Link], [Order], [CourseId], [Discription]) VALUES ( N'صيغة المبالغة', N'صورة', CAST(N'2021-08-04T02:50:21.5133333' AS DateTime2), N'Article', NULL, NULL, NULL, NULL, N'عارف لما يكون حد بياكل كتير فتقول (محمد كثير الأكل) ... أنت كان ممكن تقول (كثير الأكل) في كلمة واحدة وهي مثلا (أكول) أو (أكال)... والاتنين دول اسمهم صيغة مبالغة.- صيغة المبالغة دا مشتق بيدل على قوة الفعل وشدته أو إن الفعل بيتكرر كتير... مثلا جملة(محمد أكول)... ممكن يكون معناها أن محمد بياكل كمية كبيرة أو إن محمد بياكل مرات كتيرة.- صيغة المبالغة لها أوزان معينة هي(فعَّال – مِفعال – فعول – فعيل – فَعِل).- فعَّال زي(ظلام) ومفعال زي(مفهام) وفعول زي(قنوط) وفعيل زي(عليم) وفَعِل زي(يقظ – فطن - حذر).- صيغ المبالغة بتيجي من الثلاثي ونادرا ما بتيجي من غير الثلاثي زي(مغوار – مقدام – بشير – معطاء – نذير).')");
            migrationBuilder.Sql("INSERT [dbo].[Lesson] (  [Title], [Image], [CreatedAt], [Discriminator], [Content], [Link], [Order], [CourseId], [Discription]) VALUES ( N'اسم المفعول', N'صورة', CAST(N'2021-08-04T02:50:47.1766667' AS DateTime2), N'Article', NULL, NULL, NULL, NULL, N'اسم المفعول دا مشتق بيوصف اللي وقع عليه الفعل ... وبيكون مشتق من الفعل المبني للمجهول ... مثلا ضُرِب الولد ... إذن الولد مضروب ... أُكِل الطعام ... إذن الطعام مأكول. وهكذا')");
            migrationBuilder.Sql("INSERT [dbo].[Lesson] (  [Title], [Image], [CreatedAt], [Discriminator], [Content], [Link], [Order], [CourseId], [Discription]) VALUES ( N'حكم تأخير المبتدأ', N'صورة', CAST(N'2021-08-04T02:51:22.2966667' AS DateTime2), N'Article', NULL, NULL, NULL, NULL, N'قلنا المبتدأ هو اللي بييجي في أول الكلام بس قلنا بردو ماعدا حالات معينة يلا بينا نعرفها بقى.- المبتدأ ممكن يتأخر وجوبا... يعني لازم يتأخر عااافية في خمس حالات: 1 - شبه جملة + نكرة: هنا شبه الجملة بتبقى في محل رفع الخبر... والنكرة اللي بعدها بتتعرب مبتدأ... زي(فوق الشجرة عصفور)... (في الدار رجل)... (في القفص أسد) ... وهكذا طالما شبه جملة وبعدها نكرة يبقى المبتدأ مؤخر وجوبا')");
            migrationBuilder.Sql("INSERT [dbo].[Lesson] (  [Title], [Image], [CreatedAt], [Discriminator], [Content], [Link], [Order], [CourseId], [Discription]) VALUES ( N'أحكام حذف المبتدأ والخبر', N'صورة', CAST(N'2021-08-04T02:51:37.6133333' AS DateTime2), N'Article', NULL, NULL, NULL, NULL, N'في منهجكم تلات حالات لحذف المبتدأ وجوبا وهما:1 - المخصوص بالمدح والذم بعد(نعم – بئس – حبذا – لا حبذا)... زي(نعم رجلا أحمد)(لا حبذا الكذب)... في الجملتين أنت بتمدح ايه وبتذم ايه؟ (أحمد – الكذب)... يبقى دول خبر لمبتدأ محذوف وجوبا تقديره هو.ملحوظة: طبعا أمن مستغرب دلوقتي هو المخصوص بالمدح والذم بيتعرب مبتدأ مؤخر ولا خبر لمبتدأ محذوف صح؟ ....حاسس بيك أنا عارف ^ ^... المخصوص بالمدح والذم بيتعرب أي إعراب من الاتنين دايما فالاتنين دايما صح.')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
