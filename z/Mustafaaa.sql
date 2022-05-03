create database Mustafaaa
use Mustafaaa
create table Stadions(
Id int primary key identity,
Name nvarchar(30) not null unique,
HourPrice decimal(18,2),
Capacity int,


)
create table Users(
Id int primary key identity,
FullName nvarchar(30) not null,
Email nvarchar(100) not null unique
)
create table Reservations(
Ýd int primary key identity,
StadionId int foreign key references Stadions(Id) not null,
UserId int foreign key references Users(Id) not null,
StartDate datetime2 not null,
EndDate datetime2  not null
)