/*����ũ�����ݿ���Ʒ����������*/

create table seedinfo				--������Ϣ��
(	seedid nchar(6) primary key,		--����ID
	seedname ntext,					--��������
	describe ntext,					--��������
	buyprice int,					--���Ӽ۸�
	mature_minute int,				--����ʱ�䣨���ӣ�
	outamount int,					--Ԥ�Ʋ���
	sellprice int,					--��ʵ������
	isselling bit,					--���۱�־λ
	pic_location text,				--ͼƬ·��
);

create table userinfo				--�û���Ϣ��
(	UserName nvarchar(256) primary key,	--�û���
	fieldnum int default 9,			--�ܵؿ���
	usermoney int default 50000,	--�����
);

create table seedstorage			--�û����Ӳֿ�
(	seedid nchar(6),				--����ID
	UserName nvarchar(256),			--�û���
	seedamount int,					--��������
	foreign key(seedid) references seedinfo(seedid),
	foreign key(UserName) references userinfo(UserName),
	primary key(seedid,UserName),
);

create table farmtable				--ũ��������
(	seedid nchar(6),				--����ID
	UserName nvarchar(256),			--�û���
	FieldNo int,					--�ڵڼ������
	addedtime datetime,				--��ֲʱ��
	leftgoods int,					--��ʣ��������
	foreign key(seedid) references seedinfo(seedid),
	foreign key(UserName) references userinfo(UserName),
	primary key(UserName,FieldNo),
);

create table foodstorage			--���յ�����
(	seedid nchar(6),				--����ID
	UserName nvarchar(256),			--�û���
	foodamount int,					--��������
	foreign key(seedid) references seedinfo(seedid),
	foreign key(UserName) references userinfo(UserName),
	primary key(UserName,seedid),
);

create table stoleinfo				--͵����Ϣ��¼��
(	source_user nvarchar(256),		--͵����
	target_user nvarchar(256),		--��͵����
	fieldno int,					--�ؿ�
	seedname ntext,					--��͵�˵�����
	stoledate date,					--͵������
	--����Ҫ�κ������Լ������Ϊ͵�����˻�����͵�����˻��ͱ�͵�Ĳ���ʱ�п��ܱ�ɾ��
);