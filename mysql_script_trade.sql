create database trade;
use trade;
drop database trade;
create table Role
(
  RoleID int primary key IDENTITY(1,1),
  RoleName varchar(100) not null
);
insert into Role (RoleName)
values
('admin'),
('user'),
('manager');

create table User_
(
  UserID int primary key IDENTITY(1,1),
  UserSurname varchar(100) not null,
  UserName varchar(100) not null,
  UserPatronymic varchar(100) not null,
  UserLogin varchar(100) not null,
  UserPassword varchar(100) not null,
  UserRole int not null,
  foreign key (UserRole) references Role(RoleID) 
);

create table ProductName
(
	ProductID int primary key not null,
	ProductName varchar(70)
);

create table MeasureUnit
(
	MeasureUnitID int primary key not null,
	MeasureUnit varchar(30)
);

create table Maker
(
	MakerID int primary key not null,
	MakerName varchar(70) not null
);

create table Supplier
(
	SupplierID int primary key not null,
	SupplierName varchar(70) not null
);

create table Category
(
	CategoryID int primary key not null,
	CategoryName varchar(70) not null
);

create table Product
(
  ProductArticleNumber varchar(100) primary key not null,
  ProductNameID int not null constraint FK_ProductNameID foreign key(ProductNameID) references ProductName(ProductID),
  MeasureUnitID int not null constraint FK_MeasureUnitID foreign key(MeasureUnitID) references MeasureUnit(MeasureUnitID),
  Price int,
  MaxSizeSale int,
  MakerID int not null constraint FK_MakerID foreign key(MakerID) references Maker(MakerID),
  SupplierID int not null constraint FK_SupplierID foreign key(SupplierID) references Supplier(SupplierID),
  CategoryID int not null constraint FK_CategoryID foreign key(CategoryID) references Category(CategoryID),
  Sale int,
  StoreQuantity int,
  Description_text text,
  Pages varchar(100)
);



/*
create table Order
(
  OrderID int primary key auto_increment,
  OrderStatus text not null,
  OrderDeliveryDate datetime not null,
  OrderPickupPoint text not null
);
create table OrderProduct
(
  OrderID int not null,
  ProductArticleNumber nvarchar(100)  not null,
  Primary key (OrderID,ProductArticleNumber),
  foreign key (OrderID) references Order(OrderID),
  foreign key (ProductArticleNumber) references Product(ProductArticleNumber)
);
*/