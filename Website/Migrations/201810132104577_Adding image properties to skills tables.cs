namespace Website.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Addingimagepropertiestoskillstables : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.SkillCategory", "Image", c => c.String());
            AddColumn("dbo.SkillType", "Image", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.SkillType", "Image");
            DropColumn("dbo.SkillCategory", "Image");
        }
    }
}
