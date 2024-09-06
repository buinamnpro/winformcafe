create proc USP_getaccountbyusername
@username nvarchar(100)
as 
begin 
select * from dbo.account where username= @username 
end 
go
exec dbo.USP_getaccountbyusername @username = N'name'