create database QueensUniversity

create table Registration
(
	StudentId char(10),
	Name varchar(50),
	DOB datetime,
	GradePointAvg decimal(18, 2),
	Active bit,
	PRIMARY KEY (StudentId)
)

insert into Registration values ('10001', 'Suwarnan', '5/8/1985', 2.04, 1)
insert into Registration values ('10002', 'Annu', '10/2/1988', 0.78, 0)

select * from Registration
