namespace JobSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class jobs_corrections : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "Jobs.Resume",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(maxLength: 50),
                        ResumeFile = c.Binary(),
                        MimeType = c.String(maxLength: 20),
                        OriginalFileName = c.String(maxLength: 100),
                        FileSize = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AlterColumn("dbo.AspNetUsers", "Name", c => c.String(maxLength: 50));
            AlterColumn("dbo.AspNetUsers", "Family", c => c.String(maxLength: 50));
            AlterColumn("dbo.AspNetUsers", "BirthDate", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2"));
            AlterColumn("dbo.AspNetUsers", "Gender", c => c.String(maxLength: 1));
            AlterColumn("dbo.AspNetUsers", "PhotoFilePath", c => c.String(maxLength: 200));
            CreateIndex("Jobs.Company", "Phone", unique: true);
        }
        
        public override void Down()
        {
            DropIndex("Jobs.Company", new[] { "Phone" });
            AlterColumn("dbo.AspNetUsers", "PhotoFilePath", c => c.String());
            AlterColumn("dbo.AspNetUsers", "Gender", c => c.String());
            AlterColumn("dbo.AspNetUsers", "BirthDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.AspNetUsers", "Family", c => c.String());
            AlterColumn("dbo.AspNetUsers", "Name", c => c.String());
            DropTable("Jobs.Resume");
        }
    }
}
