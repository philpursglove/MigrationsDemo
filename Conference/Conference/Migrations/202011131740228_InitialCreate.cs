namespace Conference.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Sessions",
                c => new
                    {
                        SessionId = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Abstract = c.String(),
                    })
                .PrimaryKey(t => t.SessionId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Sessions");
        }
    }
}
