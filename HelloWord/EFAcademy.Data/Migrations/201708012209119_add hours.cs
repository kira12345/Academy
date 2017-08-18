namespace EFAcademy.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addhours : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "StudentsAddress.StudentAddress",
                c => new
                    {
                        StudentAddressId = c.Int(nullable: false),
                        address = c.String(),
                        city = c.String(),
                        state = c.String(),
                    })
                .PrimaryKey(t => t.StudentAddressId)
                .ForeignKey("Students.Student", t => t.StudentAddressId)
                .Index(t => t.StudentAddressId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("StudentsAddress.StudentAddress", "StudentAddressId", "Students.Student");
            DropIndex("StudentsAddress.StudentAddress", new[] { "StudentAddressId" });
            DropTable("StudentsAddress.StudentAddress");
        }
    }
}
