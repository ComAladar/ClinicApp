namespace ClinicAppDataBase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TestAppointmentIDFix : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Appointments");
            AlterColumn("dbo.Appointments", "Id", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.Appointments", "Id");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Appointments");
            AlterColumn("dbo.Appointments", "Id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Appointments", "Id");
        }
    }
}
