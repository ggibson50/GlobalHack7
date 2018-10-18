namespace Website.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangedResumeSkills : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.ResumeSkills");
            AddColumn("dbo.ResumeSkills", "SkillCategoryId", c => c.Guid(nullable: false));
            AddPrimaryKey("dbo.ResumeSkills", new[] { "ResumeId", "SkillCategoryId" });
            DropColumn("dbo.ResumeSkills", "JobSkillId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ResumeSkills", "JobSkillId", c => c.Guid(nullable: false));
            DropPrimaryKey("dbo.ResumeSkills");
            DropColumn("dbo.ResumeSkills", "SkillCategoryId");
            AddPrimaryKey("dbo.ResumeSkills", new[] { "ResumeId", "JobSkillId" });
        }
    }
}
