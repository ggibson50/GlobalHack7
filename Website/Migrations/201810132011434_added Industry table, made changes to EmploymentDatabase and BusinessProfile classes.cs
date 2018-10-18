namespace Website.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedIndustrytablemadechangestoEmploymentDatabaseandBusinessProfileclasses : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Industries",
                c => new
                    {
                        IndustryId = c.Guid(nullable: false),
                        IndustryName = c.String(),
                    })
                .PrimaryKey(t => t.IndustryId);
            
            AddColumn("dbo.BusinessProfiles", "IndustryId", c => c.Guid());
            AlterColumn("dbo.BusinessProfiles", "BusinessName", c => c.String(nullable: false));
            AlterColumn("dbo.BusinessProfiles", "ShortBusinessDescription", c => c.String(maxLength: 100));
            AlterColumn("dbo.BusinessProfiles", "LongBusinessDescription", c => c.String(maxLength: 250));
            AlterColumn("dbo.BusinessProfiles", "State", c => c.String(maxLength: 2));
            AlterColumn("dbo.BusinessProfiles", "City", c => c.String(maxLength: 40));
            AlterColumn("dbo.BusinessProfiles", "StreetAddress", c => c.String(maxLength: 40));
            AlterColumn("dbo.BusinessProfiles", "EmailAddress", c => c.String(maxLength: 50));
            AlterColumn("dbo.BusinessProfiles", "PhoneNumber", c => c.String(maxLength: 10));
            AlterColumn("dbo.BusinessProfiles", "Image", c => c.String(maxLength: 40));
            CreateIndex("dbo.BusinessProfiles", "IndustryId");
            AddForeignKey("dbo.BusinessProfiles", "IndustryId", "dbo.Industries", "IndustryId");
            DropColumn("dbo.BusinessProfiles", "BusinessIndustry");
        }
        
        public override void Down()
        {
            AddColumn("dbo.BusinessProfiles", "BusinessIndustry", c => c.String());
            DropForeignKey("dbo.BusinessProfiles", "IndustryId", "dbo.Industries");
            DropIndex("dbo.BusinessProfiles", new[] { "IndustryId" });
            AlterColumn("dbo.BusinessProfiles", "Image", c => c.String());
            AlterColumn("dbo.BusinessProfiles", "PhoneNumber", c => c.String());
            AlterColumn("dbo.BusinessProfiles", "EmailAddress", c => c.String());
            AlterColumn("dbo.BusinessProfiles", "StreetAddress", c => c.String());
            AlterColumn("dbo.BusinessProfiles", "City", c => c.String());
            AlterColumn("dbo.BusinessProfiles", "State", c => c.String());
            AlterColumn("dbo.BusinessProfiles", "LongBusinessDescription", c => c.String());
            AlterColumn("dbo.BusinessProfiles", "ShortBusinessDescription", c => c.String());
            AlterColumn("dbo.BusinessProfiles", "BusinessName", c => c.String());
            DropColumn("dbo.BusinessProfiles", "IndustryId");
            DropTable("dbo.Industries");
        }
    }
}
