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
--��������
	@username nvarchar(256),
	@seedid nchar(6),
	@amount int
as
	--���Ȼ�ȡ�û����
	declare @usermoney int
	select @usermoney=usermoney from userinfo where username=@username
	--Ȼ���ȡ�û���Ҫ�������ӵ��ܼ�
	declare @single int,@total int
	select @single=buyprice from seedinfo where seedid=@seedid
	select @total=@single*@amount
	--����û���Ǯ��������ô�����ӣ����׳��쳣
	if(@usermoney<@total)
		--raiserror('���Ľ���������Թ�����Щ���������ӣ��뷵�����ԡ�',0,0)
		return 0		--0��ʾfalse
	else
	--����㹻�򣬾�ִ�У�
	begin
		--1����Ǯ
		update userinfo set usermoney=@usermoney-@total where username=@username
		--2��Ϊ�û������Ӳֿ��м�����ô������������
		--2.1������û������Ӳֿ���û�д����ӵļ�¼��������
		if not exists(select * from seedstorage where username=@username and seedid=@seedid)
			insert into seedstorage values(@seedid,@username,@amount)
		--2.2������û������Ӳֿ����д����ӵļ�¼�����������
		else
			update seedstorage
			set seedamount+=@amount
			where seedid=@seedid and UserName=@username
		return 1		--1��ʾtrue
	end
go

create procedure sowseed
--������
	@username nvarchar(256),
	@seedid nchar(6),
	@fieldno int
as
	--1����ȡԤ�Ʋ���
	declare @amount int
	select @amount=outamount from seedinfo where seedid=@seedid
	--2����ũ����������ӣ�ʵ����Ϊ�޸ģ�
	update farmtable
	set seedid=@seedid,addedtime=getdate(),leftgoods=@amount
	where username=@username and fieldno=@fieldno
	--3�������Ӳֿ�Ϊ�����Ӽ�¼��1
	update seedstorage
	set seedamount-=1
	where seedid=@seedid and username=@username
	--4��������Ӳֿ�����Ӽ�¼Ϊ0��ɾ���˼�¼
	if(select seedamount from seedstorage where seedid=@seedid and username=@username)=0
		delete from seedstorage where seedid=@seedid and username=@username
go

create procedure harvest
--�ջ�
	@username nvarchar(256),
	@fieldno int
as
	--1����ȡҪ�ջ�����������ID�����ղ���
	declare @seedid nchar(6),@amount int
	select @seedid=seedid,@amount=leftgoods from farmtable where username=@username and fieldno=@fieldno
	--2���ڻ������������
	--2.1�����������û��������¼�������
	if not exists(select * from foodstorage where seedid=@seedid and username=@username)
		insert into foodstorage values(@seedid,@username,@amount)
	--2.2������Ѿ��У�������Ŀ
	else
		update foodstorage
		set foodamount+=@amount
		where seedid=@seedid and username=@username
	--2.3����ũ����ɾ�������¼����ɾ����ʵ��Ϊ����NULL��
	update farmtable
	set seedid=null,addedtime=null,leftgoods=null
	where username=@username and fieldno=@fieldno
go

create procedure sell
--���۳�Ʒ
	@seedid nchar(6),
	@username nvarchar(256)
as
	--1����ȡҪ���۳�Ʒ������
	declare @amount int
	select @amount=foodamount from foodstorage where seedid=@seedid and username=@username
	--2����ȡҪ���۳�Ʒ�ĵ���
	declare @single int
	select @single=sellprice from seedinfo where seedid=@seedid
	--3����Ǯ
	update userinfo
	set usermoney+=(@single*@amount)
	where username=@username
	--4�����û��Ļ���ȥ���˼�¼
	delete from foodstorage where seedid=@seedid and username=@username
go

create procedure stole
--͵�ˣ�͵3��
	@source_user nvarchar(256),		--͵����
	@target_user nvarchar(256),		--��͵����
	@fieldid int					--�ؿ�
as
	--1�����Ŀ��ؿ��seedid is null��͵��ʧ�ܣ�����ֵ��ʾ�Ѿ���ժ��
	if (select seedid from farmtable where UserName=@target_user and FieldNo=@fieldid) is null
		return 2					--2��ʾ�Ѿ���ժ
	--2���������͵���ˣ���͵��ʧ�ܣ�����ֵ��ʾ����͵����
	if (select max(stoledate) from stoleinfo
		where source_user=@source_user and target_user=@target_user and fieldno=@fieldid
		) = convert(date,getdate(),120)
		return 3					--3��ʾ����͵����
	--3����ȡĿ��ؿ������Ԥ�Ʋ�����ʵ�ʲ���
	declare @real_amount int,@design_amount int
	declare @seedid nchar(6),@seedname nvarchar(1024)
	select @seedid=seedid,@real_amount=leftgoods from farmtable where UserName=@target_user and FieldNo=@fieldid
	select @seedname=seedname,@design_amount=outamount from seedinfo where seedid=@seedid
	--4�����Ŀ��ؿ��ʵ�ʲ���С�ڵ���Ԥ�Ʋ�����50%��
	--   ����С�ڵ���3��͵��ʧ�ܣ�����ֵ��ʾ����������㣩
	if @real_amount<=(@design_amount/2) or @real_amount<=3
		return 1					--1��ʾ�����������
	else
	begin
		--5���������͵��
		--5.1 ���Լ��Ĳֿ����3��
		update foodstorage
		set foodamount+=3
		where UserName=@source_user and seedid=@seedid
		--5.2 ���Է���ũ��������ȥ3��
		update farmtable
		set leftgoods-=3
		where UserName=@target_user and FieldNo=@fieldid
		--5.3 ��¼�ڰ�
		insert into stoleinfo values(@source_user,@target_user,@fieldid,@seedname,convert(date,getdate(),120))
		return 0			--0��ʾ͵�˳ɹ�
	end
go