using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace ELearningBackend.Migrations
{
    public partial class seedRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
           table: "AspNetRoles"
           , columns: new[] { "Id", "Name", "NormalizedName", "ConcurrencyStamp" }
           , values: new object[] { "b7222e6a-1729-4e2d-a70d-65b2a188c6bb", "Bronze", "Bronze".ToUpper(), Guid.NewGuid().ToString() }
           );
            migrationBuilder.InsertData(
           table: "AspNetRoles"
           , columns: new[] { "Id", "Name", "NormalizedName", "ConcurrencyStamp" }
           , values: new object[] { "c7d6ecd6-0012-4363-af95-7b91d76ec867", "Silver", "Silver".ToUpper(), Guid.NewGuid().ToString() }
           );
            migrationBuilder.InsertData(
           table: "AspNetRoles"
           , columns: new[] { "Id", "Name", "NormalizedName", "ConcurrencyStamp" }
           , values: new object[] { "4881c5e0-3912-4daf-af14-00a9d1b7e534", "Gold", "Gold".ToUpper(), Guid.NewGuid().ToString() }
           );
            migrationBuilder.InsertData(
                table: "AspNetRoles"
                , columns: new[] { "Id", "Name", "NormalizedName", "ConcurrencyStamp" }
                , values: new object[] { "158dbd46-5887-470c-a704-2bd4ead8f6cd", "Admin", "Admin".ToUpper(), Guid.NewGuid().ToString() }
                );

            //inserting new user
           // migrationBuilder.InsertData(
           //table: "AspNetUsers"
           //, columns: new[] { "Id", "FirstName", "LastName", "EmailConfirmed", "PhoneNumberConfirmed", "TwoFactorEnabled", "LockoutEnabled", "AccessFailedCount" }
           //, values: new object[] { Guid.NewGuid().ToString(), "Ahmed", "Mustafa",false, false, false, false, 0  }
           //);
           // migrationBuilder.InsertData(
           //table: "AspNetUsers"
           //, columns: new[] { "Id", "FirstName", "LastName", "EmailConfirmed", "PhoneNumberConfirmed", "TwoFactorEnabled", "LockoutEnabled", "AccessFailedCount" }
           //, values: new object[] { Guid.NewGuid().ToString(), "Ali", "Gamal", false, false, false, false, 0 }
           //);
           // migrationBuilder.InsertData(
           //table: "AspNetUsers"
           //, columns: new[] { "Id", "FirstName", "LastName", "EmailConfirmed", "PhoneNumberConfirmed", "TwoFactorEnabled", "LockoutEnabled", "AccessFailedCount" }
           //, values: new object[] { Guid.NewGuid().ToString(), "Abudallah", "hamdo", false, false, false, false, 0 }
           //);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
