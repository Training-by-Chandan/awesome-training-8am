﻿namespace CodeFirstIntegration.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class AttribAdded : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Students", "Name", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Students", "Email", c => c.String(nullable: false, maxLength: 50));
        }

        public override void Down()
        {
            AlterColumn("dbo.Students", "Email", c => c.String());
            AlterColumn("dbo.Students", "Name", c => c.String());
        }
    }
}