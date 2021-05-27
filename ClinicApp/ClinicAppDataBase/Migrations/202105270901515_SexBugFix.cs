namespace ClinicAppDataBase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SexBugFix : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Patients", "Sex", c => c.Int(nullable: false));
            AddColumn("dbo.Staffs", "Sex", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Staffs", "Sex");
            DropColumn("dbo.Patients", "Sex");
        }
    }
}
