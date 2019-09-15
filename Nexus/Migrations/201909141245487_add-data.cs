namespace Nexus.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class adddata : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Advantages", "Title", c => c.String());
            DropColumn("dbo.Advantages", "Titile");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Advantages", "Titile", c => c.String());
            DropColumn("dbo.Advantages", "Title");
        }
    }
}
