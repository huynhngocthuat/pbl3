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
	fullName nvarchar(50),
	class varchar(50),
	faculty varchar(50)
)
go

SET IDENTITY_INSERT DBO.ACCOUNT ON
INSERT INTO DBO.ACCOUNT(accountId, username, password, role, fullName, class, faculty)
VALUES (1, 'huynhthuat', '123456', 0, 'Huynh Ngoc Thuat', '19TCLC_DT2', 'CNTT')
INSERT INTO DBO.ACCOUNT(accountId, username, password, role, fullName, class, faculty)
VALUES (2, 'ailinh', '123456', 1, 'Huynh Thi Ai Linh', null, 'CNTT')
SET IDENTITY_INSERT ACCOUNT OFF
INSERT INTO DBO.ACCOUNT VALUES('quochuy', '123456', 0, 'Le Quoc Huy', '19TCLC_DT2', 'CNTT')
INSERT INTO DBO.ACCOUNT VALUES('ducphuong', '123456', 1, 'Vu Duc Phuong', null, 'CNTT') 


create table ZONE
(
	zoneId varchar(10) primary key,
	name nvarchar(50)
)
go

INSERT INTO DBO.ZONE VALUES ('A', 'Khu A')
INSERT INTO DBO.ZONE VALUES ('B', 'Khu B')
INSERT INTO DBO.ZONE VALUES ('C', 'Khu C')
INSERT INTO DBO.ZONE VALUES ('D', 'Khu D')
INSERT INTO DBO.ZONE VALUES ('E', 'Khu E')
INSERT INTO DBO.ZONE VALUES ('F', 'Khu F')
INSERT INTO DBO.ZONE VALUES ('G', 'Khu G')
INSERT INTO DBO.ZONE VALUES ('H', 'Khu H')
INSERT INTO DBO.ZONE VALUES ('I', 'Khu I')
INSERT INTO DBO.ZONE VALUES ('K', 'Khu K')
INSERT INTO DBO.ZONE VALUES ('M', 'Khu M')
INSERT INTO DBO.ZONE VALUES ('TTHL', 'Trung Tam Hoc Lieu')


create table ROOM
(
	roomId varchar(10) primary key,
	zoneId varchar(10) foreign key references ZONE (zoneId),
	name nvarchar(50) not null, 
	functionRoom nvarchar(100)
)
go

INSERT INTO DBO.ROOM VALUES ('H101', 'H', 'Phong 101', 'Phong Hoc')
INSERT INTO DBO.ROOM VALUES ('H102', 'H', 'Phong 102', 'Phong Hoc')
INSERT INTO DBO.ROOM VALUES ('H103', 'H', 'Phong 103', 'Phong Hoc')
INSERT INTO DBO.ROOM VALUES ('H104', 'H', 'Phong 104', 'Phong Hoc')
INSERT INTO DBO.ROOM VALUES ('H105', 'H', 'Phong 105', 'Phong Hoc')
INSERT INTO DBO.ROOM VALUES ('H106', 'H', 'Phong 106', 'Phong Hoc')
INSERT INTO DBO.ROOM VALUES ('H107', 'H', 'Phong 107', 'Phong Hoc')

create table EQUIPMENT
(
	equipmentId varchar(10) primary key,
	roomId varchar(10) foreign key references ROOM (roomId) not null,
	name nvarchar(50),
	dateOfInstallation date,
	company nvarchar(50)
)
go

INSERT INTO DBO.EQUIPMENT VALUES ('tb1', 'H101', 'Ban Hoc', '2018-3-20', 'Rong Vang')
INSERT INTO DBO.EQUIPMENT VALUES ('tb2', 'H101', 'Ban Hoc', '2018-3-20', 'Rong Vang')
INSERT INTO DBO.EQUIPMENT VALUES ('tb3', 'H101', 'Ban Hoc', '2018-3-20', 'Rong Vang')
INSERT INTO DBO.EQUIPMENT VALUES ('tb4', 'H101', 'Ban Hoc', '2018-3-20', 'Rong Vang')
INSERT INTO DBO.EQUIPMENT VALUES ('air1', 'H101', 'May Dieu Hoa', '2019-3-20', 'Toshiba')
INSERT INTO DBO.EQUIPMENT VALUES ('air2', 'H101', 'May Dieu Hoa', '2019-3-20', 'Toshiba')
INSERT INTO DBO.EQUIPMENT VALUES ('air3', 'H101', 'May Dieu Hoa', '2019-3-20', 'Toshiba')
INSERT INTO DBO.EQUIPMENT VALUES ('air4', 'H101', 'May Dieu Hoa', '2019-3-20', 'Toshiba')


create table STATUS
(
	statusId varchar(10) primary key,
	equipmentId varchar(10) foreign key references EQUIPMENT (equipmentId) not null,
	equipmentStatus nvarchar(50)
)
go

INSERT INTO DBO.STATUS VALUES('tbS1', 'tb1', 'Hu Hong')
INSERT INTO DBO.STATUS VALUES('airS1', 'air1', 'Khong Hoat Dong')
INSERT INTO DBO.STATUS VALUES('airS2', 'air1', 'Hoat Dong Kem')

create table REPORT
(
	reportId int identity primary key,
	accountId int foreign key references ACCOUNT (accountId) not null,
	roomId varchar(10) foreign key references ROOM (roomId) not null,
	equipmentId varchar(10) foreign key references EQUIPMENT (equipmentId) not null,
	statusId varchar(10) foreign key references STATUS (statusId) not null,
	note ntext,
	reportStatus int default 0, --0: chưa được nhận tin, 1: chưa xử lý, 2: đã xử lý, 3: báo cáo sai
	reportedDate datetime default getDate(),
	isEdit bit default 1 --0: không được chỉnh sửa, 1: được chỉnh sửa
)
go

SET IDENTITY_INSERT REPORT ON
INSERT INTO DBO.REPORT (reportId, accountId, roomId, equipmentId, statusId, note, reportStatus, reportedDate, isEdit)
VALUES (1, 1, 'H101', 'tb1', 'tbS1', null, 2, SYSDATETIME(), 1)
INSERT INTO DBO.REPORT (reportId, accountId, roomId, equipmentId, statusId, note, reportStatus, reportedDate, isEdit)
VALUES (2, 4, 'H101', 'air1', 'airS1', null, 2, SYSDATETIME(), 1)
SET IDENTITY_INSERT REPORT OFF

create table RESPONSE
(
	responseId int identity primary key,
	accountId int foreign key references ACCOUNT (accountId) not null,
	reportId int foreign key references REPORT (reportId) not null,
	message ntext not null,
	responseType int, --0: đã nhận tin, 1: đã xử lý, 2: thông tin báo cáo sai
	responsedDate datetime default getDate()
)
go

SET IDENTITY_INSERT RESPONSE ON
INSERT INTO RESPONSE (responseId, accountId, reportId, message, responseType, responsedDate)
VALUES (1, 2, 1, 'Cam On', 1, SYSDATETIME())
INSERT INTO RESPONSE (responseId, accountId, reportId, message, responseType, responsedDate)
VALUES (2, 2, 2, 'Cam On', 1, SYSDATETIME())
SET IDENTITY_INSERT RESPONSE OFF

--trigger đã nhận tin
--trigger xác nhận xử lý
--trigger xác nhận đã xử lý
--trigger phản hồi là báo cáo sai