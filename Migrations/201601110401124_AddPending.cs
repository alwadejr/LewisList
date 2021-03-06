namespace LewisList.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPending : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Categories", "Category_CategoryId", c => c.Int());
            CreateIndex("dbo.Categories", "Category_CategoryId");
            AddForeignKey("dbo.Categories", "Category_CategoryId", "dbo.Categories", "CategoryId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Categories", "Category_CategoryId", "dbo.Categories");
            DropIndex("dbo.Categories", new[] { "Category_CategoryId" });
            DropColumn("dbo.Categories", "Category_CategoryId");
        }
    }
}
