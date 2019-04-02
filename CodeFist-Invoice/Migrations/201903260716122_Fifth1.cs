namespace CodeFist_Invoice.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Fifth1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.InvoiceDetails", "VatAmount", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.InvoiceDetails", "VatAmount", c => c.Double(nullable: false));
        }
    }
}
