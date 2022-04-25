namespace Ecom.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FilePathAdded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "FilePath", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "FilePath");
        }
    }
}
