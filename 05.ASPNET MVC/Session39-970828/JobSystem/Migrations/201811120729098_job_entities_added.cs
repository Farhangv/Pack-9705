namespace JobSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class job_entities_added : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "Jobs.Company",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100),
                        Phone = c.String(nullable: false, maxLength: 8000, unicode: false),
                        Email = c.String(maxLength: 100),
                        Website = c.String(maxLength: 100),
                        LogoFilePath = c.String(),
                        Description = c.String(maxLength: 400),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "Jobs.Job",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(maxLength: 100),
                        Description = c.String(maxLength: 1000),
                        ValidDate = c.DateTime(nullable: false),
                        Location = c.String(maxLength: 50),
                        Count = c.Int(nullable: false),
                        Wage = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.AspNetUsers", "Name", c => c.String());
            AddColumn("dbo.AspNetUsers", "Family", c => c.String());
            AddColumn("dbo.AspNetUsers", "BirthDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.AspNetUsers", "Gender", c => c.String());
            AddColumn("dbo.AspNetUsers", "PhotoFilePath", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "PhotoFilePath");
            DropColumn("dbo.AspNetUsers", "Gender");
            DropColumn("dbo.AspNetUsers", "BirthDate");
            DropColumn("dbo.AspNetUsers", "Family");
            DropColumn("dbo.AspNetUsers", "Name");
            DropTable("Jobs.Job");
            DropTable("Jobs.Company");
        }
    }
}
