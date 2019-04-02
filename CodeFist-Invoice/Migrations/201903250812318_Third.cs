namespace CodeFist_Invoice.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Third : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Products", new[] { "invoiceDetail_InvoiceID", "invoiceDetail_ProductID" }, "dbo.InvoiceDetails");
            DropIndex("dbo.Products", new[] { "invoiceDetail_InvoiceID", "invoiceDetail_ProductID" });
            CreateIndex("dbo.InvoiceDetails", "ProductID");
            AddForeignKey("dbo.InvoiceDetails", "ProductID", "dbo.Products", "ProductID", cascadeDelete: true);
            DropColumn("dbo.Products", "invoiceDetail_InvoiceID");
            DropColumn("dbo.Products", "invoiceDetail_ProductID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "invoiceDetail_ProductID", c => c.Int());
            AddColumn("dbo.Products", "invoiceDetail_InvoiceID", c => c.Int());
            DropForeignKey("dbo.InvoiceDetails", "ProductID", "dbo.Products");
            DropIndex("dbo.InvoiceDetails", new[] { "ProductID" });
            CreateIndex("dbo.Products", new[] { "invoiceDetail_InvoiceID", "invoiceDetail_ProductID" });
            AddForeignKey("dbo.Products", new[] { "invoiceDetail_InvoiceID", "invoiceDetail_ProductID" }, "dbo.InvoiceDetails", new[] { "InvoiceID", "ProductID" });
        }
    }
}
