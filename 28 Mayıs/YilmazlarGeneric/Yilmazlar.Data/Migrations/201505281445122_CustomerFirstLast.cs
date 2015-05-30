namespace Yilmazlar.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CustomerFirstLast : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "Firstname", c => c.String());
            AddColumn("dbo.Customers", "Lastname", c => c.String());
            DropColumn("dbo.Customers", "CustomerName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "CustomerName", c => c.String());
            DropColumn("dbo.Customers", "Lastname");
            DropColumn("dbo.Customers", "Firstname");
        }
    }
}
