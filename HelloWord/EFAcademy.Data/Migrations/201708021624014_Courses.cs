namespace EFAcademy.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Courses : DbMigration
    {
        public override void Up()
        {
            AddColumn("Course.Course", "StudentId", c => c.Int(nullable: false));
            AddColumn("Students.Student", "CourseId", c => c.Int(nullable: false));
            AlterColumn("Course.Course", "Title", c => c.String());
            CreateIndex("Course.Course", "StudentId");
            AddForeignKey("Course.Course", "StudentId", "Students.Student", "StudentId", cascadeDelete: false);
        }
        
        public override void Down()
        {
            DropForeignKey("Course.Course", "StudentId", "Students.Student");
            DropIndex("Course.Course", new[] { "StudentId" });
            AlterColumn("Course.Course", "Title", c => c.String(maxLength: 50));
            DropColumn("Students.Student", "CourseId");
            DropColumn("Course.Course", "StudentId");
        }
    }
}
