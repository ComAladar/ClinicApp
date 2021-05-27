namespace ClinicAppDataBase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BLLEdits : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Appointments", "Recommendations", c => c.String());
            DropColumn("dbo.Appointments", "DateOfAppointment");
            DropColumn("dbo.Appointments", "Recomendations");
            DropColumn("dbo.MessageBoards", "DateOfMessage");
        }
        
        public override void Down()
        {
            AddColumn("dbo.MessageBoards", "DateOfMessage", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2"));
            AddColumn("dbo.Appointments", "Recomendations", c => c.String());
            AddColumn("dbo.Appointments", "DateOfAppointment", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2"));
            DropColumn("dbo.Appointments", "Recommendations");
        }
    }
}
