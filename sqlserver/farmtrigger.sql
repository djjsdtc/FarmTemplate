if exists(
	select name from sysobjects
	where name='delete_user' and type='TR'
)
drop trigger delete_user
if exists(
	select name from sysobjects
	where name='create_user' and type='TR'
)
drop trigger create_user
if exists(
	select name from sysobjects
	where name='alter_user' and type='TR'
)
drop trigger alter_user
go

create trigger delete_user on userinfo instead of delete
as
	declare @username nvarchar(256)
	select @username=UserName from DELETED
	delete from farmtable
	where UserName=@username
	delete from seedstorage
	where UserName=@username
	delete from foodstorage
	where UserName=@username
	delete from userinfo
	where UserName=@username
go

create trigger create_user on userinfo for insert
as
	declare @i int,@fieldnum int
	select @i=1
	declare @username nvarchar(256)
	select @username=UserName from inserted
	select @fieldnum=fieldnum from inserted
	while @i<=@fieldnum
	begin
		insert into farmtable values(null,@username,@i,null,null)
		set @i+=1
	end
go

create trigger alter_user on userinfo for update
as
	if update(fieldnum)
	begin
		declare @i int,@fieldnum int
		select @i=1
		declare @username nvarchar(256)
		select @username=UserName from inserted
		select @fieldnum=fieldnum from inserted
		while @i<=@fieldnum
		begin
			if not exists(select * from farmtable where username=@username and fieldno=@i)
				insert into farmtable values(null,@username,@i,null,null)
			set @i+=1
		end
	end
go