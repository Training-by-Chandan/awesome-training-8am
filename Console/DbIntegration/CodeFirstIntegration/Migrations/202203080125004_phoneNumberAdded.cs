namespace CodeFirstIntegration.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class phoneNumberAdded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Students", "PhoneNumber", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Students", "PhoneNumber");
        }
    }
}
