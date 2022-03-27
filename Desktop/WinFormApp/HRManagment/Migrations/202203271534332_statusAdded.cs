namespace HRManagment.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class statusAdded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Leaves", "Status", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Leaves", "Status");
        }
    }
}
