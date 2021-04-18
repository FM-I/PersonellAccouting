namespace StudenrsDB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RowYearEntry : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Students", "YearEntry", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Students", "YearEntry");
        }
    }
}
