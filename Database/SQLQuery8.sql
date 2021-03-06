USE [QuanLyNganHangDeThi]
GO
ALTER proc [dbo].[sp_TTNV]
as
begin
select a.MaNV as N'Mã nhân viên',a.HoTen as N'Tên nhân viên',a.DiaChi as N'Địa chỉ',a.SDT as N'Số điện thoại',a.NgaySinh as N'Ngay sinh' from NhanVien a
where a.GhiChu=1
end
go
ALTER proc [dbo].[sp_ThemNV] (@Ten nvarchar(50),@DC nvarchar(350),@SDT varchar(11),@NS date)
as
begin

	if exists(select * from NhanVien a where a.DiaChi=@DC and a.GhiChu=0 and a.HoTen=@Ten and a.NgaySinh=@NS and a.SDT=@SDT)
	begin
		update NhanVien
		set GhiChu=1
		where DiaChi=@DC and HoTen=@Ten and NgaySinh=@NS and SDT=@SDT
	end
	else
	begin
		declare @tam nvarchar(10),@k int
			select @k=(select top 1 convert(int,SUBSTRING(a.MaNV,3,LEN(a.MaNV)-2)) from NhanVien a order by 1 desc)
			select @tam= 'NV'+convert(nvarchar(10),@k+1)

			insert into NhanVien
			values(@tam,@Ten,@DC,@SDT,@NS,1)
	end
end