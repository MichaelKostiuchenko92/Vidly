namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers1 : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'0ecacb2f-2e1f-49fc-a334-56628cb39ebe', N'guest@vidly.com', 0, N'APt6oaUhQ2e1zfCDeUSQTydxAPhl/AvM+hv45eM+T8CZw2KQPZ41SDJbvrHOBk6SXg==', N'9d25c4c2-e482-42ec-8cf8-7aeff7e96948', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'3b3a0aee-270a-4d49-aea3-1c2c0a0c6f81', N'admint@vidly.com', 0, N'AGf7ddo0qRriQIadDXfSJuhEWyepPQE2QDkYsv++ZmrHG6z258grNU6RuV2jlLkFzA==', N'f7bf9b80-27ad-457a-ab74-46233c83e882', NULL, 0, 0, NULL, 1, 0, N'admint@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'df696c9b-fa26-4f46-b2b1-ad753ea50361', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'3b3a0aee-270a-4d49-aea3-1c2c0a0c6f81', N'df696c9b-fa26-4f46-b2b1-ad753ea50361')

");
        }
        
        public override void Down()
        {
        }
    }
}
