namespace EFCodeFirst.Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Inventories",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        MaterialID = c.Int(nullable: false),
                        Quantity = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Creater = c.Int(nullable: false),
                        CreatDate = c.DateTime(nullable: false),
                        LastEditor = c.Int(nullable: false),
                        LastUpdate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Materials", t => t.MaterialID, cascadeDelete: true)
                .Index(t => t.MaterialID);
            
            CreateTable(
                "dbo.Materials",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        No = c.String(nullable: false, maxLength: 250, unicode: false),
                        Creater = c.Int(nullable: false),
                        CreatDate = c.DateTime(nullable: false),
                        LastEditor = c.Int(nullable: false),
                        LastUpdate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Account = c.String(nullable: false, maxLength: 250, unicode: false),
                        Password = c.String(nullable: false, maxLength: 250, unicode: false),
                        Creater = c.Int(nullable: false),
                        CreatDate = c.DateTime(nullable: false),
                        LastEditor = c.Int(nullable: false),
                        LastUpdate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Inventories", "MaterialID", "dbo.Materials");
            DropIndex("dbo.Inventories", new[] { "MaterialID" });
            DropTable("dbo.Users");
            DropTable("dbo.Materials");
            DropTable("dbo.Inventories");
        }
    }
}
