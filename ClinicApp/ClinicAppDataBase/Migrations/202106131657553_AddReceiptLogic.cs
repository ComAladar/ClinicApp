namespace ClinicAppDataBase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddReceiptLogic : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Receipts");
            AddColumn("dbo.Receipts", "StaffId", c => c.Int());
            AddColumn("dbo.Receipts", "ReceiptNumber", c => c.Int(nullable: false));
            AddColumn("dbo.Receipts", "Price", c => c.Double(nullable: false));
            AddColumn("dbo.Receipts", "Status", c => c.Int(nullable: false));
            AlterColumn("dbo.Receipts", "Id", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.Receipts", "Id");
            CreateIndex("dbo.Receipts", "Id");
            CreateIndex("dbo.Receipts", "StaffId");
            AddForeignKey("dbo.Receipts", "Id", "dbo.Appointments", "AppointmentId");
            AddForeignKey("dbo.Receipts", "StaffId", "dbo.Staffs", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Receipts", "StaffId", "dbo.Staffs");
            DropForeignKey("dbo.Receipts", "Id", "dbo.Appointments");
            DropIndex("dbo.Receipts", new[] { "StaffId" });
            DropIndex("dbo.Receipts", new[] { "Id" });
            DropPrimaryKey("dbo.Receipts");
            AlterColumn("dbo.Receipts", "Id", c => c.Int(nullable: false, identity: true));
            DropColumn("dbo.Receipts", "Status");
            DropColumn("dbo.Receipts", "Price");
            DropColumn("dbo.Receipts", "ReceiptNumber");
            DropColumn("dbo.Receipts", "StaffId");
            AddPrimaryKey("dbo.Receipts", "Id");
        }
    }
}
