namespace ClinicAppDataBase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ScheduleDateTimeUnique : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.Schedules", "DateOfSchedule", unique: true);
        }
        
        public override void Down()
        {
            DropIndex("dbo.Schedules", new[] { "DateOfSchedule" });
        }
    }
}
