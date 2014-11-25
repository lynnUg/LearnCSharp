namespace LearnCSharp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatedb : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Destinations", "Name", c => c.String(nullable: false, maxLength: 4000));
            AlterColumn("dbo.Destinations", "Description", c => c.String(maxLength: 500));
            AlterColumn("dbo.Destinations", "Photo", c => c.Binary());
            AlterColumn("dbo.Lodgings", "Name", c => c.String(nullable: false, maxLength: 200));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Lodgings", "Name", c => c.String(maxLength: 4000));
            AlterColumn("dbo.Destinations", "Photo", c => c.Binary(maxLength: 4000));
            AlterColumn("dbo.Destinations", "Description", c => c.String(maxLength: 4000));
            AlterColumn("dbo.Destinations", "Name", c => c.String(maxLength: 4000));
        }
    }
}
