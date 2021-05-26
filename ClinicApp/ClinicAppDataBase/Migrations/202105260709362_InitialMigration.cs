namespace ClinicAppDataBase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Appointments",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        PatientId = c.Int(),
                        StaffId = c.Int(),
                        AppointmentType = c.Int(nullable: false),
                        DateOfAppointment = c.DateTime(nullable: false),
                        Complains = c.String(),
                        Anamnesis = c.String(),
                        Condition = c.String(),
                        Diagnosis = c.String(),
                        ICDCode = c.String(),
                        Recomendations = c.String(),
                        MedicinalTherapy = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Patients", t => t.PatientId)
                .ForeignKey("dbo.Staffs", t => t.StaffId)
                .ForeignKey("dbo.Schedules", t => t.Id)
                .Index(t => t.Id)
                .Index(t => t.PatientId)
                .Index(t => t.StaffId);
            
            CreateTable(
                "dbo.Patients",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Surname = c.String(),
                        Patronymic = c.String(),
                        DateOfBirth = c.DateTime(nullable: false),
                        City = c.String(),
                        Street = c.String(),
                        House = c.String(),
                        Flat = c.String(),
                        Porch = c.String(),
                        PhoneNumber = c.String(),
                        Email = c.String(),
                        MiscInformation = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Schedules",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StaffId = c.Int(),
                        PatientId = c.Int(),
                        DateOfSchedule = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Patients", t => t.PatientId)
                .ForeignKey("dbo.Staffs", t => t.StaffId)
                .Index(t => t.StaffId)
                .Index(t => t.PatientId);
            
            CreateTable(
                "dbo.Staffs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Surname = c.String(),
                        Patronymic = c.String(),
                        DateOfBirth = c.DateTime(nullable: false),
                        PhoneNumber = c.String(),
                        Email = c.String(),
                        Login = c.String(),
                        Password = c.String(),
                        Access = c.Int(nullable: false),
                        Qualification = c.String(),
                        Position = c.String(),
                        Speciality = c.String(),
                        DateOfEmployment = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.MessageBoards",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StaffId = c.Int(),
                        DateOfMessage = c.DateTime(nullable: false),
                        Name = c.String(),
                        Message = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Staffs", t => t.StaffId)
                .Index(t => t.StaffId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Appointments", "Id", "dbo.Schedules");
            DropForeignKey("dbo.Schedules", "StaffId", "dbo.Staffs");
            DropForeignKey("dbo.MessageBoards", "StaffId", "dbo.Staffs");
            DropForeignKey("dbo.Appointments", "StaffId", "dbo.Staffs");
            DropForeignKey("dbo.Schedules", "PatientId", "dbo.Patients");
            DropForeignKey("dbo.Appointments", "PatientId", "dbo.Patients");
            DropIndex("dbo.MessageBoards", new[] { "StaffId" });
            DropIndex("dbo.Schedules", new[] { "PatientId" });
            DropIndex("dbo.Schedules", new[] { "StaffId" });
            DropIndex("dbo.Appointments", new[] { "StaffId" });
            DropIndex("dbo.Appointments", new[] { "PatientId" });
            DropIndex("dbo.Appointments", new[] { "Id" });
            DropTable("dbo.MessageBoards");
            DropTable("dbo.Staffs");
            DropTable("dbo.Schedules");
            DropTable("dbo.Patients");
            DropTable("dbo.Appointments");
        }
    }
}
