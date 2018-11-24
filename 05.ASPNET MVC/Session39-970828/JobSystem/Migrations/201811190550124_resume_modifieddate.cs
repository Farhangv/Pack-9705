namespace JobSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class resume_modifieddate : DbMigration
    {
        public override void Up()
        {
            AddColumn("Jobs.Resume", "ModifiedDate", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("Jobs.Resume", "ModifiedDate");
        }
    }
}
