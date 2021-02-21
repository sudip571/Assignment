namespace PreAssignment.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tableaddeddd : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CustomerrOrders",
                c => new
                    {
                        CustomerrOrderId = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        Qty = c.Int(nullable: false),
                        Customerr_CustomerrId = c.Int(),
                    })
                .PrimaryKey(t => t.CustomerrOrderId)
                .ForeignKey("dbo.Customerrs", t => t.Customerr_CustomerrId)
                .Index(t => t.Customerr_CustomerrId);
            
            CreateTable(
                "dbo.Customerrs",
                c => new
                    {
                        CustomerrId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.CustomerrId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CustomerrOrders", "Customerr_CustomerrId", "dbo.Customerrs");
            DropIndex("dbo.CustomerrOrders", new[] { "Customerr_CustomerrId" });
            DropTable("dbo.Customerrs");
            DropTable("dbo.CustomerrOrders");
        }
    }
}
