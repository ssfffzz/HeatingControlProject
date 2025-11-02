use master--在master里使用数据库
go --批处理语句

if exists(select * from sysdatabases where name = 'ScanData')
drop database ScanData
go

create database ScanData    --创建MISDB数据库
on primary
(
	name ='ScanData_Mdata',
	filename='D:\DB\ScanData_Mdata.mdf',
	size=20MB,
	filegrowth=2MB
),
(
	name ='ScanData_Ndata',
	filename='D:\DB\ScanData_Ndata.ndf',
	size=20MB,
	filegrowth=2MB
)
log on
(
	name ='ScanData_log1',
	filename='D:\DB\ScanData_log1.ldf',
	size=20MB,
	filegrowth=2MB
)
go

--创建数据表，是在指定的数据库里面创建
use ScanData--在ScanData里使用数据表
go --批处理语句

if exists(select * from sysobjects where name = 'Scandata')
drop table Scandata
go

create table Scandata
(
	ScandataId int identity(1,1) primary key,
	ScandataDate datetime not null,
	ScandataString varchar(100) not null 
)
go