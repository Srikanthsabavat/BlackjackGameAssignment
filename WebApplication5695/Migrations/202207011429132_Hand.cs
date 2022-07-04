namespace WebApplication5695.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Hand : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cards",
                c => new
                    {
                        CardNo = c.Int(nullable: false, identity: true),
                        CardName = c.String(),
                        CardValue = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CardNo);
            
            CreateTable(
                "dbo.Sessions",
                c => new
                    {
                        GameNo = c.Int(nullable: false, identity: true),
                        PlayerTotal = c.Int(nullable: false),
                        DealerTotal = c.Int(nullable: false),
                        GameResult = c.String(),
                    })
                .PrimaryKey(t => t.GameNo);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Sessions");
            DropTable("dbo.Cards");
        }
    }
}
