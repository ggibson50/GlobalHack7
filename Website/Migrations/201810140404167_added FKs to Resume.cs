namespace Website.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedFKstoResume : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Resume", "LanguageCode", c => c.String(maxLength: 5));
            AddColumn("dbo.Resume", "OriginalResumeId", c => c.Guid());
            CreateIndex("dbo.Resume", "LanguageCode");
            CreateIndex("dbo.Resume", "OriginalResumeId");
            AddForeignKey("dbo.Resume", "LanguageCode", "dbo.Languages", "LanguageCode");
            AddForeignKey("dbo.Resume", "OriginalResumeId", "dbo.Resume", "ResumeId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Resume", "OriginalResumeId", "dbo.Resume");
            DropForeignKey("dbo.Resume", "LanguageCode", "dbo.Languages");
            DropIndex("dbo.Resume", new[] { "OriginalResumeId" });
            DropIndex("dbo.Resume", new[] { "LanguageCode" });
            DropColumn("dbo.Resume", "OriginalResumeId");
            DropColumn("dbo.Resume", "LanguageCode");
        }
    }
}
