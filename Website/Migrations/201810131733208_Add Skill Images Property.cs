namespace Website.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddSkillImagesProperty : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.JobSkill", "Image", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.JobSkill", "Image");
        }
    }
}
