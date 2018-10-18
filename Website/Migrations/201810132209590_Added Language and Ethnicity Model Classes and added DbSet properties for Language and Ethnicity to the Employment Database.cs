namespace Website.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedLanguageandEthnicityModelClassesandaddedDbSetpropertiesforLanguageandEthnicitytotheEmploymentDatabase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Ethnicities",
                c => new
                    {
                        EthnicityId = c.Guid(nullable: false),
                        EthnicityName = c.String(),
                    })
                .PrimaryKey(t => t.EthnicityId);
            
            CreateTable(
                "dbo.Languages",
                c => new
                    {
                        LanguageCode = c.String(nullable: false, maxLength: 128),
                        EnglishName = c.String(),
                        NativeLanguage = c.String(),
                    })
                .PrimaryKey(t => t.LanguageCode);
        }
        
        public override void Down()
        {
            DropTable("dbo.Languages");
            DropTable("dbo.Ethnicities");
        }
    }
}
