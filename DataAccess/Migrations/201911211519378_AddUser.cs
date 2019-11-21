namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddUser : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Username = c.String(nullable: false),
                        Password = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Words", "UserId", c => c.Int(nullable: false));
            CreateIndex("dbo.Words", "UserId");
            AddForeignKey("dbo.Words", "UserId", "dbo.Users", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Words", "UserId", "dbo.Users");
            DropIndex("dbo.Words", new[] { "UserId" });
            DropColumn("dbo.Words", "UserId");
            DropTable("dbo.Users");
        }
    }
}
