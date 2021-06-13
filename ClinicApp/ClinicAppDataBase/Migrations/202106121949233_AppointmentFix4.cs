namespace ClinicAppDataBase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AppointmentFix4 : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Appointments", new[] { "Id" });
            DropPrimaryKey("dbo.Appointments");
            AlterColumn("dbo.Appointments", "Id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Appointments", "Id");
            CreateIndex("dbo.Appointments", "Id", unique: true);
        }
        
        public override void Down()
        {
            DropIndex("dbo.Appointments", new[] { "Id" });
            DropPrimaryKey("dbo.Appointments");
            AlterColumn("dbo.Appointments", "Id", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.Appointments", "Id");
            CreateIndex("dbo.Appointments", "Id", unique: true);
        }
    }
}
