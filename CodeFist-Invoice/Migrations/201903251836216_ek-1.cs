namespace CodeFist_Invoice.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ek1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.InvoiceDetails", "Description", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.InvoiceDetails", "Description", c => c.String(nullable: false));
        }
    }
}
