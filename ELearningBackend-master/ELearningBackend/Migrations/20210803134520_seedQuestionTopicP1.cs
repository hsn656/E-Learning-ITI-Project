using Microsoft.EntityFrameworkCore.Migrations;

namespace ELearningBackend.Migrations
{
    public partial class seedQuestionTopicP1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT [dbo].[QuestionTopic] ([QuestionsId], [TopicsId]) VALUES (1, 1)");
            migrationBuilder.Sql("INSERT [dbo].[QuestionTopic] ([QuestionsId], [TopicsId]) VALUES (2, 1)");
            migrationBuilder.Sql("INSERT [dbo].[QuestionTopic] ([QuestionsId], [TopicsId]) VALUES (3, 1)");
            migrationBuilder.Sql("INSERT [dbo].[QuestionTopic] ([QuestionsId], [TopicsId]) VALUES (4, 1)");
            migrationBuilder.Sql("INSERT [dbo].[QuestionTopic] ([QuestionsId], [TopicsId]) VALUES (5, 1)");
            migrationBuilder.Sql("INSERT [dbo].[QuestionTopic] ([QuestionsId], [TopicsId]) VALUES (6, 1)");
            migrationBuilder.Sql("INSERT [dbo].[QuestionTopic] ([QuestionsId], [TopicsId]) VALUES (7, 1)");
            migrationBuilder.Sql("INSERT [dbo].[QuestionTopic] ([QuestionsId], [TopicsId]) VALUES (8, 1)");
            migrationBuilder.Sql("INSERT [dbo].[QuestionTopic] ([QuestionsId], [TopicsId]) VALUES (10, 1)");
            migrationBuilder.Sql("INSERT [dbo].[QuestionTopic] ([QuestionsId], [TopicsId]) VALUES (4, 2)");
            migrationBuilder.Sql("INSERT [dbo].[QuestionTopic] ([QuestionsId], [TopicsId]) VALUES (7, 2)");
            migrationBuilder.Sql("INSERT [dbo].[QuestionTopic] ([QuestionsId], [TopicsId]) VALUES (8, 2)");
            migrationBuilder.Sql("INSERT [dbo].[QuestionTopic] ([QuestionsId], [TopicsId]) VALUES (5, 3)");
            migrationBuilder.Sql("INSERT [dbo].[QuestionTopic] ([QuestionsId], [TopicsId]) VALUES (6, 3)");
            migrationBuilder.Sql("INSERT [dbo].[QuestionTopic] ([QuestionsId], [TopicsId]) VALUES (9, 4)");
            migrationBuilder.Sql("INSERT [dbo].[QuestionTopic] ([QuestionsId], [TopicsId]) VALUES (9, 6)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
