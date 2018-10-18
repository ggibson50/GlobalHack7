namespace Website.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedvalidationconstraintstoLanguageandethnicity : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Languages");
            AlterColumn("dbo.Ethnicities", "EthnicityName", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Languages", "LanguageCode", c => c.String(nullable: false, maxLength: 5));
            AlterColumn("dbo.Languages", "EnglishName", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Languages", "NativeLanguage", c => c.String(nullable: false, maxLength: 50));
            AddPrimaryKey("dbo.Languages", "LanguageCode");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Languages");
            AlterColumn("dbo.Languages", "NativeLanguage", c => c.String());
            AlterColumn("dbo.Languages", "EnglishName", c => c.String());
            AlterColumn("dbo.Languages", "LanguageCode", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.Ethnicities", "EthnicityName", c => c.String());
            AddPrimaryKey("dbo.Languages", "LanguageCode");
        }
    }
}
