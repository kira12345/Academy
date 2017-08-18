namespace EFAcademy.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class manyapi : DbMigration
    {
        public override void Up()
        {
            MoveTable(name: "dbo.Cities", newSchema: "University");
            MoveTable(name: "dbo.Vendors", newSchema: "University");
            CreateTable(
                "dbo.Cities_Api",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Vendor_Api",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "University.CityVendor",
                c => new
                    {
                        VendorId = c.Int(nullable: false),
                        CitieId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.VendorId, t.CitieId })
                .ForeignKey("dbo.Cities_Api", t => t.VendorId, cascadeDelete: true)
                .ForeignKey("dbo.Vendor_Api", t => t.CitieId, cascadeDelete: true)
                .Index(t => t.VendorId)
                .Index(t => t.CitieId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("University.CityVendor", "CitieId", "dbo.Vendor_Api");
            DropForeignKey("University.CityVendor", "VendorId", "dbo.Cities_Api");
            DropIndex("University.CityVendor", new[] { "CitieId" });
            DropIndex("University.CityVendor", new[] { "VendorId" });
            DropTable("University.CityVendor");
            DropTable("dbo.Vendor_Api");
            DropTable("dbo.Cities_Api");
            MoveTable(name: "University.Vendors", newSchema: "dbo");
            MoveTable(name: "University.Cities", newSchema: "dbo");
        }
    }
}
