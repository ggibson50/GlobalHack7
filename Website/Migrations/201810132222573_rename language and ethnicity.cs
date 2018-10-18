namespace Website.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class renamelanguageandethnicity : DbMigration
    {
        public override void Up()
        {
            //RenameTable(name: "dbo.Ethnicty", newName: "Ethnicities");
            //RenameTable(name: "dbo.Language", newName: "Languages");
        }
        
        public override void Down()
        {
            //RenameTable(name: "dbo.Languages", newName: "Language");
            //RenameTable(name: "dbo.Ethnicities", newName: "Ethnicty");
        }
    }
}
