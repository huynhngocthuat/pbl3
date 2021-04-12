create database QuanLyTrangThietBi
go

use QuanLyTrangThietBi
go

create table ACCOUNT
(
	accountId int identity primary key,
	username varchar(50) not null,
	password varchar(1000) not null,
	role int not null, --0: USER, 1: ADMIN
	fullName nvarchar(50),
	class varchar(50),
	faculty nvarchar(50)
)
go

create table ZONE
(
	zoneId nvarchar(50) primary key,
	zoneName nvarchar(50)
)

create table ROOM
(
<<<<<<< HEAD
	roomId varchar(10) primary key,
	zoneId varchar(10) foreign key references ZONE (zoneId),
	name nvarchar(50) not null, 
	functionRoom nvarchar(100)
=======
	roomId nvarchar(50) primary key, --F110
	zoneId nvarchar(50) foreign key references ZONE (zoneId) on delete cascade on update cascade,
	roomFunction nvarchar(100)
>>>>>>> 446db47268b86633b18b0589109f6a8805d475ea
)
go

create table EQUIPMENT
(
	equipmentId nvarchar(50) primary key,
	roomId nvarchar(50) foreign key  references ROOM (roomId) on delete cascade on update cascade not null,
	equipmentName nvarchar(50),
	dateOfInstallation date,
	company nvarchar(50)
)
go

create table STATUS
(
	statusId nvarchar(50) primary key,
	equipmentId nvarchar(50) foreign key references EQUIPMENT (equipmentId) on delete cascade on update cascade not null,
	equipmentStatus nvarchar(50)
)
go

create table REPORT
(
	reportId int identity primary key,
	accountId int foreign key references ACCOUNT (accountId) not null,
	roomId nvarchar(50) foreign key references ROOM (roomId) not null,
	equipmentId nvarchar(50) foreign key references EQUIPMENT (equipmentId) not null,
	statusId nvarchar(50) foreign key references STATUS (statusId) not null,
	note ntext,
	reportStatus int default 0, --0: chưa được nhận tin, 1: chưa xử lý, 2: đang xử lý, 3: đã xử lý, 4: báo cáo sai
	reportedDate datetime default getDate(),
	isEdit bit default 1 --0: không được chỉnh sửa, 1: được phép chỉnh sửa
)
go

create table RESPONSE
(
	responseId int identity primary key,
	accountId int foreign key references ACCOUNT (accountId) not null,
	reportId int foreign key references REPORT (reportId) not null,
	message ntext not null,
	responseType int not null, --0: đã nhận tin, 1: xác nhận xử lý, 2: đã xử lý, 3: thông tin của báo cáo sai
	responsedDate datetime default getDate()
)
go

--trigger for insert 1 record to RESPONSE table
create trigger trigger_response_insert
on RESPONSE
for insert
as
begin
	declare @responseId int
	declare @reportId int
	declare @responseType int
	select @responseId = responseId, @reportId = reportId, @responseType = responseType from inserted
	if @responseType = 0
		begin
			update REPORT set reportStatus = 1 where reportId = @reportId
			update REPORT set isEdit = 0 where reportId = @reportId
		end
	else if @responseType = 1
		begin
			update REPORT set reportStatus = 2 where reportId = @reportId
			update REPORT set isEdit = 0 where reportId = @reportId
		end
	else if @responseType = 2
		begin
			update REPORT set reportStatus = 3 where reportId = @reportId
			update REPORT set isEdit = 0 where reportId = @reportId
		end
	else if @responseType = 3
		begin
			update REPORT set reportStatus = 4 where reportId = @reportId
			update REPORT set isEdit = 0 where reportId = @reportId
		end
	else
		rollback transaction
end