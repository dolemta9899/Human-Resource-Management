create database HumanResourceManagement
go
use HumanResourceManagement
go


create table TaiKhoan(
acc char(15) not null primary key,
pass char(15) not null
)
go
create table PhongBan(
	[maPB] [char](10) NOT NULL,
	[tenPB] [nvarchar](30) NOT NULL,
	[SDT] [char](10) NULL,
	[Email] [char](30) NULL,
	
);
go

create table NhanVien(
	[maNV] [char](10) NOT NULL,
	[tenNV] [nvarchar](30) NOT NULL,
	[ngaySinh] [date] NULL,
	[gioiTinh] [nchar](5) NULL,
	[diaChi] [nvarchar](50) NULL,
	[SDT] [char](13) NULL,
	[maPB] [char](10) NOT NULL,
	[Luong] [money] NULL,
);
go
alter table NhanVien add primary key(maNV)
alter table PhongBan add primary key(maPB)
alter table NhanVien
add constraint M foreign key(maPB) references PhongBan(maPB)


------------------------Add Data-----------------
insert into PhongBan values('00001',N'Kế Hoạch',null,null)
insert into PhongBan values('00002',N'Đầu Tư',null,null)
insert into PhongBan values('00003',N'Thu Ngân',null,null)

insert into NhanVien values('00001',N'Lê Thanh Độ','1999-08-09',N'Nam',N'Thanh Hóa','0983965249','00001','20000')

insert into NhanVien values('00002',N'Nguyên Thị Lan','1999-07-28',N'Nữ',N'Bắc Ninh','0969524614','00002','30000')

insert into NhanVien values('00003',N'Trần Thị Huyền','1999-01-24',N'Nữ',N'Nam Định','0123456589','00001','40000')

insert into NhanVien values('00004',N'Mai Ngọc Lệ','1999-07-30',N'Nữ',N'Ninh Bình','0123456989','00002','50000')

insert into TaiKhoan values('admin','admin')


