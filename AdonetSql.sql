CREATE DATABASE Cinema
USE Cinema

CREATE TABLE Halls(
Id int identity(1,1) PRIMARY KEY,
[Name] nvarchar(50) NOT NULL,
SeatCount int
)

CREATE TABLE Customers(
id int identity(1,1) PRIMARY KEY,
[Name] nvarchar(50) NOT NULL,
Surname nvarchar(60),
Age int
)

CREATE TABLE Films(
Id int identity(1,1) PRIMARY KEY,
[Name] nvarchar(50) NOT NULL,
ReleaseDate date
)

CREATE TABLE Sessionss(
Id int identity(1,1) PRIMARY KEY,
[Time] time
)

CREATE TABLE Tickets(
Id int identity(1,1) PRIMARY KEY,
SoldDate date,
Price decimal,
Place int,
CustomerId int references Customers(Id),
HallId int references Halls(Id),
FilmId int references Films(Id),
SessionId int references Sessionss(Id)
)

CREATE TABLE Genres(
Id int identity(1,1) PRIMARY KEY,
[Name] nvarchar(50) NOT NULL
)

CREATE TABLE Actors(
Id int identity(1,1) PRIMARY KEY,
Name nvarchar(50) NOT NULL,
Surname nvarchar(60),
Age int
)


CREATE TABLE FilmGenres(
Id int identity(1,1) PRIMARY KEY,
FilmId int references Films(Id),
GenreId int references Genres(Id)
)

CREATE TABLE fulmActors(
Id int identity(1,1) PRIMARY KEY,
FilmId int references Films(Id),
ActorId int references Actors(Id)
)

select * from Customers
select * from Actors
select * from Halls
select * from Films
select * from Genres
select * from FilmGenres
select * from Sessionss
select * from fulmActors
select * from Tickets