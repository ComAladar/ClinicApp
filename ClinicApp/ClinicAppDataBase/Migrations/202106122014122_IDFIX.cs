namespace ClinicAppDataBase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IDFIX : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Appointments");
            AddColumn("dbo.Appointments", "AppointmentId", c => c.Int(nullable: false, identity: true));
            AddColumn("dbo.Appointments", "AppointmentType", c => c.Int(nullable: false));
            AddColumn("dbo.Appointments", "Complains", c => c.String());
            AddColumn("dbo.Appointments", "Anamnesis", c => c.String());
            AddColumn("dbo.Appointments", "Condition", c => c.String());
            AddColumn("dbo.Appointments", "Diagnosis", c => c.String());
            AddColumn("dbo.Appointments", "ICDCode", c => c.String());
            AddColumn("dbo.Appointments", "Recommendations", c => c.String());
            AddColumn("dbo.Appointments", "MedicinalTherapy", c => c.String());
            AddColumn("dbo.Appointments", "DateOfSchedule", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2"));
            AddColumn("dbo.Appointments", "IsComplete", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.Appointments", "AppointmentId");
            DropColumn("dbo.Appointments", "Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Appointments", "Id", c => c.Int(nullable: false, identity: true));
            DropPrimaryKey("dbo.Appointments");
            DropColumn("dbo.Appointments", "IsComplete");
            DropColumn("dbo.Appointments", "DateOfSchedule");
            DropColumn("dbo.Appointments", "MedicinalTherapy");
            DropColumn("dbo.Appointments", "Recommendations");
            DropColumn("dbo.Appointments", "ICDCode");
            DropColumn("dbo.Appointments", "Diagnosis");
            DropColumn("dbo.Appointments", "Condition");
            DropColumn("dbo.Appointments", "Anamnesis");
            DropColumn("dbo.Appointments", "Complains");
            DropColumn("dbo.Appointments", "AppointmentType");
            DropColumn("dbo.Appointments", "AppointmentId");
            AddPrimaryKey("dbo.Appointments", "Id");
        }
    }
}
