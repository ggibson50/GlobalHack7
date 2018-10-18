namespace Website.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddeddataconstrantstoResume : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Resume", "FirstName", c => c.String(nullable: false, maxLength: 40));
            AlterColumn("dbo.Resume", "LastName", c => c.String(nullable: false, maxLength: 40));
            AlterColumn("dbo.Resume", "PhoneNumber", c => c.String(maxLength: 10));
            AlterColumn("dbo.Resume", "Email", c => c.String(maxLength: 70));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Resume", "Email", c => c.String());
            AlterColumn("dbo.Resume", "PhoneNumber", c => c.String());
            AlterColumn("dbo.Resume", "LastName", c => c.String());
            AlterColumn("dbo.Resume", "FirstName", c => c.String());
        }
    }
}
