if exists(
	select name from sysobjects
	where name='onfarm'
)
drop view onfarm
go

create view onfarm
as
	-- (a)datediff(MINUTE,addedtime,getdate())���Ѿ���ֲ��ʱ�䣨���ӣ�
	-- (b)mature_minute-(a)��ʣ��ʱ�䣨���ӣ�
	-- (c)case when (b)>0 then (b) else 0 end��ʣ��ʱ�为ֵ����
	select username,FieldNo,seedname,leftgoods,pic_location,
		   case when mature_minute-datediff(MINUTE,addedtime,getdate())>0 then
					 mature_minute-datediff(MINUTE,addedtime,getdate())
		   else 0
		   end as lefttime
	from farmtable left join seedinfo
	on farmtable.seedid=seedinfo.seedid
go