namespace ClinicAppDataBase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DateTimereadonlyfix : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Patients", "DateOfRegistration", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2"));
            AddColumn("dbo.Staffs", "DateOfRegistration", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2"));
            AddColumn("dbo.MessageBoards", "DateOfMessage", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2"));
        }
        
        public override void Down()
        {
            DropColumn("dbo.MessageBoards", "DateOfMessage");
            DropColumn("dbo.Staffs", "DateOfRegistration");
            DropColumn("dbo.Patients", "DateOfRegistration");
        }
    }
}
