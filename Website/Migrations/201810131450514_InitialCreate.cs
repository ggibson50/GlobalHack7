namespace Website.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BusinessProfiles",
                c => new
                    {
                        BusinessId = c.Int(nullable: false, identity: true),
                        BusinessName = c.String(),
                        BusinessIndustry = c.String(),
                        ShortBusinessDescription = c.String(),
                        LongBusinessDescription = c.String(),
                        State = c.String(),
                        City = c.String(),
                        StreetAddress = c.String(),
                        EmailAddress = c.String(),
                        PhoneNumber = c.String(),
                        Image = c.String(),
                    })
                .PrimaryKey(t => t.BusinessId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.BusinessProfiles");
        }
    }
}
