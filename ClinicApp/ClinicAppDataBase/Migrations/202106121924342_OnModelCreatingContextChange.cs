namespace ClinicAppDataBase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class OnModelCreatingContextChange : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Appointments", new[] { "DateOfSchedule" });
        }
        
        public override void Down()
        {
            CreateIndex("dbo.Appointments", "DateOfSchedule", unique: true);
        }
    }
}
