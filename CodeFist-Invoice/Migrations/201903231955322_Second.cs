namespace CodeFist_Invoice.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Second : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.InvoiceDetailInvoiceHeaders", new[] { "InvoiceDetail_InvoiceID", "InvoiceDetail_ProductID" }, "dbo.InvoiceDetails");
            DropForeignKey("dbo.InvoiceDetailInvoiceHeaders", "InvoiceHeader_InvoiceID", "dbo.InvoiceHeaders");
            DropIndex("dbo.InvoiceDetailInvoiceHeaders", new[] { "InvoiceDetail_InvoiceID", "InvoiceDetail_ProductID" });
            DropIndex("dbo.InvoiceDetailInvoiceHeaders", new[] { "InvoiceHeader_InvoiceID" });
            AlterColumn("dbo.Cities", "Description", c => c.String());
            CreateIndex("dbo.InvoiceDetails", "InvoiceID");
            AddForeignKey("dbo.InvoiceDetails", "InvoiceID", "dbo.InvoiceHeaders", "InvoiceID", cascadeDelete: true);
            DropTable("dbo.InvoiceDetailInvoiceHeaders");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.InvoiceDetailInvoiceHeaders",
                c => new
                    {
                        InvoiceDetail_InvoiceID = c.Int(nullable: false),
                        InvoiceDetail_ProductID = c.Int(nullable: false),
                        InvoiceHeader_InvoiceID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.InvoiceDetail_InvoiceID, t.InvoiceDetail_ProductID, t.InvoiceHeader_InvoiceID });
            
            DropForeignKey("dbo.InvoiceDetails", "InvoiceID", "dbo.InvoiceHeaders");
            DropIndex("dbo.InvoiceDetails", new[] { "InvoiceID" });
            AlterColumn("dbo.Cities", "Description", c => c.String(nullable: false));
            CreateIndex("dbo.InvoiceDetailInvoiceHeaders", "InvoiceHeader_InvoiceID");
            CreateIndex("dbo.InvoiceDetailInvoiceHeaders", new[] { "InvoiceDetail_InvoiceID", "InvoiceDetail_ProductID" });
            AddForeignKey("dbo.InvoiceDetailInvoiceHeaders", "InvoiceHeader_InvoiceID", "dbo.InvoiceHeaders", "InvoiceID", cascadeDelete: true);
            AddForeignKey("dbo.InvoiceDetailInvoiceHeaders", new[] { "InvoiceDetail_InvoiceID", "InvoiceDetail_ProductID" }, "dbo.InvoiceDetails", new[] { "InvoiceID", "ProductID" }, cascadeDelete: true);
        }
    }
}
