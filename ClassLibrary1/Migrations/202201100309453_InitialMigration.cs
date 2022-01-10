namespace ClassLibrary1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customer",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Address = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.OrderLine",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        SalesOrderID = c.Int(nullable: false),
                        ProductID = c.Int(nullable: false),
                        QtyOrder = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Product", t => t.ProductID, cascadeDelete: true)
                .ForeignKey("dbo.SalesOrder", t => t.SalesOrderID, cascadeDelete: true)
                .Index(t => t.SalesOrderID)
                .Index(t => t.ProductID);
            
            CreateTable(
                "dbo.Product",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                        FirstStock = c.DateTime(nullable: false),
                        UnitCost = c.Decimal(nullable: false, precision: 18, scale: 2),
                        QuantityInStock = c.Int(nullable: false),
                        ReOrderQuantity = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.SalesOrder",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CustomerID = c.Int(nullable: false),
                        orderDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Customer", t => t.CustomerID, cascadeDelete: true)
                .Index(t => t.CustomerID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OrderLine", "SalesOrderID", "dbo.SalesOrder");
            DropForeignKey("dbo.SalesOrder", "CustomerID", "dbo.Customer");
            DropForeignKey("dbo.OrderLine", "ProductID", "dbo.Product");
            DropIndex("dbo.SalesOrder", new[] { "CustomerID" });
            DropIndex("dbo.OrderLine", new[] { "ProductID" });
            DropIndex("dbo.OrderLine", new[] { "SalesOrderID" });
            DropTable("dbo.SalesOrder");
            DropTable("dbo.Product");
            DropTable("dbo.OrderLine");
            DropTable("dbo.Customer");
        }
    }
}
