create proc USP_GetAccountByUserName
@userName nvarchar(100)
as
begin
	select * from tblAccount where userName = @userName
end
go

exec USP_GetAccountByUserName @userName = N'bruh'

select * from tblAccount where userName = 'nHut' and password = '1'

--insert loop
declare @i int = 0
while @i <= 10
begin
	insert tblTable (name) values (N'Table ' + cast(@i as nvarchar(100)))
	set @i = @i +1
end
go

select * from tblTable

go

create proc USP_GetTableList
as select * from tblTable
go

exec USP_GetTableList

select *from tblBill
go
select * from tblBillInfo
go
select * from tblFoods
select * from tblCategories

--add bill
insert tblBill (dateCheckIn, dateCheckOut, idTable, status)
values (GETDATE(), GETDATE(), 2,'UNPAID')
insert tblBill (dateCheckIn, dateCheckOut, idTable, status)
values (GETDATE(), GETDATE(), 3,'UNPAID')
insert tblBill (dateCheckIn, dateCheckOut, idTable, status)
values (GETDATE(), GETDATE(), 6,'UNPAID')
insert tblBill (dateCheckIn, dateCheckOut, idTable, status)
values (GETDATE(), GETDATE(), 4,'PAID')
go
--add bill info
insert tblBillInfo (idBill, idFood, count)
values (1, 3, 2)
insert tblBillInfo (idBill, idFood, count)
values (1, 4, 2)
insert tblBillInfo (idBill, idFood, count)
values (2, 5, 2)
insert tblBillInfo (idBill, idFood, count)
values (2, 7, 2)
insert tblBillInfo (idBill, idFood, count)
values (3, 1, 2)
insert tblBillInfo (idBill, idFood, count)
values (4, 8, 2)
go

--proc GetUncheck
select * from tblBill where idTable = and status = 'UNPAID'

select * from tblBillInfo where idBill =
go

--getBillinfoByTable
select f.name,binfo.count,f.price, f.price*binfo.count as totalprice  from tblBillInfo as binfo, tblBill a s bill, tblFoods as f
where binfo.idBill = bill.id and binfo.idFood = f.id and  bill.status = 'UNPAID' and bill.idTable = 3 
go

--
create proc USP_InsertBill @idTable int 
as
begin
	insert tblBill (dateCheckIn, dateCheckOut, idTable, status)
	values (getdate(), GETDATE(), @idTable, 'UNPAID')
end
go

--create roi moi alter proc

alter proc USP_InsertBillInfo 
@idBIll int, @idFood int, @count int
as
begin
	
	declare @isExistBillInfo int

	declare @foodCount int = 1

	select @isExistBillInfo = id, @foodCount =bi.count
	from tblBillInfo as bi
	where idBill = @idBIll and idFood = @idFood

	if(@isExistBillInfo > 0)
	begin
		
			update tblBillInfo set count = @foodCount + @count where idFood = @idFood and idBill = @idBIll 
		
	end
	else
	begin
		insert tblBillInfo (idBill, idFood, count)
		values (@idBIll, @idFood, @count)
	end
end
go

--
alter proc USP_DeleteBillInfo @idBill int, @idFood int, @count int
as
begin
	declare @isExistBillInfo int
	declare @foodCount int = 1

	select @isExistBillInfo = id, @foodCount =bi.count
	from tblBillInfo as bi
	where idBill = @idBIll and idFood = @idFood
	if(@isExistBillInfo > 0)
	begin
		declare @newCount int = @foodCount - @count
		update tblBillInfo set count = @foodCount - @count where idFood = @idFood and idBill = @idBill 
		if(@newCount <= 0)
			
			delete tblBillInfo where idBill = @idBill and idFood = @idFood 
	end

end
go

exec USP_DeleteBillInfo @idBill = 6, @idFood = 1, @count = 7
go
USP_InsertBillInfo 
@idBIll =5, @idFood =1, @count = 1
go

select * from tblBill
go
select * from tblBillInfo
go
select * from tblTable
go
select * from tblAccount
go 
select * from tblRoles
go
select * from tblAccount where userName ='nhut' and password ='1'
go
--ShowBill Statistical
delete tblBill

alter table tblBill add totalPrice float

go
select * from tblBill where dateCheckIn >= '2021-10-18' and dateCheckOut <= '2021-10-18' 
and status = 'PAID'
go
select t.name, b.totalPrice, b.dateCheckIn, b.dateCheckOut
from tblBill as b, tblTable as t
where b.dateCheckIn >= '2021-10-19' and b.dateCheckOut <= '2021-10-19' and b.status = 'PAID'
and t.id = b.idTable


go
select max(id) from tblBill
go

--Update AccountInfo
create proc USP_UpdateAccountInfo
@userName nvarchar(100), @displayName nvarchar(100), @passWord int, @newPass int
as
begin
	declare @isCorrectPass int = 0
	select @isCorrectPass = count(*) from tblAccount where userName = @userName and password = @passWord

	if(@isCorrectPass = 1)
	begin
		if(@newPass = null or @newPass = '')
		begin
			update tblAccount set accountName = @displayName where userName = @userName
		end
		else
			update tblAccount set accountName = @displayName, password = @newPass where userName = @userName
	end
end
go
alter table tblFoods add status nvarchar(30)
go
select * from tblFoods where status = 'active' and id = 2
go
select status from tblTable where status = 'Empty'
go
select f.name,binfo.count,f.price, f.price*binfo.count as totalprice
from tblBillInfo as binfo, tblBill as bill, tblFoods as f
where binfo.idBill = bill.id and binfo.idFood = f.id and bill.status = 'PAID' and bill.id = 43

go
alter table tblAccount add status nvarchar(30)
go
select userName as [User Name], roleId as [Role ID], accountName as [Display Name]
                from tblAccount where status = 'active'
go

select roleName from tblRoles 
go
update tblAccount set status = 'active' where userName = 'staff2'
go
select * from tblFoods where status = 'passive' and name = 'Su Su Cake'