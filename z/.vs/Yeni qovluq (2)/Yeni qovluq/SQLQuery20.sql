create database mart999992
use mart999992
create table Groups(
Id INT PRIMARY KEY IDENTITY,
No nvarchar(30) not null


)

create table Students(
Id INT PRIMARY KEY IDENTITY,
Name nvarchar(30) not null,
Surname nvarchar(30) not null,
GrupsId int foreign key references Groups(Id)




)

create table Subjects(

Id INT PRIMARY KEY IDENTITY,
Name nvarchar(30) not null,





)
create table Exams(
Id INT PRIMARY KEY IDENTITY,
Date datetime2 DEFAULT(GETUTCDATE()),
SubjectsId int foreign key references Subjects(Id)




)
create table StudentExams(
Id INT PRIMARY KEY IDENTITY,
Result TINYINT,
StudentsId int foreign key references Students(Id),
ExamsId int foreign key references Exams(Id),





)
insert into Groups
values
('no1'),
('no2')
insert into Students
values
('Mustafa','Qasimzade',1),
('Eli', 'Isazade',2)
insert into Subjects
values
('Fizika'),
('Biologya')

insert into Exams
values
('2022-10-20',1),
('2022-10-21',2),
('2022-10-21',null)

insert into StudentExams
values
('1','2'),
('1','2')
SELECT Students.Id,  Name ,Surname, Groups.No FROM Students 
JOIN Groups ON GrupsId=Groups.Id
SELECT * FROM Students 
JOIN StudentExams ON StudentsId=Students.Id
SELECT * FROM Students 
select StudentExams.Id , StudentExams.ExamsId,StudentExams.StudentsId,Students.Surname from StudentExams
join Students on StudentExams.StudentsId=Students.Id
SELECT * FROM Students 

SELECT Id,Name,Surname,GrupsId,(SELECT AVG(Result From StudentExams  )) FROM Students






