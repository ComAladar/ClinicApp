namespace ClinicAppDataBase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ScheduleRemoval : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Schedules", "PatientId", "dbo.Patients");
            DropForeignKey("dbo.Schedules", "StaffId", "dbo.Staffs");
            DropForeignKey("dbo.Appointments", "Id", "dbo.Schedules");
            DropIndex("dbo.Appointments", new[] { "Id" });
            DropIndex("dbo.Schedules", new[] { "StaffId" });
            DropIndex("dbo.Schedules", new[] { "PatientId" });
            DropIndex("dbo.Schedules", new[] { "DateOfSchedule" });
            DropPrimaryKey("dbo.Appointments");
            AddColumn("dbo.Appointments", "DateOfSchedule", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2"));
            AddColumn("dbo.Appointments", "IsComplete", c => c.Int(nullable: false));
            AlterColumn("dbo.Appointments", "Id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Appointments", "Id");
            CreateIndex("dbo.Appointments", "DateOfSchedule", unique: true);
            DropTable("dbo.Schedules");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Schedules",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StaffId = c.Int(),
                        PatientId = c.Int(),
                        DateOfSchedule = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        IsComplete = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            DropIndex("dbo.Appointments", new[] { "DateOfSchedule" });
            DropPrimaryKey("dbo.Appointments");
            AlterColumn("dbo.Appointments", "Id", c => c.Int(nullable: false));
            DropColumn("dbo.Appointments", "IsComplete");
            DropColumn("dbo.Appointments", "DateOfSchedule");
            AddPrimaryKey("dbo.Appointments", "Id");
            CreateIndex("dbo.Schedules", "DateOfSchedule", unique: true);
            CreateIndex("dbo.Schedules", "PatientId");
            CreateIndex("dbo.Schedules", "StaffId");
            CreateIndex("dbo.Appointments", "Id");
            AddForeignKey("dbo.Appointments", "Id", "dbo.Schedules", "Id");
            AddForeignKey("dbo.Schedules", "StaffId", "dbo.Staffs", "Id");
            AddForeignKey("dbo.Schedules", "PatientId", "dbo.Patients", "Id");
        }
    }
}
