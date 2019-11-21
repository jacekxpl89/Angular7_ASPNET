namespace Reklamacja.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class m2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Complaints", "Date", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Complaints", "Date", c => c.DateTime(nullable: false));
        }
    }
}
