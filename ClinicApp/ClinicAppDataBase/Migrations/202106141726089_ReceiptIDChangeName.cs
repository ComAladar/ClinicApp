namespace ClinicAppDataBase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ReceiptIDChangeName : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Receipts", name: "Id", newName: "ReceiptId");
            RenameIndex(table: "dbo.Receipts", name: "IX_Id", newName: "IX_ReceiptId");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Receipts", name: "IX_ReceiptId", newName: "IX_Id");
            RenameColumn(table: "dbo.Receipts", name: "ReceiptId", newName: "Id");
        }
    }
}
