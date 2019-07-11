namespace Komunikaty.Repozytorium.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class startowa : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Messages",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ConfirmationRequired = c.Boolean(nullable: false),
                        Confirmed = c.Boolean(nullable: false),
                        Favourite = c.Boolean(nullable: false),
                        MessageType = c.Int(nullable: false),
                        Content = c.String(maxLength: 255),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Messages");
        }
    }
}
