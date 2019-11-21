namespace Reklamacja.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class m3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Complaints", "LastName", c => c.String());
            AddColumn("dbo.Complaints", "Email", c => c.String());
            AddColumn("dbo.Complaints", "ShopId", c => c.String());
            DropColumn("dbo.Complaints", "Date");
            DropColumn("dbo.Complaints", "Adress");
            DropColumn("dbo.Complaints", "Shop");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Complaints", "Shop", c => c.String());
            AddColumn("dbo.Complaints", "Adress", c => c.String());
            AddColumn("dbo.Complaints", "Date", c => c.String());
            DropColumn("dbo.Complaints", "ShopId");
            DropColumn("dbo.Complaints", "Email");
            DropColumn("dbo.Complaints", "LastName");
        }
    }
}
