create database Musiii
use Musiii
create table Stadions
(

Id int primary key  identity,

Name nvarchar(30) not null,
HourPrice decimal(18,2) not null,
Capacity int not null 




)
create table Users 
(

Id int primary key  identity,
FullName nvarchar(60) not null,
Email nvarchar(60) not null




)
create table Reservations
(

Id int primary key  identity,
StartDate datetime2,
EndDate datetime2,
StadionId int foreign key references Stadions(Id),
UserId int foreign key references Users(Id) 




)
select *from Stadions