namespace BLib.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'881bb5cd-204d-4c4c-97c6-a29354431d60', N'john@blib.com', 0, N'ABVGdjnLfT+pSZZNd7JLkTjB8hZ0IbEtMirP+d4Z3wThy4nEhaMKW1HGfKw5wB+9Yg==', N'677d2bd8-156e-4c96-b6d4-547a20abf318', NULL, 0, 0, NULL, 1, 0, N'john@blib.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'c70609b4-1ed9-4037-a3e5-2a560c0e5068', N'admin@blib.com', 0, N'AGpJpRL0aks5n3e3CPh7WAjVUM8DwVz1heduLoZhzqD+9Daokf17QMHNGMnUZarMHA==', N'0d798c8b-e5de-4858-85aa-4c56a4b3fd3c', NULL, 0, 0, NULL, 1, 0, N'admin@blib.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'f1a6bb2e-c2c7-42be-9921-19c4073bf691', N'blib.admin@blib.com', 0, N'AI4Pd4VyZdphtbeKRGQOh9y3d/1D0lwSJXgxyxuSIgCYm3i81Lu+dIbZGD6DKwBBHw==', N'71f72c7e-d685-4299-a2ab-b3efb2fcaa23', NULL, 0, 0, NULL, 1, 0, N'blib.admin@blib.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'aea7025f-6c6d-404a-a241-13f19114aa09', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'f1a6bb2e-c2c7-42be-9921-19c4073bf691', N'aea7025f-6c6d-404a-a241-13f19114aa09')

");
        }
        
        public override void Down()
        {
        }
    }
}
