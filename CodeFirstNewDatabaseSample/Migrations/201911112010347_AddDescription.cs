﻿namespace CodeFirstNewDatabaseSample.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDescription : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Words", "Description", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Words", "Description");
        }
    }
}
