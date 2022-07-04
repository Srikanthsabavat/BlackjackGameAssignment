namespace WebApplication5695.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Come : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Cards", "CardValue", c => c.Int());
            AlterColumn("dbo.Sessions", "PlayerTotal", c => c.Int());
            AlterColumn("dbo.Sessions", "DealerTotal", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Sessions", "DealerTotal", c => c.Int(nullable: false));
            AlterColumn("dbo.Sessions", "PlayerTotal", c => c.Int(nullable: false));
            AlterColumn("dbo.Cards", "CardValue", c => c.Int(nullable: false));
        }
    }
}
