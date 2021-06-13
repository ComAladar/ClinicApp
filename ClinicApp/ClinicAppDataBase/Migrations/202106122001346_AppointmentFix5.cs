namespace ClinicAppDataBase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AppointmentFix5 : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Appointments", new[] { "Id" });
        }
        
        public override void Down()
        {
            CreateIndex("dbo.Appointments", "Id", unique: true);
        }
    }
}
