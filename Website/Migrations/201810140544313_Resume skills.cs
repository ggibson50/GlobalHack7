namespace Website.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Resumeskills : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ResumeSkills",
                c => new
                    {
                        ResumeId = c.Guid(nullable: false),
                        SkillCategoryId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => new { t.ResumeId, t.SkillCategoryId });
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ResumeSkills");
        }
    }
}
