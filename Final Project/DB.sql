create table Locations 
(
	ID int not null primary key identity(1,1),
	Country varchar(50),
	StateCode varchar(2),
	City varchar(50),
	ZipCode varchar(10),
	[Address] varchar(100),
	Latitude DOUBLE PRECISION,
	Longitude DOUBLE PRECISION,
	[Name] varchar(50),
	[Description] varchar(1000),
	Category int,
);

go

create procedure Location_Insert (
	@Country varchar(50),
	@StateCode varchar(2),
	@City varchar(50),
	@ZipCode varchar(10),
	@Address varchar(100),
	@Latitude DOUBLE PRECISION,
	@Longitude DOUBLE PRECISION,
	@Name varchar(50),
	@Description varchar(1000),
	@Category int
)
as
insert into Locations(Country, StateCode, City, ZipCode, Address, Latitude, Longitude, Name, Description, Category)
VALUES (@Country, @StateCode, @City, @ZipCode, @Address, @Latitude, @Longitude, @Name, @Description, @Category)

go

create procedure Location_Insert_Min (
	@Latitude DOUBLE PRECISION,
	@Longitude DOUBLE PRECISION,
	@Name varchar(50),
	@Description varchar(1000)
)
as
insert into Locations(Latitude, Longitude, Name, Description)
VALUES (@Latitude, @Longitude, @Name, @Description)

go

create procedure Location_GetList
AS
Select * from Locations;

go

--Test Locations
delete from Locations;
go
insert into Locations(Country, StateCode, City, ZipCode, Address, Latitude, Longitude, Name, Description, Category)
values('United States', 'OR', 'Klamath Falls', '97603', '3201 Campus Dr', 42.254300, -121.782270, 'OIT', 'My School', 1)
go
insert into Locations(Country, StateCode, City, ZipCode, Address, Latitude, Longitude, Name, Description, Category)
values('United States', 'DC', 'Washington DC', '20500', '1600 Pennsylvania Ave NW', 38.897663, -77.036575, 'The White House', 'Where the president lives', 2)
go
select * from Locations;

go

create table [Messages]
(
	ID int not null primary key identity(1,1),
	[Name] varchar(25),
	[Type] varchar(15),
	[Message] varchar(1000)
)

go

create procedure Messages_GetList
as 
select * from [Messages];

go

create procedure Messages_Insert (
	@Name varchar(25),
	@Type varchar(15),
	@Message varchar(1000)
)
as
insert into Messages([Name], [Type], [Message])
values(@Name, @Type, @Message)

go

select * from  Messages;

go

create table UserList
(
	ID int not null primary key identity(1,1),
	[Name] varchar(50) 
)

go

create table UserListItem
(
	ID int not null primary key identity(1,1),
	ListID int not null foreign key references USerList(ID),
	Item varchar(250),
	IsChecked bit
)
go
delete from UserListItem;
go
delete from UserList;

go

Insert into UserList ([Name]) values ('Bucket List');
Insert into UserList ([Name]) values ('Trips this year');

go

delete from UserList;

go

select * from UserList;

go

delete from UserListItem;

go

insert into UserListItem (ListID, Item, IsChecked) values (3, 'Visit Greece', 0);
insert into UserListItem (ListID, Item, IsChecked) values (3, 'See the Pyramids in Egypt', 0);
insert into UserListItem (ListID, Item, IsChecked) values (3, 'Snorkel in the Bahamas', 0);
insert into UserListItem (ListID, Item, IsChecked) values (3, 'Go parasailing in Mexico', 0);
insert into UserListItem (ListID, Item, IsChecked) values (3, 'Visit all 7 continents', 0);
insert into UserListItem (ListID, Item, IsChecked) values (3, 'Climb to the top of Mt. Evertest', 0);

insert into UserListItem (ListID, Item, IsChecked) values (4, 'Go to the coast', 0);
insert into UserListItem (ListID, Item, IsChecked) values (4, 'Visit Seattle, WA', 0);

go

select * from UserListItem;

go

create procedure Get_Lists
as
select * from UserList;

go

create procedure Get_List_Items
(
	@ListID int
)
as 
select * from UserListItem where ListID = @ListID;

go
