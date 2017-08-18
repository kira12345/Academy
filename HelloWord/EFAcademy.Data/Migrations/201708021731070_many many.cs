namespace EFAcademy.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class manymany : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "University.Cities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "University.Vendors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "University.VendorCities",
                c => new
                    {
                        Vendor_Id = c.Int(nullable: false),
                        Citie_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Vendor_Id, t.Citie_Id })
                .ForeignKey("University.Vendors", t => t.Vendor_Id, cascadeDelete: true)
                .ForeignKey("University.Cities", t => t.Citie_Id, cascadeDelete: true)
                .Index(t => t.Vendor_Id)
                .Index(t => t.Citie_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.VendorCities", "Citie_Id", "dbo.Cities");
            DropForeignKey("dbo.VendorCities", "Vendor_Id", "dbo.Vendors");
            DropIndex("dbo.VendorCities", new[] { "Citie_Id" });
            DropIndex("dbo.VendorCities", new[] { "Vendor_Id" });
            DropTable("dbo.VendorCities");
            DropTable("dbo.Vendors");
            DropTable("dbo.Cities");
        }
    }
}
