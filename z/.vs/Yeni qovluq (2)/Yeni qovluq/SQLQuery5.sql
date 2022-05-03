create database mart122
use mart122
create table Groups(
Id INT PRIMARY KEY IDENTITY,
No nvarchar(30)


)
create table Students(
Id INT PRIMARY KEY IDENTITY,
Name nvarchar(30) not null,
Surname nvarchar(30) not null,
GrupsId int foreign key references Groups(Id)




)
create table Subjects(

Id INT PRIMARY KEY IDENTITY,
Name nvarchar(30),





)
create table Exams(
Id INT PRIMARY KEY IDENTITY,
Date datetime not null,
SubjectsId int foreign key references Subjects(Id)




)
create table StudentExams(
Id INT PRIMARY KEY IDENTITY,
StudentsId int foreign key references Students(Id),
ExamsId int foreign key references Exams(Id),





)
