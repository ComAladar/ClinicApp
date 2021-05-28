namespace ClinicAppDataBase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InUseAddMigration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Patients", "InUse", c => c.Int(nullable: false));
            AddColumn("dbo.Schedules", "InUse", c => c.Int(nullable: false));
            AddColumn("dbo.Staffs", "InUse", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Staffs", "InUse");
            DropColumn("dbo.Schedules", "InUse");
            DropColumn("dbo.Patients", "InUse");
        }
    }
}
