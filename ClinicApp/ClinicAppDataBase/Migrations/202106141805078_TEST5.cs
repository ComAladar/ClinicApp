namespace ClinicAppDataBase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TEST5 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Receipts", "Id", "dbo.Appointments");
            DropPrimaryKey("dbo.Appointments");
            DropColumn("dbo.Appointments", "AppointmentId");
            AddColumn("dbo.Appointments", "Id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Appointments", "Id");
            AddForeignKey("dbo.Receipts", "Id", "dbo.Appointments", "Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Appointments", "AppointmentId", c => c.Int(nullable: false, identity: true));
            DropForeignKey("dbo.Receipts", "Id", "dbo.Appointments");
            DropPrimaryKey("dbo.Appointments");
            DropColumn("dbo.Appointments", "Id");
            AddPrimaryKey("dbo.Appointments", "AppointmentId");
            AddForeignKey("dbo.Receipts", "Id", "dbo.Appointments", "AppointmentId");
        }
    }
}
