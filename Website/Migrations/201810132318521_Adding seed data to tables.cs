namespace Website.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Addingseeddatatotables : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.SkillCategory", "SkillsCategory", c => c.String());
            DropColumn("dbo.SkillCategory", "SkillName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.SkillCategory", "SkillName", c => c.String());
            DropColumn("dbo.SkillCategory", "SkillsCategory");
        }
    }
}
