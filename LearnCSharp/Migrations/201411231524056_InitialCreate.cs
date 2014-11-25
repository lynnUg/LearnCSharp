namespace LearnCSharp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Destinations",
                c => new
                    {
                        DestinationId = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 4000),
                        Country = c.String(maxLength: 4000),
                        Description = c.String(maxLength: 4000),
                        Photo = c.Binary(maxLength: 4000),
                    })
                .PrimaryKey(t => t.DestinationId);
            
            CreateTable(
                "dbo.Lodgings",
                c => new
                    {
                        LodgingId = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 4000),
                        Owner = c.String(maxLength: 4000),
                        IsResort = c.Boolean(nullable: false),
                        Destination_DestinationId = c.Int(),
                    })
                .PrimaryKey(t => t.LodgingId)
                .ForeignKey("dbo.Destinations", t => t.Destination_DestinationId)
                .Index(t => t.Destination_DestinationId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Lodgings", "Destination_DestinationId", "dbo.Destinations");
            DropIndex("dbo.Lodgings", new[] { "Destination_DestinationId" });
            DropTable("dbo.Lodgings");
            DropTable("dbo.Destinations");
        }
    }
}
