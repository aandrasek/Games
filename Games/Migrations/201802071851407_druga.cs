namespace Games.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class druga : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.NumberGameEntities",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        HighScore = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.SpaceshipGameEntities",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        HighScore = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.SpaceshipGameEntities");
            DropTable("dbo.NumberGameEntities");
        }
    }
}
