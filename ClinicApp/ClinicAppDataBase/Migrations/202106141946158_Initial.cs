namespace ClinicAppDataBase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Appointments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PatientId = c.Int(),
                        StaffId = c.Int(),
                        AppointmentName = c.String(),
                        AppointmentType = c.Int(nullable: false),
                        Complains = c.String(),
                        Anamnesis = c.String(),
                        Condition = c.String(),
                        Diagnosis = c.String(),
                        ICDCode = c.String(),
                        Recommendations = c.String(),
                        MedicinalTherapy = c.String(),
                        DateOfSchedule = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        IsComplete = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Patients", t => t.PatientId)
                .ForeignKey("dbo.Staffs", t => t.StaffId)
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
                        Sex = c.Int(nullable: false),
                        DateOfBirth = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        DateOfRegistration = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        City = c.String(),
                        Street = c.String(),
                        House = c.String(),
                        Flat = c.String(),
                        Porch = c.String(),
                        PhoneNumber = c.String(),
                        Email = c.String(),
                        MiscInformation = c.String(),
                        InUse = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Receipts",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        StaffId = c.Int(),
                        ReceiptNumber = c.Int(nullable: false),
                        Price = c.Double(nullable: false),
                        Status = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Appointments", t => t.Id)
                .ForeignKey("dbo.Staffs", t => t.StaffId)
                .Index(t => t.Id)
                .Index(t => t.StaffId);
            
            CreateTable(
                "dbo.Staffs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Surname = c.String(),
                        Patronymic = c.String(),
                        Sex = c.Int(nullable: false),
                        DateOfBirth = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        DateOfRegistration = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        PhoneNumber = c.String(),
                        Email = c.String(),
                        Login = c.String(),
                        Password = c.String(),
                        Access = c.Int(nullable: false),
                        Qualification = c.String(),
                        Position = c.String(),
                        Speciality = c.String(),
                        DateOfEmployment = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        InUse = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.MessageBoards",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StaffId = c.Int(),
                        Name = c.String(),
                        Message = c.String(),
                        DateOfMessage = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Staffs", t => t.StaffId)
                .Index(t => t.StaffId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Receipts", "StaffId", "dbo.Staffs");
            DropForeignKey("dbo.MessageBoards", "StaffId", "dbo.Staffs");
            DropForeignKey("dbo.Appointments", "StaffId", "dbo.Staffs");
            DropForeignKey("dbo.Receipts", "Id", "dbo.Appointments");
            DropForeignKey("dbo.Appointments", "PatientId", "dbo.Patients");
            DropIndex("dbo.MessageBoards", new[] { "StaffId" });
            DropIndex("dbo.Receipts", new[] { "StaffId" });
            DropIndex("dbo.Receipts", new[] { "Id" });
            DropIndex("dbo.Appointments", new[] { "StaffId" });
            DropIndex("dbo.Appointments", new[] { "PatientId" });
            DropTable("dbo.MessageBoards");
            DropTable("dbo.Staffs");
            DropTable("dbo.Receipts");
            DropTable("dbo.Patients");
            DropTable("dbo.Appointments");
        }
    }
}
