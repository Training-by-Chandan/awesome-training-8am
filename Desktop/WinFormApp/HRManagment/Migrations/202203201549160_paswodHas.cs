namespace HRManagment.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class paswodHas : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.UserInfoes", "PasswordHash", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.UserInfoes", "PasswordHash");
        }
    }
}
