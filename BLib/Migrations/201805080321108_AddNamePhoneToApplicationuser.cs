namespace BLib.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNamePhoneToApplicationuser : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "FirstName", c => c.String(nullable: false, maxLength: 50));
            AddColumn("dbo.AspNetUsers", "LasrName", c => c.String(nullable: false, maxLength: 50));
            AddColumn("dbo.AspNetUsers", "Phone", c => c.String(nullable: false, maxLength: 50));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "Phone");
            DropColumn("dbo.AspNetUsers", "LasrName");
            DropColumn("dbo.AspNetUsers", "FirstName");
        }
    }
}
