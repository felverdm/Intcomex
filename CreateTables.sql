Create table Categories(
	CategoryID int IDENTITY(1,1) PRIMARY KEY,
	CategoryName nvarchar(200),
	CategoryDescription nvarchar(500),
	CategoryImage varchar (MAX) -- la imagen es un string base 64
)


Create table Suppliers(
	SupplierID int IDENTITY(1,1) PRIMARY KEY,
	CompanyName nvarchar(200),
	ContactName nvarchar(200),
	ContactTitle nvarchar(200),
	SupplierAddress nvarchar(100),
	City int, --por temas de tiempo no creé las tablas de ciudades regiones y paises, pero son campos int porque hacen referencia como fk a dichas tablas
	Region int,
	PostalCode nvarchar(15),
	Country int,
	Phone nvarchar(30),
	Fax nvarchar(30),
	HomePage nvarchar(100),
)

insert into Suppliers values
('test','test','test','test',1,2,'12345',3,'1234567','7654321','abc')

Create table Products(
	ProductID int IDENTITY(1,1) PRIMARY KEY,
	ProductName nvarchar(200),
	SupplierID int,
	CategoryID int,
	QuantityPerUnit int,
	UnitPrice decimal,
	UnitsInStock int,
	UnitsOnOrder int,
	ReorderLevel int,
	Discontinued bit,
	FOREIGN KEY (SupplierID) REFERENCES Suppliers,
	FOREIGN KEY (CategoryID) REFERENCES Categories
)


/************************************************************************************************/

create view ProductsXimage as
select 
p.ProductID
,p.ProductName
,p.SupplierID
,p.CategoryID
,p.QuantityPerUnit
,p.UnitPrice
,p.UnitsInStock
,p.UnitsOnOrder
,p.ReorderLevel
,p.Discontinued
,c.CategoryImage
from
Products p inner join Categories c on p.CategoryID = c.CategoryID

/************************************************************************************************/
