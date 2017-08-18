namespace EFAcademy.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "Course.Course",
                c => new
                    {
                        CourseId = c.Int(nullable: false, identity: true),
                        Title = c.String(maxLength: 50),
                        Credits = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CourseId);
            
            CreateTable(
                "Enrollment.Enrollment",
                c => new
                    {
                        EnrollmentId = c.Int(nullable: false, identity: true),
                        CourseId = c.Int(nullable: false),
                        StudentId = c.Int(nullable: false),
                        Grade = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.EnrollmentId)
                .ForeignKey("Course.Course", t => t.CourseId, cascadeDelete: true)
                .ForeignKey("Students.Student", t => t.StudentId, cascadeDelete: true)
                .Index(t => t.CourseId)
                .Index(t => t.StudentId);
            
            CreateTable(
                "Students.Student",
                c => new
                    {
                        StudentId = c.Int(nullable: false, identity: true),
                        Lastname = c.String(maxLength: 50),
                        Firstname = c.String(),
                        Enrollment = c.DateTime(nullable: false),
                        EnrollmentId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.StudentId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("Enrollment.Enrollment", "StudentId", "Students.Student");
            DropForeignKey("Enrollment.Enrollment", "CourseId", "Course.Course");
            DropIndex("Enrollment.Enrollment", new[] { "StudentId" });
            DropIndex("Enrollment.Enrollment", new[] { "CourseId" });
            DropTable("Students.Student");
            DropTable("Enrollment.Enrollment");
            DropTable("Course.Course");
        }
    }
}
