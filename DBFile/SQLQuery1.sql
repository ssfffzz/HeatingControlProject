use master--在master里使用数据库
go --批处理语句

if exists(select * from sysdatabases where name = 'MISDB')
drop database MISDB
go

create database MISDB    --创建MISDB数据库
on primary
(
	name ='MISDB_Mdata',
	filename='D:\DB\MISDB_Mdata.mdf',
	size=20MB,
	filegrowth=2MB
),
(
	name ='MISDB_Ndata',
	filename='D:\DB\MISDB_Ndata.ndf',
	size=20MB,
	filegrowth=2MB
)
log on
(
	name ='MISDB_log1',
	filename='D:\DB\MISDB_log1.ldf',
	size=20MB,
	filegrowth=2MB
)
go

--创建数据表，是在指定的数据库里面创建
use MISDB--在MISDB里使用数据表
go --批处理语句

if exists(select * from sysobjects where name = 'Department')--部门表
drop table Department
go
create table Department
(
	DepartmentId int identity(10,1) primary key,
	DepartmentName varchar(50) not null
)
go

if exists(select * from sysobjects where name = 'Post')--职位表
drop table Post
go
create table Post
(
	PostId int identity(10,1) primary key,
	PostName varchar(50) not null
)
go

if exists(select * from sysobjects where name = 'Employee')--员工表
drop table Employee
go
create table Employee
(
	EmployeeId int identity(100,1) primary key,--标识列
	EmployeeName varchar(50) not null,--员工名字
	Gender char(2) not null check(Gender = '男'or Gender = '女'),
	NowAddress nvarchar(100) default('地址不详'),--为空的时候默认给一个地址不详
	IdNo char(18) not null check (len(IdNo)=18),--身份证号为18位
	WeiXinNumber varchar(20) not null,
	PhoneNumber varchar(50) not null,	
	OtherWork varchar(50) not null,
	EntryDate DateTime not null,
	PostId int references Post(PostId),
	DepartmentId int references Department(DepartmentId)
)
go

use MISDB
go

insert into Department(DepartmentName) values('开发部'),('测试部')--insert into 数据表名称(数据列) values(往数据列里面插入的值)

insert into Post(PostName) values('开发工程师'),('测试工程师')

insert into Employee(EmployeeName,Gender,NowAddress,IdNo,WeiXinNumber,PhoneNumber,OtherWork,EntryDate,PostId,DepartmentId) 
values('小王','男','常州','111111111111111111','微信','123456789','暂无','25-11-1','10','10')

select * from Department
select * from Post
select * from Employee
select EmployeeName,Gender,NowAddress from Employee

select EmployeeName,Gender,NowAddress,Post.PostId,PostName from Employee 
inner join post on Employee.PostId=Post.PostId

update Post set PostName='研发' where PostId=10
delete from Post where PostId=11

