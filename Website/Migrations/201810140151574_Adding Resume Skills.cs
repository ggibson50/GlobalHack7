namespace Website.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingResumeSkills : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ResumeSkills",
                c => new
                    {
                        ResumeId = c.Guid(nullable: false),
                        JobSkillId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => new { t.ResumeId, t.JobSkillId });
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ResumeSkills");
        }
    }
}
