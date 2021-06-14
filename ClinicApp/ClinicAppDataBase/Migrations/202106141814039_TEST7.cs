namespace ClinicAppDataBase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TEST7 : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Receipts", name: "ReceiptId", newName: "Id");
            RenameIndex(table: "dbo.Receipts", name: "IX_ReceiptId", newName: "IX_Id");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Receipts", name: "IX_Id", newName: "IX_ReceiptId");
            RenameColumn(table: "dbo.Receipts", name: "Id", newName: "ReceiptId");
        }
    }
}
