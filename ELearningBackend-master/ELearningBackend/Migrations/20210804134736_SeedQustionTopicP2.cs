using Microsoft.EntityFrameworkCore.Migrations;

namespace ELearningBackend.Migrations
{
    public partial class SeedQustionTopicP2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT [dbo].[QuestionTopic] ([QuestionsId], [TopicsId]) VALUES (18, 4)");
            migrationBuilder.Sql("INSERT [dbo].[QuestionTopic] ([QuestionsId], [TopicsId]) VALUES (19, 4)");
            migrationBuilder.Sql("INSERT [dbo].[QuestionTopic] ([QuestionsId], [TopicsId]) VALUES (20, 4)");
            migrationBuilder.Sql("INSERT [dbo].[QuestionTopic] ([QuestionsId], [TopicsId]) VALUES (21, 4)");
            migrationBuilder.Sql("INSERT [dbo].[QuestionTopic] ([QuestionsId], [TopicsId]) VALUES (22, 4)");
            migrationBuilder.Sql("INSERT [dbo].[QuestionTopic] ([QuestionsId], [TopicsId]) VALUES (23, 4)");
            migrationBuilder.Sql("INSERT [dbo].[QuestionTopic] ([QuestionsId], [TopicsId]) VALUES (24, 4)");
            migrationBuilder.Sql("INSERT [dbo].[QuestionTopic] ([QuestionsId], [TopicsId]) VALUES (26, 4)");
            migrationBuilder.Sql("INSERT [dbo].[QuestionTopic] ([QuestionsId], [TopicsId]) VALUES (18, 5)");
            migrationBuilder.Sql("INSERT [dbo].[QuestionTopic] ([QuestionsId], [TopicsId]) VALUES (22, 5)");
            migrationBuilder.Sql("INSERT [dbo].[QuestionTopic] ([QuestionsId], [TopicsId]) VALUES (23, 5)");
            migrationBuilder.Sql("INSERT [dbo].[QuestionTopic] ([QuestionsId], [TopicsId]) VALUES (24, 5)");
            migrationBuilder.Sql("INSERT [dbo].[QuestionTopic] ([QuestionsId], [TopicsId]) VALUES (19, 6)");
            migrationBuilder.Sql("INSERT [dbo].[QuestionTopic] ([QuestionsId], [TopicsId]) VALUES (21, 6)");
            migrationBuilder.Sql("INSERT [dbo].[QuestionTopic] ([QuestionsId], [TopicsId]) VALUES (26, 6)");
            migrationBuilder.Sql("INSERT [dbo].[QuestionTopic] ([QuestionsId], [TopicsId]) VALUES (20, 7)");
            migrationBuilder.Sql("INSERT [dbo].[QuestionTopic] ([QuestionsId], [TopicsId]) VALUES (11, 8)");
            migrationBuilder.Sql("INSERT [dbo].[QuestionTopic] ([QuestionsId], [TopicsId]) VALUES (12, 8)");
            migrationBuilder.Sql("INSERT [dbo].[QuestionTopic] ([QuestionsId], [TopicsId]) VALUES (17, 8)");
            migrationBuilder.Sql("INSERT [dbo].[QuestionTopic] ([QuestionsId], [TopicsId]) VALUES (25, 8)");
            migrationBuilder.Sql("INSERT [dbo].[QuestionTopic] ([QuestionsId], [TopicsId]) VALUES (13, 9)");
            migrationBuilder.Sql("INSERT [dbo].[QuestionTopic] ([QuestionsId], [TopicsId]) VALUES (16, 9)");


        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
