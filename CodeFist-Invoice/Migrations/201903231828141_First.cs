namespace CodeFist_Invoice.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class First : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cities",
                c => new
                    {
                        CityID = c.Int(nullable: false, identity: true),
                        Description = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.CityID);
            
            CreateTable(
                "dbo.Counties",
                c => new
                    {
                        CountyID = c.Int(nullable: false, identity: true),
                        Description = c.String(nullable: false),
                        CityID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CountyID)
                .ForeignKey("dbo.Cities", t => t.CityID, cascadeDelete: true)
                .Index(t => t.CityID);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        CustomerID = c.Int(nullable: false, identity: true),
                        CompanyName = c.String(),
                        CountyID = c.Int(nullable: false),
                        Adress = c.String(),
                    })
                .PrimaryKey(t => t.CustomerID)
                .ForeignKey("dbo.Counties", t => t.CountyID, cascadeDelete: true)
                .Index(t => t.CountyID);
            
            CreateTable(
                "dbo.InvoiceHeaders",
                c => new
                    {
                        InvoiceID = c.Int(nullable: false, identity: true),
                        CustomerID = c.Int(nullable: false),
                        InvoiceDate = c.DateTime(nullable: false),
                        DeliveryNote = c.Int(nullable: false),
                        PaymentDate = c.DateTime(nullable: false),
                        TotalAmount = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.InvoiceID)
                .ForeignKey("dbo.Customers", t => t.CustomerID, cascadeDelete: true)
                .Index(t => t.CustomerID);
            
            CreateTable(
                "dbo.InvoiceDetails",
                c => new
                    {
                        InvoiceID = c.Int(nullable: false),
                        ProductID = c.Int(nullable: false),
                        Quantity = c.Int(nullable: false),
                        UnitPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        VatAmount = c.Double(nullable: false),
                        Description = c.String(nullable: false),
                    })
                .PrimaryKey(t => new { t.InvoiceID, t.ProductID });
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ProductID = c.Int(nullable: false, identity: true),
                        ProductName = c.String(),
                        ProductCode = c.Int(nullable: false),
                        UnitID = c.Int(nullable: false),
                        UnitPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        invoiceDetail_InvoiceID = c.Int(),
                        invoiceDetail_ProductID = c.Int(),
                    })
                .PrimaryKey(t => t.ProductID)
                .ForeignKey("dbo.InvoiceDetails", t => new { t.invoiceDetail_InvoiceID, t.invoiceDetail_ProductID })
                .ForeignKey("dbo.Units", t => t.UnitID, cascadeDelete: true)
                .Index(t => t.UnitID)
                .Index(t => new { t.invoiceDetail_InvoiceID, t.invoiceDetail_ProductID });
            
            CreateTable(
                "dbo.Units",
                c => new
                    {
                        UnitID = c.Int(nullable: false, identity: true),
                        UnitName = c.String(),
                    })
                .PrimaryKey(t => t.UnitID);
            
            CreateTable(
                "dbo.InvoiceDetailInvoiceHeaders",
                c => new
                    {
                        InvoiceDetail_InvoiceID = c.Int(nullable: false),
                        InvoiceDetail_ProductID = c.Int(nullable: false),
                        InvoiceHeader_InvoiceID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.InvoiceDetail_InvoiceID, t.InvoiceDetail_ProductID, t.InvoiceHeader_InvoiceID })
                .ForeignKey("dbo.InvoiceDetails", t => new { t.InvoiceDetail_InvoiceID, t.InvoiceDetail_ProductID }, cascadeDelete: true)
                .ForeignKey("dbo.InvoiceHeaders", t => t.InvoiceHeader_InvoiceID, cascadeDelete: true)
                .Index(t => new { t.InvoiceDetail_InvoiceID, t.InvoiceDetail_ProductID })
                .Index(t => t.InvoiceHeader_InvoiceID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "UnitID", "dbo.Units");
            DropForeignKey("dbo.Products", new[] { "invoiceDetail_InvoiceID", "invoiceDetail_ProductID" }, "dbo.InvoiceDetails");
            DropForeignKey("dbo.InvoiceDetailInvoiceHeaders", "InvoiceHeader_InvoiceID", "dbo.InvoiceHeaders");
            DropForeignKey("dbo.InvoiceDetailInvoiceHeaders", new[] { "InvoiceDetail_InvoiceID", "InvoiceDetail_ProductID" }, "dbo.InvoiceDetails");
            DropForeignKey("dbo.InvoiceHeaders", "CustomerID", "dbo.Customers");
            DropForeignKey("dbo.Customers", "CountyID", "dbo.Counties");
            DropForeignKey("dbo.Counties", "CityID", "dbo.Cities");
            DropIndex("dbo.InvoiceDetailInvoiceHeaders", new[] { "InvoiceHeader_InvoiceID" });
            DropIndex("dbo.InvoiceDetailInvoiceHeaders", new[] { "InvoiceDetail_InvoiceID", "InvoiceDetail_ProductID" });
            DropIndex("dbo.Products", new[] { "invoiceDetail_InvoiceID", "invoiceDetail_ProductID" });
            DropIndex("dbo.Products", new[] { "UnitID" });
            DropIndex("dbo.InvoiceHeaders", new[] { "CustomerID" });
            DropIndex("dbo.Customers", new[] { "CountyID" });
            DropIndex("dbo.Counties", new[] { "CityID" });
            DropTable("dbo.InvoiceDetailInvoiceHeaders");
            DropTable("dbo.Units");
            DropTable("dbo.Products");
            DropTable("dbo.InvoiceDetails");
            DropTable("dbo.InvoiceHeaders");
            DropTable("dbo.Customers");
            DropTable("dbo.Counties");
            DropTable("dbo.Cities");
        }
    }
}
