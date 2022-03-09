namespace CodeFirstIntegration.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class foreignKeyApplied : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Students", "ClassId", c => c.Int(nullable: false));
            AddColumn("dbo.Teachers", "ClassId", c => c.Int(nullable: false));
            CreateIndex("dbo.Students", "ClassId");
            CreateIndex("dbo.Teachers", "ClassId");
            AddForeignKey("dbo.Students", "ClassId", "dbo.Classes", "Id", cascadeDelete: false);
            AddForeignKey("dbo.Teachers", "ClassId", "dbo.Classes", "Id", cascadeDelete: true);
        }

        public override void Down()
        {
            DropForeignKey("dbo.Teachers", "ClassId", "dbo.Classes");
            DropForeignKey("dbo.Students", "ClassId", "dbo.Classes");
            DropIndex("dbo.Teachers", new[] { "ClassId" });
            DropIndex("dbo.Students", new[] { "ClassId" });
            DropColumn("dbo.Teachers", "ClassId");
            DropColumn("dbo.Students", "ClassId");
        }
    }
}