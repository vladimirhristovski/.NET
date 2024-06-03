namespace IT_lab3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class second : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.PatientDoctors", "Patient_Id", "dbo.Patients");
            DropForeignKey("dbo.PatientDoctors", "Doctor_Id", "dbo.Doctors");
            DropIndex("dbo.PatientDoctors", new[] { "Patient_Id" });
            DropIndex("dbo.PatientDoctors", new[] { "Doctor_Id" });
            AddColumn("dbo.Doctors", "PID", c => c.Int());
            AddColumn("dbo.Doctors", "Patient_Id", c => c.Int());
            AddColumn("dbo.Patients", "Doctor_Id", c => c.Int());
            AddColumn("dbo.Patients", "Doctor_Id1", c => c.Int());
            CreateIndex("dbo.Doctors", "Patient_Id");
            CreateIndex("dbo.Patients", "Doctor_Id");
            CreateIndex("dbo.Patients", "Doctor_Id1");
            AddForeignKey("dbo.Doctors", "Patient_Id", "dbo.Patients", "Id");
            AddForeignKey("dbo.Patients", "Doctor_Id", "dbo.Doctors", "Id");
            AddForeignKey("dbo.Patients", "Doctor_Id1", "dbo.Doctors", "Id");
            DropTable("dbo.PatientDoctors");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.PatientDoctors",
                c => new
                    {
                        Patient_Id = c.Int(nullable: false),
                        Doctor_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Patient_Id, t.Doctor_Id });
            
            DropForeignKey("dbo.Patients", "Doctor_Id1", "dbo.Doctors");
            DropForeignKey("dbo.Patients", "Doctor_Id", "dbo.Doctors");
            DropForeignKey("dbo.Doctors", "Patient_Id", "dbo.Patients");
            DropIndex("dbo.Patients", new[] { "Doctor_Id1" });
            DropIndex("dbo.Patients", new[] { "Doctor_Id" });
            DropIndex("dbo.Doctors", new[] { "Patient_Id" });
            DropColumn("dbo.Patients", "Doctor_Id1");
            DropColumn("dbo.Patients", "Doctor_Id");
            DropColumn("dbo.Doctors", "Patient_Id");
            DropColumn("dbo.Doctors", "PID");
            CreateIndex("dbo.PatientDoctors", "Doctor_Id");
            CreateIndex("dbo.PatientDoctors", "Patient_Id");
            AddForeignKey("dbo.PatientDoctors", "Doctor_Id", "dbo.Doctors", "Id", cascadeDelete: true);
            AddForeignKey("dbo.PatientDoctors", "Patient_Id", "dbo.Patients", "Id", cascadeDelete: true);
        }
    }
}
