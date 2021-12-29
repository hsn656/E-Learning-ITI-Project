using Microsoft.EntityFrameworkCore.Migrations;

namespace ELearningBackend.Migrations
{
    public partial class seedUsers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT [dbo].[AspNetUsers] ([Id], [FirstName], [LastName], [Image], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'1235de08-c663-4747-bc7b-af81e2760749', N'Alaa', N'Mohamed', NULL, N'gold@gmail.com', N'GOLD@GMAIL.COM', N'gold@gmail.com', N'GOLD@GMAIL.COM', 0, N'AQAAAAEAACcQAAAAEIu69WOjDmUTMn514S7r7Ujx7e3UbezyPmnYE9ZDhgn60ay6/HcRA4V9FYG3P5qUAQ==', N'V3SRS2XGC3U4SQVJUI6U4753BLTLZ44B', N'2a152294-9367-4ac3-a586-5896ed35de91', N'01113895268', 0, 0, NULL, 1, 0)");
            migrationBuilder.Sql("INSERT [dbo].[AspNetUsers] ([Id], [FirstName], [LastName], [Image], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'5ecdabea-5011-4725-9273-86e6464cc1ed', N'Hassan', N'Mohamed', NULL, N'hsn656@gmail.com', N'HSN656@GMAIL.COM', N'hsn656@gmail.com', N'HSN656@GMAIL.COM', 0, N'AQAAAAEAACcQAAAAEI+Psp4xnIrL36QCdYcXq+narzqMILYgc/ErEtU7fpazEfhEEfVguHp2mY1K0ycMzA==', N'OXFGDTFF5FEDUTHWL7W5RPG3BQSOP66G', N'29287fce-ea32-4c99-bf8b-b740a1a0157e', N'01113795268', 0, 0, NULL, 1, 0)");
            migrationBuilder.Sql("INSERT [dbo].[AspNetUsers] ([Id], [FirstName], [LastName], [Image], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'ab56b039-a05b-4433-b1db-fb425ba6d5e6', N'mousa', N'Mohamed', NULL, N'bronze@gmail.com', N'BRONZE@GMAIL.COM', N'bronze@gmail.com', N'BRONZE@GMAIL.COM', 0, N'AQAAAAEAACcQAAAAEKXbuumSmcz13GWjZ9j859kd5Dvf3qicR2zi3qpyX3wbrM21uJRPOPSSbgwgvT8mkQ==', N'RWP7EOJYRVM2Y3YMCZADA3I25NHBSU4W', N'a1535040-77f1-4a61-b9ff-dd19b0a3712e', N'01113995268', 0, 0, NULL, 1, 0)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
