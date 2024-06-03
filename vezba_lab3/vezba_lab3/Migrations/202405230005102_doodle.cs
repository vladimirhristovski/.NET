namespace vezba_lab3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class doodle : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Doctors", "Hospital_Id1", "dbo.Hospitals");
            DropIndex("dbo.Doctors", new[] { "Hospital_Id1" });
            RenameColumn(table: "dbo.Doctors", name: "Hospital_Id1", newName: "HospitalId");
            AlterColumn("dbo.Doctors", "HospitalId", c => c.Int(nullable: false));
            CreateIndex("dbo.Doctors", "HospitalId");
            AddForeignKey("dbo.Doctors", "HospitalId", "dbo.Hospitals", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Doctors", "HospitalId", "dbo.Hospitals");
            DropIndex("dbo.Doctors", new[] { "HospitalId" });
            AlterColumn("dbo.Doctors", "HospitalId", c => c.Int());
            RenameColumn(table: "dbo.Doctors", name: "HospitalId", newName: "Hospital_Id1");
            CreateIndex("dbo.Doctors", "Hospital_Id1");
            AddForeignKey("dbo.Doctors", "Hospital_Id1", "dbo.Hospitals", "Id");
        }
    }
}
