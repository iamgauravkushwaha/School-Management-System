create database schooldb
use schooldb
create table logintab
(
id int primary key identity(1,1),
username varchar(20),
password varchar(20)
);


insert into  logintab (username,password) values('guruji','guruji123');


create procedure proc_validuser(@a varchar(20) ,@b varchar(20))
as begin
select count(*) from logintab where username=@a and password=@b
end;

---------------------------------------------------------------------------------------
----------------------------------------------------------------------------------------
create table student
(
sclid int default(12122001),
stdid int identity (101,1) primary key,
stdname varchar(30),
dob date,
gender varchar(10),
phno bigint,
email varchar(40)
);
select * from student
insert into student (stdname,dob,gender,phno,email) values ('sani sukla','2015-12-12','male',9993942292,'sani@gmail.com');
create procedure proc_insert_std(@a varchar(30),@b date,@c varchar(10),@d bigint,@e varchar(40))
as begin
insert into student (stdname,dob,gender,phno,email) values (@a,@b,@c,@d,@e)
end;

create procedure proc_display_std
as begin
select * from student
end;

create procedure proc_update_stdi (@f int,@a varchar(30),@b date,@c varchar(10),@d bigint,@e varchar(40))
as begin
update student set stdname=@a,dob=@b,gender=@c,phno=@d,email=@e where stdid=@f
end;

create procedure proc_delete_std (@a int)
as begin
delete from student where stdid=@a
end;
create procedure proc_detail_student(@a int)
as begin
select stdname from student where stdid=@a
end;
-----------------------------------------------------------------------------------------
-----------------------------------------------------------------------------------------
create table subject
(
sclid int default(12122001),
subid int primary key,
subname varchar(30)
);
select * from subject
create procedure proc_insert_subject(@a int,@b varchar(30))
as begin
insert into subject (subid,subname) values(@a,@b)
end;

create procedure proc_edit_subject(@a int,@b varchar(30))
as begin
update subject set subname=@b where subid=@a
end;
create procedure proc_delete_subject(@a int)
as begin
delete from subject where subid=@a
end;

create procedure proc_display_subject
as begin
select subid,subname from subject
end;

create table teacher
(
tid int primary key,
tname varchar(30),
tsubject varchar(30),
gen varchar(20),
phno bigint,
email varchar(50),
 doj varchar(20)
)
 
select * from teacher
 
 create procedure proc_insert_teacher(@a int ,@b varchar(30),@c varchar(30),@d varchar(20),@e bigint,@f varchar(50),@g varchar(20))
 as begin
 insert into teacher values(@a,@b,@c,@d,@e,@f,@g)
 end;

 create procedure proc_edit_teacher(@a int ,@b varchar(30),@c varchar(30),@d varchar(20),@e bigint,@f varchar(50),@g varchar(20))
 as begin
 update teacher set tname=@b,tsubject=@c,gen=@d,phno=@e,email=@f,doj=@g where tid=@a
 end;

 create procedure proc_delete_teacher(@a int)
 as begin
 delete from teacher where tid=@a
 end

 create procedure pro_display_teacher
 as begin
 select * from teacher
 end;
 --------------------------------------------------------------------
 -------------------------------------------------------------------
 
 ----------------------------------------------------------
 ---------------------------------------------------
 create table sectioninfo
 (
 sid int primary key,
 sname varchar(30),
 class varchar(10),
 section varchar(3)
 )
 

 create procedure proc_insert_sectionin(@a int,@b varchar(30),@c varchar(10),@d varchar(3))
 as begin
 insert into sectioninfo values(@a,@b,@c,@d)
 end;

 select * from sectioninfo
 create procedure proc_display_sectionin
 as begin
 select * from sectioninfo
 end;
 create procedure proc_delete_sectionin(@a int)
 as begin
 delete from sectioninfo where sid=@a;
 end;
 --------------------------------------------------------------
 -------------------------------------------------------------
 create procedure proc_teacher_display
 as begin
select t.tid ,t.tname ,s.subid,t.tsubject,t.gen,t.phno,t.email, t.doj  from teacher t inner join subject s on s.subname=t.tsubject
end;

create procedure proc_students_display
as begin
select s.stdid,s.stdname,s.dob,s.gender,s.phno,s.email,sc.class,sc.section from student s inner join sectioninfo sc on s.stdid=sc.sid
end;