namespace Ecom.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class productAdded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Products",
                c => new
                {
                    Id = c.Guid(nullable: false),
                    Name = c.String(),
                    Description = c.String(),
                    Price = c.Double(nullable: false),
                    CategoryId = c.Guid(nullable: false),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.CategoryId, cascadeDelete: true)
                .Index(t => t.CategoryId);
        }

        public override void Down()
        {
            DropForeignKey("dbo.Products", "CategoryId", "dbo.Categories");
            DropIndex("dbo.Products", new[] { "CategoryId" });
            DropTable("dbo.Products");
        }
    }
}