using Microsoft.EntityFrameworkCore.Migrations;

namespace ELearningBackend.Migrations
{
    public partial class SeedTopicVideo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT [dbo].[TopicVideo] ([TopicsId], [VideosId]) VALUES (4, 1)");
            migrationBuilder.Sql("INSERT [dbo].[TopicVideo] ([TopicsId], [VideosId]) VALUES (5, 1)");
            migrationBuilder.Sql("INSERT [dbo].[TopicVideo] ([TopicsId], [VideosId]) VALUES (4, 2)");
            migrationBuilder.Sql("INSERT [dbo].[TopicVideo] ([TopicsId], [VideosId]) VALUES (7, 2)");
            migrationBuilder.Sql("INSERT [dbo].[TopicVideo] ([TopicsId], [VideosId]) VALUES (4, 3)");
            migrationBuilder.Sql("INSERT [dbo].[TopicVideo] ([TopicsId], [VideosId]) VALUES (6, 3)");
            migrationBuilder.Sql("INSERT [dbo].[TopicVideo] ([TopicsId], [VideosId]) VALUES (4, 4)");
            migrationBuilder.Sql("INSERT [dbo].[TopicVideo] ([TopicsId], [VideosId]) VALUES (1, 5)");
            migrationBuilder.Sql("INSERT [dbo].[TopicVideo] ([TopicsId], [VideosId]) VALUES (1, 6)");
            migrationBuilder.Sql("INSERT [dbo].[TopicVideo] ([TopicsId], [VideosId]) VALUES (1, 7)");
            migrationBuilder.Sql("INSERT [dbo].[TopicVideo] ([TopicsId], [VideosId]) VALUES (2, 7)");
            migrationBuilder.Sql("INSERT [dbo].[TopicVideo] ([TopicsId], [VideosId]) VALUES (1, 8)");
            migrationBuilder.Sql("INSERT [dbo].[TopicVideo] ([TopicsId], [VideosId]) VALUES (3, 8)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
