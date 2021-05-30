namespace ClinicAppDataBase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AppointmentCompletionField : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Appointments", "IsComplete", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Appointments", "IsComplete");
        }
    }
}
