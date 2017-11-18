if exists(select name from sysobjects where name='buyseed' and type='P')
drop procedure buyseed
if exists(select name from sysobjects where name='sowseed' and type='P')
drop procedure sowseed
if exists(select name from sysobjects where name='harvest' and type='P')
drop procedure harvest
if exists(select name from sysobjects where name='sell' and type='P')
drop procedure sell
if exists(select name from sysobjects where name='stole' and type='P')
drop procedure stole
go

create procedure buyseed
--购买种子
	@username nvarchar(256),
	@seedid nchar(6),
	@amount int
as
	--首先获取用户金额
	declare @usermoney int
	select @usermoney=usermoney from userinfo where username=@username
	--然后获取用户需要购买种子的总价
	declare @single int,@total int
	select @single=buyprice from seedinfo where seedid=@seedid
	select @total=@single*@amount
	--如果用户的钱不够买这么多种子，就抛出异常
	if(@usermoney<@total)
		--raiserror('您的金额数不足以购买这些数量的种子，请返回重试。',0,0)
		return 0		--0表示false
	else
	--如果足够买，就执行：
	begin
		--1、扣钱
		update userinfo set usermoney=@usermoney-@total where username=@username
		--2、为用户的种子仓库中加入这么多数量的种子
		--2.1、如果用户的种子仓库里没有此种子的记录，先新增
		if not exists(select * from seedstorage where username=@username and seedid=@seedid)
			insert into seedstorage values(@seedid,@username,@amount)
		--2.2、如果用户的种子仓库里有此种子的记录，则加上数量
		else
			update seedstorage
			set seedamount+=@amount
			where seedid=@seedid and UserName=@username
		return 1		--1表示true
	end
go

create procedure sowseed
--种种子
	@username nvarchar(256),
	@seedid nchar(6),
	@fieldno int
as
	--1、获取预计产量
	declare @amount int
	select @amount=outamount from seedinfo where seedid=@seedid
	--2、在农场表插入种子（实际上为修改）
	update farmtable
	set seedid=@seedid,addedtime=getdate(),leftgoods=@amount
	where username=@username and fieldno=@fieldno
	--3、从种子仓库为此种子记录减1
	update seedstorage
	set seedamount-=1
	where seedid=@seedid and username=@username
	--4、如果种子仓库此种子记录为0，删除此记录
	if(select seedamount from seedstorage where seedid=@seedid and username=@username)=0
		delete from seedstorage where seedid=@seedid and username=@username
go

create procedure harvest
--收获
	@username nvarchar(256),
	@fieldno int
as
	--1、获取要收获的作物的种子ID和最终产量
	declare @seedid nchar(6),@amount int
	select @seedid=seedid,@amount=leftgoods from farmtable where username=@username and fieldno=@fieldno
	--2、在货舱里添加作物
	--2.1、如果货舱里没有这条记录，就添加
	if not exists(select * from foodstorage where seedid=@seedid and username=@username)
		insert into foodstorage values(@seedid,@username,@amount)
	--2.2、如果已经有，加上数目
	else
		update foodstorage
		set foodamount+=@amount
		where seedid=@seedid and username=@username
	--2.3、从农场上删除这个记录（假删除，实际为设置NULL）
	update farmtable
	set seedid=null,addedtime=null,leftgoods=null
	where username=@username and fieldno=@fieldno
go

create procedure sell
--销售成品
	@seedid nchar(6),
	@username nvarchar(256)
as
	--1、获取要销售成品的数量
	declare @amount int
	select @amount=foodamount from foodstorage where seedid=@seedid and username=@username
	--2、获取要销售成品的单价
	declare @single int
	select @single=sellprice from seedinfo where seedid=@seedid
	--3、加钱
	update userinfo
	set usermoney+=(@single*@amount)
	where username=@username
	--4、从用户的货舱去除此记录
	delete from foodstorage where seedid=@seedid and username=@username
go

create procedure stole
--偷菜，偷3个
	@source_user nvarchar(256),		--偷菜者
	@target_user nvarchar(256),		--被偷菜者
	@fieldid int					--地块
as
	--1、如果目标地块的seedid is null则偷菜失败（返回值表示已经采摘）
	if (select seedid from farmtable where UserName=@target_user and FieldNo=@fieldid) is null
		return 2					--2表示已经采摘
	--2、如果今天偷过了，则偷菜失败（返回值表示今天偷过）
	if (select max(stoledate) from stoleinfo
		where source_user=@source_user and target_user=@target_user and fieldno=@fieldid
		) = convert(date,getdate(),120)
		return 3					--3表示今天偷过了
	--3、获取目标地块作物的预计产量和实际产量
	declare @real_amount int,@design_amount int
	declare @seedid nchar(6),@seedname nvarchar(1024)
	select @seedid=seedid,@real_amount=leftgoods from farmtable where UserName=@target_user and FieldNo=@fieldid
	select @seedname=seedname,@design_amount=outamount from seedinfo where seedid=@seedid
	--4、如果目标地块的实际产量小于等于预计产量的50%，
	--   或者小于等于3，偷菜失败（返回值表示请给主人留点）
	if @real_amount<=(@design_amount/2) or @real_amount<=3
		return 1					--1表示请给主人留点
	else
	begin
		--5、如果可以偷菜
		--5.1 给自己的仓库加上3个
		update foodstorage
		set foodamount+=3
		where UserName=@source_user and seedid=@seedid
		--5.2 给对方的农场存量减去3个
		update farmtable
		set leftgoods-=3
		where UserName=@target_user and FieldNo=@fieldid
		--5.3 记录在案
		insert into stoleinfo values(@source_user,@target_user,@fieldid,@seedname,convert(date,getdate(),120))
		return 0			--0表示偷菜成功
	end
go