namespace Nexus.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class setDb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Advantages",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Title = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Advantages");
        }
    }
}
