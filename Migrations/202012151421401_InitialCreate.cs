namespace Multipublicador.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MPDealer",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Status = c.String(nullable: false),
                        Address = c.String(nullable: false),
                        Address2 = c.String(nullable: false),
                        Country = c.String(nullable: false),
                        PC = c.String(nullable: false),
                        State = c.String(nullable: false),
                        City = c.String(nullable: false),
                        Market = c.String(nullable: false),
                        Phone_1 = c.Int(nullable: false),
                        Phone_2 = c.Int(nullable: false),
                        ContactPerson = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        Email2 = c.String(nullable: false),
                        Description = c.String(nullable: false),
                        Logo = c.String(nullable: false),
                        Guarantee = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.MPSourcePortal",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Status = c.String(nullable: false),
                        MPDealerId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.MPDealer", t => t.MPDealerId, cascadeDelete: true)
                .Index(t => t.MPDealerId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.MPSourcePortal", "MPDealerId", "dbo.MPDealer");
            DropIndex("dbo.MPSourcePortal", new[] { "MPDealerId" });
            DropTable("dbo.MPSourcePortal");
            DropTable("dbo.MPDealer");
        }
    }
}
