using Microsoft.EntityFrameworkCore.Migrations;

namespace ELearningBackend.Migrations
{
    public partial class seedRolesToUsers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'5ecdabea-5011-4725-9273-86e6464cc1ed', N'158dbd46-5887-470c-a704-2bd4ead8f6cd')");
            migrationBuilder.Sql("INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'1235de08-c663-4747-bc7b-af81e2760749', N'4881c5e0-3912-4daf-af14-00a9d1b7e534')");
            migrationBuilder.Sql("INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'5ecdabea-5011-4725-9273-86e6464cc1ed', N'4881c5e0-3912-4daf-af14-00a9d1b7e534')");
            migrationBuilder.Sql("INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'1235de08-c663-4747-bc7b-af81e2760749', N'b7222e6a-1729-4e2d-a70d-65b2a188c6bb')");
            migrationBuilder.Sql("INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'5ecdabea-5011-4725-9273-86e6464cc1ed', N'b7222e6a-1729-4e2d-a70d-65b2a188c6bb')");
            migrationBuilder.Sql("INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'ab56b039-a05b-4433-b1db-fb425ba6d5e6', N'b7222e6a-1729-4e2d-a70d-65b2a188c6bb')");
            migrationBuilder.Sql("INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'1235de08-c663-4747-bc7b-af81e2760749', N'c7d6ecd6-0012-4363-af95-7b91d76ec867')");
            migrationBuilder.Sql("INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'5ecdabea-5011-4725-9273-86e6464cc1ed', N'c7d6ecd6-0012-4363-af95-7b91d76ec867')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
