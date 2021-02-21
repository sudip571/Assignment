namespace PreAssignment.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Hrefs",
                c => new
                    {
                        HrefId = c.Int(nullable: false),
                        Link = c.String(),
                    })
                .PrimaryKey(t => t.HrefId)
                .ForeignKey("dbo.Products", t => t.HrefId)
                .Index(t => t.HrefId);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ProductId = c.Int(nullable: false, identity: true),
                        DataRetriveDate = c.DateTime(nullable: false),
                        HourIndex = c.Int(nullable: false),
                        Name = c.String(),
                        Discount = c.Int(nullable: false),
                        TotalPrice = c.Single(nullable: false),
                        Rating = c.String(),
                    })
                .PrimaryKey(t => t.ProductId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Hrefs", "HrefId", "dbo.Products");
            DropIndex("dbo.Hrefs", new[] { "HrefId" });
            DropTable("dbo.Products");
            DropTable("dbo.Hrefs");
        }
    }
}
