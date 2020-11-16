namespace Conference.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddRepoURL : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Sessions", "RepoURL", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Sessions", "RepoURL");
        }
    }
}
