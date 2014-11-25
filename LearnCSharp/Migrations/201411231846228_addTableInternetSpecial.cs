namespace LearnCSharp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addTableInternetSpecial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.InternetSpecials",
                c => new
                    {
                        InternetSpecialId = c.Int(nullable: false, identity: true),
                        Nights = c.Int(nullable: false),
                        CostUSD = c.Decimal(nullable: false, precision: 18, scale: 2),
                        FromDate = c.DateTime(nullable: false),
                        ToDate = c.DateTime(nullable: false),
                        AccommodationId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.InternetSpecialId)
                .ForeignKey("dbo.Lodgings", t => t.AccommodationId, cascadeDelete: true)
                .Index(t => t.AccommodationId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.InternetSpecials", "AccommodationId", "dbo.Lodgings");
            DropIndex("dbo.InternetSpecials", new[] { "AccommodationId" });
            DropTable("dbo.InternetSpecials");
        }
    }
}
