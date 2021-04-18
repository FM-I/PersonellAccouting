namespace StudenrsDB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Groups",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 15),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 15),
                        SecondName = c.String(maxLength: 15),
                        Surname = c.String(maxLength: 15),
                        Phone = c.String(maxLength: 12),
                        Address = c.String(maxLength: 100),
                        ParentOneName = c.String(maxLength: 15),
                        ParentOneSecondName = c.String(maxLength: 15),
                        ParentOneSurname = c.String(maxLength: 15),
                        ParentOnePhone = c.String(maxLength: 12),
                        ParentTwoName = c.String(maxLength: 15),
                        ParentTwoSecondName = c.String(),
                        ParentTwoSurname = c.String(maxLength: 15),
                        ParentTwoPhone = c.String(maxLength: 12),
                        SpecialtyId = c.Int(nullable: false),
                        GroupId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Groups", t => t.GroupId, cascadeDelete: true)
                .ForeignKey("dbo.Specialties", t => t.SpecialtyId, cascadeDelete: true)
                .Index(t => t.SpecialtyId)
                .Index(t => t.GroupId);
            
            CreateTable(
                "dbo.Specialties",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 15),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Students", "SpecialtyId", "dbo.Specialties");
            DropForeignKey("dbo.Students", "GroupId", "dbo.Groups");
            DropIndex("dbo.Students", new[] { "GroupId" });
            DropIndex("dbo.Students", new[] { "SpecialtyId" });
            DropTable("dbo.Specialties");
            DropTable("dbo.Students");
            DropTable("dbo.Groups");
        }
    }
}
