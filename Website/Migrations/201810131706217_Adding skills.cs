namespace Website.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Addingskills : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.JobSkill",
                c => new
                    {
                        JobSkillId = c.Guid(nullable: false),
                        JobSkillName = c.String(),
                        SkillType = c.String(),
                        SkillCategory = c.String(),
                    })
                .PrimaryKey(t => t.JobSkillId);
            
            CreateTable(
                "dbo.Resume",
                c => new
                    {
                        ResumeId = c.Guid(nullable: false),
                        FirstName = c.String(),
                        LastName = c.String(),
                        PhoneNumber = c.String(),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.ResumeId);
            
            CreateTable(
                "dbo.SkillCategory",
                c => new
                    {
                        SkillId = c.Guid(nullable: false),
                        SkillName = c.String(),
                        SkillType = c.String(),
                    })
                .PrimaryKey(t => t.SkillId);
            
            CreateTable(
                "dbo.SkillType",
                c => new
                    {
                        Name = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Name);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.SkillType");
            DropTable("dbo.SkillCategory");
            DropTable("dbo.Resume");
            DropTable("dbo.JobSkill");
        }
    }
}
