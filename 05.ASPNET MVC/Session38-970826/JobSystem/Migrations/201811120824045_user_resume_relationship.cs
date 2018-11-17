namespace JobSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class user_resume_relationship : DbMigration
    {
        public override void Up()
        {
            AddColumn("Jobs.Resume", "User_Id", c => c.String(nullable: false, maxLength: 128));
            CreateIndex("Jobs.Resume", "User_Id");
            AddForeignKey("Jobs.Resume", "User_Id", "dbo.AspNetUsers", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("Jobs.Resume", "User_Id", "dbo.AspNetUsers");
            DropIndex("Jobs.Resume", new[] { "User_Id" });
            DropColumn("Jobs.Resume", "User_Id");
        }
    }
}
