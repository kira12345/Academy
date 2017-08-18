namespace Market.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "Categories.Category",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "Products.Product",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        CategoryId = c.Int(nullable: false),
                        SupplierId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("Categories.Category", t => t.CategoryId, cascadeDelete: true)
                .ForeignKey("Suppliers.Supplier", t => t.SupplierId, cascadeDelete: true)
                .Index(t => t.CategoryId)
                .Index(t => t.SupplierId);
            
            CreateTable(
                "Suppliers.Supplier",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("Products.Product", "SupplierId", "Suppliers.Supplier");
            DropForeignKey("Products.Product", "CategoryId", "Categories.Category");
            DropIndex("Products.Product", new[] { "SupplierId" });
            DropIndex("Products.Product", new[] { "CategoryId" });
            DropTable("Suppliers.Supplier");
            DropTable("Products.Product");
            DropTable("Categories.Category");
        }
    }
}
