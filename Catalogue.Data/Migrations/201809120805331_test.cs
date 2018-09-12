namespace Catalogue.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "Test", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "Test");
        }
    }
}
