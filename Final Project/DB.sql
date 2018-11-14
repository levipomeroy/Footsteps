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