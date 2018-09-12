namespace Catalogue.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EditLengthCategoryName : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Categories", "Index1");
            DropIndex("dbo.Categories", "Index2");
            AlterColumn("dbo.Categories", "Name", c => c.String(maxLength: 150, unicode: false));
            CreateIndex("dbo.Categories", "Name", name: "Index1");
            CreateIndex("dbo.Categories", "Name", unique: true, name: "Index2");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Categories", "Index2");
            DropIndex("dbo.Categories", "Index1");
            AlterColumn("dbo.Categories", "Name", c => c.String(maxLength: 3, unicode: false));
            CreateIndex("dbo.Categories", "Name", unique: true, name: "Index2");
            CreateIndex("dbo.Categories", "Name", name: "Index1");
        }
    }
}
