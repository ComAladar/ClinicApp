namespace ClinicAppDataBase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AppointmentNameAdd : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Appointments", "AppointmentName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Appointments", "AppointmentName");
        }
    }
}
