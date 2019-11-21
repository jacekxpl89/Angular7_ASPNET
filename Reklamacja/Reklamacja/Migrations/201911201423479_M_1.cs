namespace Reklamacja.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class M_1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Complaints",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        PhoneNumber = c.String(),
                        Date = c.DateTime(nullable: false),
                        Description = c.String(),
                        Adress = c.String(),
                        ProductId = c.String(),
                        Shop_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Shops", t => t.Shop_Id)
                .Index(t => t.Shop_Id);
            
            CreateTable(
                "dbo.Shops",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Location = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Complaints", "Shop_Id", "dbo.Shops");
            DropIndex("dbo.Complaints", new[] { "Shop_Id" });
            DropTable("dbo.Shops");
            DropTable("dbo.Complaints");
        }
    }
}
