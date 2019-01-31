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
	Category varchar(15),
	UserID varchar(100),
	DateVisited varchar(12),
	DateAdded varchar(12)
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
	@Category varchar(15),
	@UserID varchar(100),
	@DateVisited varchar(12)
)
as
insert into Locations(Country, Latitude, Longitude, Name, Description, Category, UserID, DateVisited, DateAdded)
VALUES (@Country, @Latitude, @Longitude, @Name, @Description, @Category, @UserID, @DateVisited, GETDATE())
go
drop procedure GetTitleAndDescription;
go 
create procedure GetTitleAndDescription
(
	@UserId varchar(100),
	@Latitude double precision,
	@Longitude double precision
)
as
--select [Name], [Description], DateVisited, Category from Locations --old way, no images
select [Name], [Description], DateVisited, Category, [Image] from Locations left outer join Images 
on Locations.ID = Images.LocationID and Locations.UserID = Images.UserID
where Round(Latitude,5) = Round(@Latitude, 5) and Round(Longitude,5) = Round(@Longitude,5)
and Locations.UserID = @UserId;
go
------- test, can delete when done with images stuff-----------
--select [Name], [Description], DateVisited, Category, [Image] from Locations left outer join Images 
--on Locations.ID = Images.LocationID and Locations.UserID = Images.UserID
--where Round(Latitude,5) = Round(26.9739306062453, 5) and Round(Longitude,5) = Round(-112.968758940697,5)
--and Locations.UserID = '54e26bab-af93-4c86-a5bf-80d8d886f92f';
-------------------------

drop procedure Update_Location;
go
create procedure Update_Location
(
	@UserId varchar(100),
	@Title varchar(50),
	@Description varchar(1000),
	@DateVisited varchar(12),
	@Category varchar(15),
	@Latitude double precision,
	@Longitude double precision
)
as
update Locations set [Name] = @Title, [Description] = @Description, DateVisited = @DateVisited, Category = @Category where UserID = @UserId and Round(Latitude,5) = Round(@Latitude, 5) and Round(Longitude,5) = Round(@Longitude,5);
go

drop procedure Location_GetList;
go
create procedure Location_GetList(
	@UserID varchar(100)
)
AS
Select * from Locations where UserID = @UserID;
go

drop procedure AddMarkerWithLatLon;
go
create procedure AddMarkerWithLatLon
(
	@UserId varchar(100),
	@Latitude double precision,
	@Longitude double precision,
	@Country varchar(50)
)
as
insert into Locations (UserID, Latitude, Longitude, Country, [Name], [Description], Category, DateAdded) 
values (@UserId, @Latitude, @Longitude, @Country, '','',0, GETDATE());
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

--will also need to add category part later (only 'been to', not 'want to go to')
drop procedure GetNumberOfCountries;
go
create procedure GetNumberOfCountries(
	@UserID varchar(100)
)
as
select count(distinct Country) CountryCount from locations where UserID = @UserID and Category = 'Visited';
go


------------------------------------------------------------------------------
----------------------------- Image Stuff ------------------------------------
drop Table Images;
go
create table Images
(
	LocationID int,
	[Image] varchar(max),
	UserID varchar(100)
)
go

------ Add image proc ----------
drop procedure AddImage;
go
create procedure AddImage
(
	@Latitude DOUBLE PRECISION,
	@Longitude DOUBLE PRECISION,
	@UserID varchar(100),
	@Image varchar(max)
)
as
insert into Images (LocationID, [Image], UserID) 
values (
	(select ID from Locations where Round(Latitude,5) = Round(@Latitude, 5) and Round(Longitude,5) = Round(@Longitude,5))
	, @Image
	, @UserID)
go
--------------------------------------------------------------------------------
--------------------------------------------------------------------------------

------------------------ Get Category count ---------------------------------
drop procedure GetCategoryCount;
go
create procedure GetCategoryCount
(
	@UserId varchar(100)
)
as
select Category, count(Category) CategoryCount 
from Locations 
where UserID = @UserId
group by Category
order by CategoryCount;
-----------------------------------------------------------------------------


------------------ Most locations leaderboard--------------------------------
drop procedure GetMostPinsUsers;
go
create procedure GetMostPinsUsers
as select top 5 UserName, count(UserName) pincount from 
AspNetUsers join Locations on AspNetUsers.Id = Locations.UserID 
group by UserName
order by pincount desc
go
-----------------------------------------------------------------------------

------------- Most locations this month leaderboard--------------------------
drop procedure GetMostLocationsThisMonth;
go
create procedure GetMostLocationsThisMonth
as select UserName, count(UserName) pincount from 
AspNetUsers join Locations on AspNetUsers.Id = Locations.UserID 
where Month(DateVisited) = MONTH(GETDATE()) 
group by UserName
order by pincount desc
go
-----------------------------------------------------------------------------

------------------ Most countries leaderboard--------------------------------
drop procedure GetMostCountriesUsers;
go 
create procedure GetMostCountriesUsers
as select top 5 UserName, count(distinct Country) CountryCount
from AspNetUsers join Locations on AspNetUsers.Id = Locations.UserID 
group by UserName
order by CountryCount desc
go
------------------------------------------------------------------------------

----------------------------- Get dates of trips this year -------------------
drop procedure GetDatesOfTrips
go
create procedure GetDatesOfTrips
(
	@UserId varchar(100)
)
as
select DateVisited from Locations where UserID = @UserId
and YEAR(DateVisited) = YEAR(GETDATE());--will want to add category check her also
go
-----------------------------------------------------------------------------


drop procedure GetListIDByName
go
create procedure GetListIDByName
(
	@Name varchar(255),
	@UserID varchar(100)
)
as
select ID from UserList where [Name] = @Name and UserID = @UserID;
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

----------------------- Theme stuff ----------------------------------------
drop table Themes;
go
create table Themes
(
	Theme varchar(20),
	UserID varchar(100)
);
go
--------- get theme ------------
drop procedure GetTheme;
go
create procedure GetTheme
(
	@UserID varchar(100)
)
as
select Theme from Themes where UserID = @UserID;
go
--------- insert/update theme ------------------
drop procedure InsertOrUpdateTheme;
go
create procedure InsertOrUpdateTheme
(
	@UserID varchar(100),
	@Theme varchar(20)
)
as
if exists (select Theme from Themes where UserID = @UserID)
begin
	update Themes set Theme = @Theme where UserID = @UserID;
end
else
begin
	insert into Themes (Theme, UserID) values (@Theme, @UserID);
end
go


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


--select * from Locations

--delete from Locations where DateVisited = '00/00/0000'

--select * from Images
--delete from Images where LocationID = 3007

select * from Themes