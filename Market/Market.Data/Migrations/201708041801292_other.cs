namespace Market.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class other : DbMigration
    {
        public override void Up()
        {
            AlterColumn("Categories.Category", "Name", c => c.String(maxLength: 50));
            AlterColumn("Categories.Category", "Description", c => c.String(maxLength: 50));
            AlterColumn("Products.Product", "Name", c => c.String(maxLength: 50));
            AlterColumn("Suppliers.Supplier", "Name", c => c.String(maxLength: 50));
            AlterColumn("Suppliers.Supplier", "Email", c => c.String(maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("Suppliers.Supplier", "Email", c => c.String());
            AlterColumn("Suppliers.Supplier", "Name", c => c.String());
            AlterColumn("Products.Product", "Name", c => c.String());
            AlterColumn("Categories.Category", "Description", c => c.String());
            AlterColumn("Categories.Category", "Name", c => c.String());
        }
    }
}
