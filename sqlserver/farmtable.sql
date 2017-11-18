/*按照农场数据库设计方案创建表格*/

create table seedinfo				--种子信息表
(	seedid nchar(6) primary key,		--种子ID
	seedname ntext,					--种子名称
	describe ntext,					--种子描述
	buyprice int,					--种子价格
	mature_minute int,				--成熟时间（分钟）
	outamount int,					--预计产量
	sellprice int,					--果实卖出价
	isselling bit,					--销售标志位
	pic_location text,				--图片路径
);

create table userinfo				--用户信息表
(	UserName nvarchar(256) primary key,	--用户名
	fieldnum int default 9,			--总地块数
	usermoney int default 50000,	--金币数
);

create table seedstorage			--用户种子仓库
(	seedid nchar(6),				--种子ID
	UserName nvarchar(256),			--用户名
	seedamount int,					--种子数量
	foreign key(seedid) references seedinfo(seedid),
	foreign key(UserName) references userinfo(UserName),
	primary key(seedid,UserName),
);

create table farmtable				--农场的数据
(	seedid nchar(6),				--种子ID
	UserName nvarchar(256),			--用户名
	FieldNo int,					--在第几块地上
	addedtime datetime,				--种植时间
	leftgoods int,					--还剩多少作物
	foreign key(seedid) references seedinfo(seedid),
	foreign key(UserName) references userinfo(UserName),
	primary key(UserName,FieldNo),
);

create table foodstorage			--货舱的数据
(	seedid nchar(6),				--种子ID
	UserName nvarchar(256),			--用户名
	foodamount int,					--作物数量
	foreign key(seedid) references seedinfo(seedid),
	foreign key(UserName) references userinfo(UserName),
	primary key(UserName,seedid),
);

create table stoleinfo				--偷菜信息记录表
(	source_user nvarchar(256),		--偷菜者
	target_user nvarchar(256),		--被偷菜者
	fieldno int,					--地块
	seedname ntext,					--被偷菜的名称
	stoledate date,					--偷菜日期
	--不需要任何主外键约束，因为偷菜者账户、被偷菜者账户和被偷的菜随时有可能被删除
);