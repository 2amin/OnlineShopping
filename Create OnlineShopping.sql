Create Database OnlineShoppingSample
use OnlineShoppingSample
Create Table Category
(
Categoryid int Primary Key Identity(1,1),
Title nvarchar(50)
)
Create Table Product
(
Productid int Primary Key Identity(1,1),
Title nvarchar(50),
UnitPrice money,
discount money,
Stock int,
Categoryid int Foreign Key References Category
)
Create table picture
(
Pictureid int Primary Key Identity(1,1),
Picture varbinary(50),
Productid int Foreign Key References Product
)