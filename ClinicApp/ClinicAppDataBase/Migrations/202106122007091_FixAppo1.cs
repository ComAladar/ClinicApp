namespace ClinicAppDataBase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FixAppo1 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Appointments", "AppointmentType");
            DropColumn("dbo.Appointments", "Complains");
            DropColumn("dbo.Appointments", "Anamnesis");
            DropColumn("dbo.Appointments", "Condition");
            DropColumn("dbo.Appointments", "Diagnosis");
            DropColumn("dbo.Appointments", "ICDCode");
            DropColumn("dbo.Appointments", "Recommendations");
            DropColumn("dbo.Appointments", "MedicinalTherapy");
            DropColumn("dbo.Appointments", "DateOfSchedule");
            DropColumn("dbo.Appointments", "IsComplete");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Appointments", "IsComplete", c => c.Int(nullable: false));
            AddColumn("dbo.Appointments", "DateOfSchedule", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2"));
            AddColumn("dbo.Appointments", "MedicinalTherapy", c => c.String());
            AddColumn("dbo.Appointments", "Recommendations", c => c.String());
            AddColumn("dbo.Appointments", "ICDCode", c => c.String());
            AddColumn("dbo.Appointments", "Diagnosis", c => c.String());
            AddColumn("dbo.Appointments", "Condition", c => c.String());
            AddColumn("dbo.Appointments", "Anamnesis", c => c.String());
            AddColumn("dbo.Appointments", "Complains", c => c.String());
            AddColumn("dbo.Appointments", "AppointmentType", c => c.Int(nullable: false));
        }
    }
}
