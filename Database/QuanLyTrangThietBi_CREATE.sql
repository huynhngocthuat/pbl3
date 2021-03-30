create database QuanLyTrangThietBi
go

use QuanLyTrangThietBi
go

create table ACCOUNT
(
	accountId int identity primary key,
	username varchar(50) not null,
	password varchar(1000) not null,
	role int not null,
	fullName nvarchar(50)
)
go

create table ZONE
(
	zoneId int identity primary key,
	name nvarchar(50)
)

create table ROOM
(
	roomId int identity primary key,
	zoneId int foreign key references ZONE (zoneId),
	name nvarchar(50) not null, --F110
	functionRoom nvarchar(100)
)
go

create table EQUIPMENT
(
	equipmentId int identity primary key,
	roomId int foreign key references ROOM (roomId) not null,
	name nvarchar(50),
	dateOfInstallation date,
	company nvarchar(50)
)
go

create table STATUS
(
	statusId int identity primary key,
	equipmentId int foreign key references EQUIPMENT (equipmentId) not null,
	equipmentStatus nvarchar(50)
)
go

create table REPORT
(
	reportId int identity primary key,
	accountId int foreign key references ACCOUNT (accountId) not null,
	roomId int foreign key references ROOM (roomId) not null,
	equipmentId int foreign key references EQUIPMENT (equipmentId) not null,
	statusId int foreign key references STATUS (statusId) not null,
	note ntext,
	reportStatus int default 0, --0: chưa được nhận tin, 1: chưa xử lý, 2: đang xử lý, 3: đã xử lý, 4: báo cáo sai
	reportedDate datetime default getDate(),
	isEdit bit default 1 --0: không được chỉnh sửa, 1: được chỉnh sửa
)
go

create table RESPONSE
(
	responseId int identity primary key,
	accountId int foreign key references ACCOUNT (accountId) not null,
	reportId int foreign key references REPORT (reportId) not null,
	message ntext not null,
	responseType int, --0: đã nhận tin, 1: xác nhận xử lý, 2: đã xử lý, 3: thông tin báo cáo sai
	responsedDate datetime default getDate()
)
go

--trigger đã nhận tin
--trigger xác nhận xử lý
--trigger xác nhận đã xử lý
--trigger phản hồi là báo cáo sai