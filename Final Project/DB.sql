------------------------------------------------------------------------------
---------------- Location stuff ----------------------------------------------
------------------------------------------------------------------------------
drop table Locations;
go
create table Locations 
(
	ID int not null primary key identity(1,1),
	Country varchar(50),
	Latitude DOUBLE PRECISION,
	Longitude DOUBLE PRECISION,
	[Name] varchar(50),
	[Description] varchar(1000),
	Category int,
	UserID varchar(100)
);
go
drop procedure Location_Insert;
go
create procedure Location_Insert (
	@Country varchar(50),
	@Latitude DOUBLE PRECISION,
	@Longitude DOUBLE PRECISION,
	@Name varchar(50),
	@Description varchar(1000),
	@Category int,
	@UserID varchar(100)
)
as
insert into Locations(Country, Latitude, Longitude, Name, Description, Category, UserID)
VALUES (@Country, @Latitude, @Longitude, @Name, @Description, @Category, @UserID)
go
drop procedure Location_GetList;
go
create procedure Location_GetList(
	@UserID varchar(100)
)
AS
Select * from Locations where UserID = @UserID;
go
select * from Locations;
go
drop procedure Remove_Location;
go
create procedure Remove_Location
(
	@Latitude DOUBLE PRECISION,
	@Longitude DOUBLE PRECISION,
	@UserID varchar(100)
)
as
delete from Locations 
where Round(Latitude,5) = Round(@Latitude, 5) and Round(Longitude,5) = Round(@Longitude,5)
and UserID = @UserID;
go
drop procedure GetNumberOfLocations;
go
create procedure GetNumberOfLocations(
	@UserID varchar(100)
)
as
select count(ID) LocCount from Locations where UserID = @UserID ;
go


------------------------------------------------------------------------------
---------------- Message stuff -----------------------------------------------
------------------------------------------------------------------------------
drop table [Messages];
go
create table [Messages]
(
	ID int not null primary key identity(1,1),
	[Name] varchar(25),
	[Type] varchar(15),
	[Message] varchar(1000)
)
go
drop procedure Messages_GetList;
go
create procedure Messages_GetList
as 
select * from [Messages];
go
drop procedure Messages_Insert;
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


------------------------------------------------------------------------------
---------------- List stuff --------------------------------------------------
------------------------------------------------------------------------------
go
drop table UserListItem;
go
drop table UserList;
go
create table UserList
(
	ID int not null primary key identity(1,1),
	[Name] varchar(50),
	UserID varchar(100)
)
go
drop procedure AddList;
go
create procedure AddList
(
	@Name varchar(50),
	@UserID varchar(100)
)
as
insert into UserList ([Name], UserID) values (@Name, @UserID);
go
drop table UserListItem;
go
create table UserListItem
(
	ID int not null primary key identity(1,1),
	ListID int,
	Item varchar(250),
	IsChecked bit,
	UserID varchar(100)
)
go
select * from UserList;
go
select * from UserListItem;
go
drop procedure AddListItem;
go
create procedure AddListItem
(
	@ListID int,
	@ItemName varchar(250),
	@UserID varchar(100)
)
as
insert into UserListItem (ListID, Item, IsChecked, UserID) values (@ListID, @ItemName, 0, @UserID);
go
drop procedure Get_Lists;
go
create procedure Get_Lists
(
	@UserID varchar(100)
)
as
select * from UserList where UserID = @UserID;
go
drop procedure Get_List_Items;
go
create procedure Get_List_Items
(
	@ListID int,
	@UserID varchar(100)
)
as 
select * from UserListItem where ListID = @ListID and UserID = @UserID;

------------------------------------------------------------------------------
---------------- User stuff --------------------------------------------------
------------------------------------------------------------------------------
go
select * from sys.objects 
where type_desc = 'USER_TABLE'
order by create_date desc;
go
select * from AspNetUsers;
select * from AspNetRoles;
select * from AspNetUserTokens;
select * from AspNetUserLogins;
select * from AspNetUserClaims;
select * from AspNetRoleClaims;

