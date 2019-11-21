namespace Reklamacja.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class m21 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Complaints", "Shop_Id", "dbo.Shops");
            DropIndex("dbo.Complaints", new[] { "Shop_Id" });
            AddColumn("dbo.Complaints", "Shop", c => c.String());
            DropColumn("dbo.Complaints", "Shop_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Complaints", "Shop_Id", c => c.Int());
            DropColumn("dbo.Complaints", "Shop");
            CreateIndex("dbo.Complaints", "Shop_Id");
            AddForeignKey("dbo.Complaints", "Shop_Id", "dbo.Shops", "Id");
        }
    }
}
