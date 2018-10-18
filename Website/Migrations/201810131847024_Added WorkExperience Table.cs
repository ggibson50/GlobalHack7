namespace Website.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedWorkExperienceTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.WorkExperiences",
                c => new
                    {
                        WorkExperienceId = c.Guid(nullable: false),
                        ResumeId = c.Guid(nullable: false),
                        BusinessName = c.String(maxLength: 100),
                        StartDate = c.DateTime(),
                        EndDate = c.DateTime(),
                        JobTitle = c.String(maxLength: 100),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.WorkExperienceId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.WorkExperiences");
        }
    }
}
