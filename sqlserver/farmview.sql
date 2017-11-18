if exists(
	select name from sysobjects
	where name='onfarm'
)
drop view onfarm
go

create view onfarm
as
	-- (a)datediff(MINUTE,addedtime,getdate())：已经种植的时间（分钟）
	-- (b)mature_minute-(a)：剩余时间（分钟）
	-- (c)case when (b)>0 then (b) else 0 end：剩余时间负值归零
	select username,FieldNo,seedname,leftgoods,pic_location,
		   case when mature_minute-datediff(MINUTE,addedtime,getdate())>0 then
					 mature_minute-datediff(MINUTE,addedtime,getdate())
		   else 0
		   end as lefttime
	from farmtable left join seedinfo
	on farmtable.seedid=seedinfo.seedid
go