namespace PreAssignment.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tableupdate : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Products", "HourIndex", c => c.String());
            AlterColumn("dbo.Products", "TotalPrice", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Products", "TotalPrice", c => c.Single(nullable: false));
            AlterColumn("dbo.Products", "HourIndex", c => c.Int(nullable: false));
        }
    }
}
