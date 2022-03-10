namespace WinFormApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class StudentAdded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.StudentInfo",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        LName = c.String(),
                        FName = c.String(),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.StudentInfo");
        }
    }
}
