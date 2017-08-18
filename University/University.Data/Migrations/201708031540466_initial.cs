namespace University.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Courses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 50),
                        credits = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 50),
                        Enrollment = c.String(maxLength: 50),
                        lastname = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Departments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Firstname = c.String(maxLength: 50),
                        Hours = c.Int(nullable: false),
                        CategoryId = c.Int(nullable: false),
                        EmployeeEnrollment = c.String(maxLength: 50),
                        OfficeId = c.Int(),
                        lastname = c.String(),
                        EmployeesCategories_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.EmployeeCategories", t => t.EmployeesCategories_Id, cascadeDelete: true)
                .ForeignKey("dbo.Offices", t => t.OfficeId)
                .Index(t => t.OfficeId)
                .Index(t => t.EmployeesCategories_Id);
            
            CreateTable(
                "dbo.EmployeeCategories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Categoryname = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Offices",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Edificio = c.Int(nullable: false),
                        Piso = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.StudentCourses",
                c => new
                    {
                        Student_Id = c.Int(nullable: false),
                        Course_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Student_Id, t.Course_Id })
                .ForeignKey("dbo.Students", t => t.Student_Id, cascadeDelete: true)
                .ForeignKey("dbo.Courses", t => t.Course_Id, cascadeDelete: true)
                .Index(t => t.Student_Id)
                .Index(t => t.Course_Id);
            
            CreateTable(
                "dbo.EmployeeDepartments",
                c => new
                    {
                        Employee_Id = c.Int(nullable: false),
                        Department_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Employee_Id, t.Department_Id })
                .ForeignKey("dbo.Employees", t => t.Employee_Id, cascadeDelete: true)
                .ForeignKey("dbo.Departments", t => t.Department_Id, cascadeDelete: true)
                .Index(t => t.Employee_Id)
                .Index(t => t.Department_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Employees", "OfficeId", "dbo.Offices");
            DropForeignKey("dbo.Employees", "EmployeesCategories_Id", "dbo.EmployeeCategories");
            DropForeignKey("dbo.EmployeeDepartments", "Department_Id", "dbo.Departments");
            DropForeignKey("dbo.EmployeeDepartments", "Employee_Id", "dbo.Employees");
            DropForeignKey("dbo.StudentCourses", "Course_Id", "dbo.Courses");
            DropForeignKey("dbo.StudentCourses", "Student_Id", "dbo.Students");
            DropIndex("dbo.EmployeeDepartments", new[] { "Department_Id" });
            DropIndex("dbo.EmployeeDepartments", new[] { "Employee_Id" });
            DropIndex("dbo.StudentCourses", new[] { "Course_Id" });
            DropIndex("dbo.StudentCourses", new[] { "Student_Id" });
            DropIndex("dbo.Employees", new[] { "EmployeesCategories_Id" });
            DropIndex("dbo.Employees", new[] { "OfficeId" });
            DropTable("dbo.EmployeeDepartments");
            DropTable("dbo.StudentCourses");
            DropTable("dbo.Offices");
            DropTable("dbo.EmployeeCategories");
            DropTable("dbo.Employees");
            DropTable("dbo.Departments");
            DropTable("dbo.Students");
            DropTable("dbo.Courses");
        }
    }
}
