CREATE DATABASE SCHOOL 
GO
USE SCHOOL
CREATE TABLE STUDENT(
StudentId int primary key not null identity(1,1),
Lastname varchar(50) not null,
Firstname varchar(50) not null,
EnrollmentDate Datetime null
);

Select*from STUDENT

CREATE TABLE COURSE(
CourseId int primary key not null identity(1,1),
Title varchar(50) not null,
Credits int not null
);

Select*from COURSE

CREATE TABLE ENROLLMENT(
EnrollmentId int primary key not null identity(1,1),
CourseId int not null,
StudentId int not null,
Grade int not null
);

Select*from ENROLLMENT



Alter table [Enrollment]
with check add Constraint 
[FK_StudentId] foreign key([StudentId])
References [Student]([StudentId]) 

Alter table [Enrollment]
with check add Constraint 
[FK_CourseId] foreign key([CourseId])
References [Course]([CourseId]) 

/*Alter table [Student] column int identity(1,1); */

select *from STUDENT
Insert into Student (Lastname,Firstname,EnrollmentDate)values('Aliyan','Kirama','7/07/2017')
Insert into Student (Lastname,Firstname,EnrollmentDate)values('Aliyan','Ali','2017/7/7')
Insert into Student (Lastname,Firstname,EnrollmentDate)values('Dadu','hisham','07/07/2017')
Insert into Student (Lastname,Firstname,EnrollmentDate)values('Fernández','Karen','07/07/2017')
Insert into Student (Lastname,Firstname,EnrollmentDate)values('López','José','07/07/2017')
Insert into Student (Lastname,Firstname,EnrollmentDate)values('López','Andres','07/07/2017')
Insert into Student (Lastname,Firstname,EnrollmentDate)values('González','Ricardo','07/07/2017')
Insert into Student (Lastname,Firstname,EnrollmentDate)values('Perez','Andrea','07/07/2017')
Insert into Student (Lastname,Firstname,EnrollmentDate)values('Garza','Enrique','07/07/2017')
Insert into Student (Lastname,Firstname,EnrollmentDate)values('Martinez','kasandra','07/07/2017')

Insert into COURSE (Title,Credits)values('ECUACIONES DIFERENCIALES',5)
Insert into COURSE (Title,Credits)values('MATEMATICAS DISCRETAS',5)
Insert into COURSE (Title,Credits)values('ESPAÑOL',2)
Insert into COURSE (Title,Credits)values('INGLES',3)
Insert into COURSE (Title,Credits)values('ALEMAN',2)
Insert into COURSE (Title,Credits)values('PROGRAMACION ORIENTADA A OBJETOS',6)
Insert into COURSE (Title,Credits)values('ADMINISTRACION',2)
Insert into COURSE (Title,Credits)values('CULTURA EMPRESARIAL',2)
Insert into COURSE (Title,Credits)values('CONTABILIDAD FINANCIERA',7)
Insert into COURSE (Title,Credits)values('FRANCES',1)


Insert into ENROLLMENT (CourseId,StudentId,Grade)values(8,1,2)
Insert into ENROLLMENT (CourseId,StudentId,Grade)values(7,2,5)
Insert into ENROLLMENT (CourseId,StudentId,Grade)values(9,3,2)
Insert into ENROLLMENT (CourseId,StudentId,Grade)values(6,4,2)
Insert into ENROLLMENT (CourseId,StudentId,Grade)values(1,5,3)
Insert into ENROLLMENT (CourseId,StudentId,Grade)values(2,6,1)
Insert into ENROLLMENT (CourseId,StudentId,Grade)values(5,7,7)
Insert into ENROLLMENT (CourseId,StudentId,Grade)values(6,8,6)
Insert into ENROLLMENT (CourseId,StudentId,Grade)values(3,9,6)
Insert into ENROLLMENT (CourseId,StudentId,Grade)values(4,10,6)
SELECT*FROM STUDENT
SELECT*FROM COURSE
SELECT*FROM ENROLLMENT

CREATE VIEW VIEWNAME AS 
SELECT STUDENT.StudentId, STUDENT.Firstname, STUDENT.Lastname,
COURSE.CourseId, COURSE.Title, COURSE.Credits,
ENROLLMENT.EnrollmentId, ENROLLMENT.Grade 
FROM COURSE INNER JOIN ENROLLMENT ON COURSE.CourseId=ENROLLMENT.CourseId
INNER JOIN STUDENT ON ENROLLMENT.StudentId =STUDENT.StudentId



