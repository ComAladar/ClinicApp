namespace ClinicAppDataBase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DateTimeChanged : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Appointments", "DateOfAppointment", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2"));
            AlterColumn("dbo.Patients", "DateOfBirth", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2"));
            AlterColumn("dbo.Schedules", "DateOfSchedule", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2"));
            AlterColumn("dbo.Staffs", "DateOfBirth", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2"));
            AlterColumn("dbo.Staffs", "DateOfEmployment", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2"));
            AlterColumn("dbo.MessageBoards", "DateOfMessage", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2"));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.MessageBoards", "DateOfMessage", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Staffs", "DateOfEmployment", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Staffs", "DateOfBirth", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Schedules", "DateOfSchedule", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Patients", "DateOfBirth", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Appointments", "DateOfAppointment", c => c.DateTime(nullable: false));
        }
    }
}
