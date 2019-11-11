namespace CodeFirstNewDatabaseSample.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAttribute : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Words", "Term", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Words", "Term", c => c.String());
        }
    }
}
