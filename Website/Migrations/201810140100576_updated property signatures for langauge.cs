namespace Website.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatedpropertysignaturesforlangauge : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Languages", "EnglishLanguageName", c => c.String(nullable: false, maxLength: 50));
            AddColumn("dbo.Languages", "NativeLanguageName", c => c.String(nullable: false, maxLength: 50));
            DropColumn("dbo.Languages", "EnglishName");
            DropColumn("dbo.Languages", "NativeLanguage");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Languages", "NativeLanguage", c => c.String(nullable: false, maxLength: 50));
            AddColumn("dbo.Languages", "EnglishName", c => c.String(nullable: false, maxLength: 50));
            DropColumn("dbo.Languages", "NativeLanguageName");
            DropColumn("dbo.Languages", "EnglishLanguageName");
        }
    }
}
