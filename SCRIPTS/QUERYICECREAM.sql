Create database ICECREAM;
GO
Use ICECREAM;
Create Table Catagory(
CategoryId int primary key identity not null,
CategoryName varchar(50),
CategoryDescription varchar(max),
CategoryActive bit
CategoryDate datetime);

Create Table Products(
ProductsId int primary key identity not null,
ProductsName varchar(50),
ProductsDescription varchar(max),
ProductModel varchar(50),
ProductPrice decimal(18,2),
ProductKeywords varchar(50),
CategoryId int,
ProductActive bit,
ProductsDate datetime);

Create Table Images(
ImagesId int primary key identity not null,
ImagesDescription varchar(max),
ImagesURL varchar(max),
ImagesActive bit,
ProductId int,
Images datetime);

Select*from Catagory;
