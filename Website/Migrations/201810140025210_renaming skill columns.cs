namespace Website.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class renamingskillcolumns : DbMigration
    {
        public override void Up()
        {
            RenameColumn("dbo.SkillCategory", "SkillsCategory", "SkillCategoryName");
            //AddColumn("dbo.SkillCategory", "SkillCategoryName", c => c.String());
            //AddColumn("dbo.SkillCategory", "Image", c => c.String());
            //AddColumn("dbo.SkillType", "Image", c => c.String());
            //DropColumn("dbo.SkillCategory", "SkillName");
        }
        
        public override void Down()
        {
            RenameColumn("dbo.SkillCategory", "SkillCategoryName", "SkillsCategory");
            //AddColumn("dbo.SkillCategory", "SkillName", c => c.String());
            //DropColumn("dbo.SkillType", "Image");
            //DropColumn("dbo.SkillCategory", "Image");
            //DropColumn("dbo.SkillCategory", "SkillCategoryName");
        }
    }
}
