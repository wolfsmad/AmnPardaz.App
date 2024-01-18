insert into	Users (UserName , Password) values ('daneshjo','123'),('daneshjo2','1234');
declare @UserId int;
set @UserId = SCOPE_IDENTITY();

insert into Courses(Title)
values('riazi'),('fizik'),('shimi'),('dini'),('sql'),('c#'),('varzesh'),('joghrafi'),('olum'),('tarikh'),('arabi');
declare @CourseId int;
set @CourseId = SCOPE_IDENTITY();

insert into Times (TimeName) values 
('8-10'),('10-12'),('13-15'),('15-17');
declare @TimeId int;
set @TimeId = SCOPE_IDENTITY();



insert into DayWeek (DayName) values 
('shanbe'),('1shanbe'),('2shanbe'),('3shanbe'),('4shanbe'),('5shanbe'),('jomee');
declare @DayId int;
set @DayId = SCOPE_IDENTITY();



insert into UserWeek (UserId,CourseId,DayId,TimeId) values
(2,2,1,1),(2,3,1,2),(2,4,1,3),(2,5,1,4),
(2,6,2,1),(2,7,2,2),(2,8,2,3),(2,9,2,4),
(2,10,3,1),(2,11,3,2),(2,12,3,3),(2,3,3,4),
(2,5,4,1),(2,7,4,2),(2,9,4,3),(2,11,4,4),
(2,2,5,1),(2,4,5,2),(2,6,5,3),(2,8,5,4),

(3,7,1,1),(3,8,1,2),(3,9,1,3),(3,10,1,4),
(3,11,2,1),(3,12,2,2),(3,2,2,3),(3,3,2,4),
(3,4,3,1),(3,5,3,2),(3,6,3,3),(3,2,3,4),
(3,4,4,1),(3,6,4,2),(3,8,4,3),(3,10,4,4),
(3,12,5,1),(3,7,5,2),(3,3,5,3),(3,5,5,4);

declare @UWID int;
set @UWID = SCOPE_IDENTITY();

select* from Users
select * from Courses
select * from DayWeek
select * from Times
select * from UserWeek