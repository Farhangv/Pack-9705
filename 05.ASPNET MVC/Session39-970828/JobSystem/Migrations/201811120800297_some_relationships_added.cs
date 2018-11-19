namespace JobSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class some_relationships_added : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "Jobs.Jobs_Resumes",
                c => new
                    {
                        Job_Id = c.Int(nullable: false),
                        Resume_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Job_Id, t.Resume_Id })
                .ForeignKey("Jobs.Job", t => t.Job_Id, cascadeDelete: true)
                .ForeignKey("Jobs.Resume", t => t.Resume_Id, cascadeDelete: true)
                .Index(t => t.Job_Id)
                .Index(t => t.Resume_Id);
            
            AddColumn("Jobs.Job", "CompanyId", c => c.Int(nullable: false));
            CreateIndex("Jobs.Job", "CompanyId");
            AddForeignKey("Jobs.Job", "CompanyId", "Jobs.Company", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("Jobs.Jobs_Resumes", "Resume_Id", "Jobs.Resume");
            DropForeignKey("Jobs.Jobs_Resumes", "Job_Id", "Jobs.Job");
            DropForeignKey("Jobs.Job", "CompanyId", "Jobs.Company");
            DropIndex("Jobs.Jobs_Resumes", new[] { "Resume_Id" });
            DropIndex("Jobs.Jobs_Resumes", new[] { "Job_Id" });
            DropIndex("Jobs.Job", new[] { "CompanyId" });
            DropColumn("Jobs.Job", "CompanyId");
            DropTable("Jobs.Jobs_Resumes");
        }
    }
}
