namespace Website.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedForeignKeyResumetoWorkExperiences : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.WorkExperiences", "ResumeId");
            AddForeignKey("dbo.WorkExperiences", "ResumeId", "dbo.Resume", "ResumeId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.WorkExperiences", "ResumeId", "dbo.Resume");
            DropIndex("dbo.WorkExperiences", new[] { "ResumeId" });
        }
    }
}
