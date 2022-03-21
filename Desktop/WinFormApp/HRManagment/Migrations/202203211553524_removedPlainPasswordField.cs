namespace HRManagment.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class removedPlainPasswordField : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.UserInfoes", "Password");
        }
        
        public override void Down()
        {
            AddColumn("dbo.UserInfoes", "Password", c => c.String());
        }
    }
}
