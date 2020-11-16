namespace Conference.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddSpeakerName : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Sessions", "SpeakerName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Sessions", "SpeakerName");
        }
    }
}
