namespace ClinicAppDataBase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AppointmentFix2 : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.Appointments", "Id", unique: true);
        }
        
        public override void Down()
        {
            DropIndex("dbo.Appointments", new[] { "Id" });
        }
    }
}
