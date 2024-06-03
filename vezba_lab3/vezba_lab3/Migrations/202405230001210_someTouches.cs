namespace vezba_lab3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class someTouches : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Doctors", "Hospital_Id", "dbo.Hospitals");
            AddColumn("dbo.Doctors", "Hospital_Id1", c => c.Int());
            AddColumn("dbo.Hospitals", "Doctor_Id", c => c.Int());
            CreateIndex("dbo.Doctors", "Hospital_Id1");
            CreateIndex("dbo.Hospitals", "Doctor_Id");
            AddForeignKey("dbo.Hospitals", "Doctor_Id", "dbo.Doctors", "Id");
            AddForeignKey("dbo.Doctors", "Hospital_Id1", "dbo.Hospitals", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Doctors", "Hospital_Id1", "dbo.Hospitals");
            DropForeignKey("dbo.Hospitals", "Doctor_Id", "dbo.Doctors");
            DropIndex("dbo.Hospitals", new[] { "Doctor_Id" });
            DropIndex("dbo.Doctors", new[] { "Hospital_Id1" });
            DropColumn("dbo.Hospitals", "Doctor_Id");
            DropColumn("dbo.Doctors", "Hospital_Id1");
            AddForeignKey("dbo.Doctors", "Hospital_Id", "dbo.Hospitals", "Id");
        }
    }
}
