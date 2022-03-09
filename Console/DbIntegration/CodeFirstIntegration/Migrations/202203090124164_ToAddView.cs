namespace CodeFirstIntegration.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class ToAddView : DbMigration
    {
        public override void Up()
        {
            Sql("create view vw_studentView as \n\n Select * from Students");
        }

        public override void Down()
        {
            Sql("drop view vw_studentView");
        }
    }
}