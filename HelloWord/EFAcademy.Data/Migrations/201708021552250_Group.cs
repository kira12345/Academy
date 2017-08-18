namespace EFAcademy.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Group : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "Groups.Group",
                c => new
                    {
                        GroupId = c.Int(nullable: false, identity: true),
                        hour = c.String(),
                    })
                .PrimaryKey(t => t.GroupId);
            
            AddColumn("Students.Student", "GroupId", c => c.Int(nullable: false));
            CreateIndex("Students.Student", "GroupId");
            AddForeignKey("Students.Student", "GroupId", "Groups.Group", "GroupId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("Students.Student", "GroupId", "Groups.Group");
            DropIndex("Students.Student", new[] { "GroupId" });
            DropColumn("Students.Student", "GroupId");
            DropTable("Groups.Group");
        }
    }
}
