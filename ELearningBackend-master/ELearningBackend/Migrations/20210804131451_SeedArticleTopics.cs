using Microsoft.EntityFrameworkCore.Migrations;

namespace ELearningBackend.Migrations
{
    public partial class SeedArticleTopics : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT [dbo].[ArticleTopic] ([ArticlesId], [TopicsId]) VALUES (12, 1)");
            migrationBuilder.Sql("INSERT [dbo].[ArticleTopic] ([ArticlesId], [TopicsId]) VALUES (13, 1)");
            migrationBuilder.Sql("INSERT [dbo].[ArticleTopic] ([ArticlesId], [TopicsId]) VALUES (12, 2)");
            migrationBuilder.Sql("INSERT [dbo].[ArticleTopic] ([ArticlesId], [TopicsId]) VALUES (13, 3)");
            migrationBuilder.Sql("INSERT [dbo].[ArticleTopic] ([ArticlesId], [TopicsId]) VALUES (9, 4)");
            migrationBuilder.Sql("INSERT [dbo].[ArticleTopic] ([ArticlesId], [TopicsId]) VALUES (10, 4)");
            migrationBuilder.Sql("INSERT [dbo].[ArticleTopic] ([ArticlesId], [TopicsId]) VALUES (11, 4)");
            migrationBuilder.Sql("INSERT [dbo].[ArticleTopic] ([ArticlesId], [TopicsId]) VALUES (9, 5)");
            migrationBuilder.Sql("INSERT [dbo].[ArticleTopic] ([ArticlesId], [TopicsId]) VALUES (11, 6)");
            migrationBuilder.Sql("INSERT [dbo].[ArticleTopic] ([ArticlesId], [TopicsId]) VALUES (10, 7)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
