namespace ClinicAppDataBase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DateTimeTest : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Schedules", new[] { "DateOfSchedule" });
            AlterColumn("dbo.Schedules", "DateOfSchedule", c => c.DateTime(nullable: false));
            CreateIndex("dbo.Schedules", "DateOfSchedule", unique: true);
        }
        
        public override void Down()
        {
            DropIndex("dbo.Schedules", new[] { "DateOfSchedule" });
            AlterColumn("dbo.Schedules", "DateOfSchedule", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2"));
            CreateIndex("dbo.Schedules", "DateOfSchedule", unique: true);
        }
    }
}
