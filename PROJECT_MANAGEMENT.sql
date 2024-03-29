use master
go

declare @db_name        nvarchar(50)  = N'PROJECT_MANAGEMENT' -- change db_name here and...
declare @delete_stmt    nvarchar(max) = N'drop    database if exists '  + quotename(@db_name)
declare @create_stmt    nvarchar(max) = N'create  database '            + quotename(@db_name)
execute sp_executesql @delete_stmt
execute sp_executesql @create_stmt
go

use PROJECT_MANAGEMENT -- here!!!!!!!!!!!!!!!
go

-- create main tables -----------------------------------------------------------------------------
create table [department] (
    [id]                            varchar(10)     not null,
    [name]                          nvarchar(30)    not null,
    [access_right]                  tinyint         not null,
);
go

create table [partner] (
    [id]                            varchar(10)     not null,
    [code]                          varchar(2)      not null,
    [functional]                    nvarchar(40)    not null,
    [name]                          varchar(35),
    [fullname_in_erc]               nvarchar(50),
    [tax_code]                      nvarchar(35),
    [legal_representative]          nvarchar(50),
    [title_of_legal_representative] nvarchar(30),
    [address]                       nvarchar(160),
);
go

-- has a foreign key ----------------------------
create table [employee] (
    [id]                            varchar(10)     not null,
    [first_name]                    nvarchar(10)    not null,
    [middle_name]                   nvarchar(30)    not null,
    [last_name]                     nvarchar(10)    not null,
    [sex]                           bit             not null, -- 1 is male, otherwise 0 is female
    [date_of_birth]                 date            not null,
    [citizen_id_number]             varchar(12)     not null,
    [type]                          tinyint         not null,

    [department_id]                 varchar(10)     not null,
);
go

create table [project] (
    [id]                            varchar(10)     not null,
    [name]                          nvarchar(50)    not null,
    [access_right]                  tinyint         not null,
    [status]                        tinyint         not null,
    [customer_name]                 nvarchar(20)    not null,
    
    [project_manager_id]            varchar(10)     not null,
);
go

create table [account] (
    [id]                            varchar(10)     not null,
    [password]                      varchar(30)     not null,
    [is_active]                     bit             not null, -- 1 is active, otherwise 0 is disabled

    [employee_id]                   varchar(10)     not null,
);
go

create table [employee_phone_number] (
    [id]                            varchar(10)     not null,
    [phone_number]                  char(10)        not null,

    [employee_id]                   varchar(10)     not null,
);
go

create table [role] (
    [id]                            varchar(10)     not null,
    [name]                          nvarchar(30)    not null,
    [permission_level]              tinyint         not null,

    [employee_id]                   varchar(10)     not null,
);
go

create table [job] (
    [id]                            varchar(10)     not null,
    [name]                          nvarchar(30)    not null,
    [access_right]                  int             not null,
    [status]                        tinyint         not null,
    [project_public]                bit             not null,
    [department_public]             bit             not null,
    [number_of_documents]           int             not null,
    [job_start_date]                date            not null,
    [job_end_date]                  date            not null,

    [job_manager_id]                varchar(10)     not null,
    [project_id]                    varchar(10)     not null,
);
go

create table [document] (
    [id]                            varchar(10)     not null,
    [title]                         nvarchar(450),
    [package]                       varchar(15),
    [work_item]                     nvarchar(50),
    [type]                          char(1),
    [partner_code]                  varchar(100),
    -- partner_name nvarchar(30),
    [revision_number]               char(1),
    [lastest_revision]              varchar(6),
    [date]                          date,
    [issue_purpose]                 char(2),
    [prepared_by]                   nvarchar(100),
    [checked_by]                    nvarchar(100),
    [approved_by]                   nvarchar(100),
    [action]                        nvarchar(20),
    [support]                       nvarchar(20),
    [referrence]                    nvarchar(20),
    [to_company]                    nvarchar(100),
    [issused_on]                    date,
    [issused_via]                   varchar(30),

    [job_id]                        varchar(10),
);
go

create table [document_native_file_format] (
    [id]                            varchar(10)     not null,
    [name]                          varchar(100),
    [native_file_format]            char(10),
    [link]                          varbinary(max),
);
go

-- many-to-many relationship ----------------------------------------------------------------------
create table [employee_belong_to_project] (
    [employee_id]                   varchar(10)     not null,
    [project_id]                    varchar(10)     not null,
);
go

create table [join_job] (
    [job_start_date]                date            not null,
    [job_end_date]                  date            not null,

    [employee_id]                   varchar(10)     not null,
    [job_id]                        varchar(10)     not null,
);
go

create table [implement_project] (
    [project_start_date]            date            not null,
    [project_end_date]              date            not null,

    [department_id]                 varchar(10)     not null,
    [project_id]                    varchar(10)     not null,
);
go

create table [join_project] (
    [project_id]                    varchar(10)     not null,
    [partner_id]                    varchar(10)     not null,
);
go

-- add primary key --------------------------------------------------------------------------------
alter table [department]                    add constraint [pk_department]          primary key ([id]);
alter table [partner]                       add constraint [pk_partner]             primary key ([id]);
alter table [employee]                      add constraint [pk_employee]            primary key ([id]);
alter table [project]                       add constraint [pk_project]             primary key ([id]);
alter table [account]                       add constraint [pk_account]             primary key ([id]);
alter table [employee_phone_number]         add constraint [pk_epn]                 primary key ([id]);
alter table [role]                          add constraint [pk_role]                primary key ([id]);
alter table [job]                           add constraint [pk_job]                 primary key ([id]);
alter table [document]                      add constraint [pk_document]            primary key ([id]);
alter table [document_native_file_format]   add constraint [pk_dnff]                primary key ([id]);
alter table [employee_belong_to_project]    add constraint [pk_ebtp]                primary key ([employee_id], [project_id]);
alter table [join_job]                      add constraint [pk_jj]                  primary key ([employee_id], [job_id]);
alter table [implement_project]             add constraint [pk_ip]                  primary key ([department_id], [project_id]);
alter table [join_project]                  add constraint [pk_jp]                  primary key ([project_id], [partner_id]);
go

-- add foreign key --------------------------------------------------------------------------------
alter table [employee]                      add constraint [fk_employee_department] foreign key ([department_id])       references [department]([id]);
alter table [project]                       add constraint [fk_project_employee]    foreign key ([project_manager_id])  references [employee]([id]);
alter table [account]                       add constraint [fk_account_employee]    foreign key ([employee_id])         references [employee]([id]);
alter table [employee_phone_number]         add constraint [fk_epn_employee]        foreign key ([employee_id])         references [employee]([id]);
alter table [role]                          add constraint [fk_role_employee]       foreign key ([employee_id])         references [employee]([id]);
alter table [job]                           add constraint [fk_job_employee]        foreign key ([job_manager_id])      references [employee]([id]);
alter table [job]                           add constraint [fk_job_project]         foreign key ([project_id])          references [project]([id]);
alter table [document]                      add constraint [fk_document_job]        foreign key ([job_id])              references [job]([id]);
alter table [document_native_file_format]   add constraint [fk_dnff_document]       foreign key ([id])                  references [document]([id]);
alter table [employee_belong_to_project]    add constraint [fk_ebtp_employee]       foreign key ([employee_id])         references [employee]([id]);
alter table [employee_belong_to_project]    add constraint [fk_ebtp_project]        foreign key ([project_id])          references [project]([id]);
alter table [join_job]                      add constraint [pk_jj_employee]         foreign key ([employee_id])         references [employee]([id]);
alter table [join_job]                      add constraint [pk_jj_job]              foreign key ([job_id])              references [job]([id]);
alter table [implement_project]             add constraint [fk_ip_department]       foreign key ([department_id])       references [department]([id]);
alter table [implement_project]             add constraint [fk_ip_project]          foreign key ([project_id])          references [project]([id]);
alter table [join_project]                  add constraint [fk_jp_project]          foreign key ([project_id])          references [project]([id]);
alter table [join_project]                  add constraint [fk_jp_partner]          foreign key ([partner_id])          references [partner]([id]);
go

--------------------------------------------------------- <INSERT VALUE> ---------------------------------------------------------
-- DEPARTMENT
INSERT INTO DEPARTMENT 
        (ID,		 NAME,						 ACCESS_RIGHT)
VALUES	('DRT00001', N'Ban giám đốc',			 0), -- Director
        ('MNG00001', N'Ban quản lý',	         1), -- Manager
        ('PDC00001', N'Ban sản xuất',			 2), -- Produce
        ('FNA00001', N'Phòng tài chính kế toán', 2), -- Financial accountant
        ('MKT00001', N'Phòng marketing',		 2), -- Marketing
        ('ADO00001', N'Phòng hành chính',		 2)  -- Administrative offices

-- PARTNER
INSERT INTO PARTNER
        (ID,		 CODE, FUNCTIONAL,									NAME,	 		FULLNAME_IN_ERC,									TAX_CODE,							LEGAL_REPRESENTATIVE,	TITLE_OF_LEGAL_REPRESENTATIVE,	ADDRESS)
VALUES	('PNR00001', 'EP', 'Employer',									'LDCOLD',		NULL,												NULL,								NULL,					NULL,							NULL),
        ('PNR00002', 'E1', 'PASSET',									'LDCOLD',		'PINE ASIA ASSET MANAGEMENT INC.',					'110111-1749352',					NULL,					NULL,						 	N'No. 7, Guijegeumyung-ro, 2-gil, Yeongdeungpo-gu, Seoul, Republic of Korea'),
        ('PNR00003', 'E2', 'Employer',									'AKDF',			'AMERICAN KOREAN DOLLAR FUNDING CO., LTD',			NULL,								'KIM HYUNG MIN',		'CEO',							N'#608, 11, Gukhoe-daero 72-gil, Yeongdeuingpo-gu, Seoul, Republic of Korea'),
        ('PNR00004', 'E3', 'Employer',									'THE MIND', 	'THE MIND INVESTMENT',								NULL,								NULL,					NULL,							NULL),
        ('PNR00005', 'E4', 'Employer',									'BCMP',			'BCMP CO., LTD',									'0806-814-9596-270101-81-91521',	'SHIN YONG HOON',		'President',					N'No. 10-7, Godeung-ro, Sujeong-gu, Seongnam-si, Gyeonggi-do, Republic of Korea'),
        ('PNR00006', 'P1', 'Project Management Consultant',				'BCMP',			'BCMP CO., LTD',									'0806-814-9596-270101-81-91521',	'SHIN YONG HOON',		'President',					N'No. 10-7, Godeung-ro, Sujeong-gu, Seongnam-si, Gyeonggi-do, Republic of Korea'),
        ('PNR00007', 'S*', 'Supervising Consultants',					NULL,			NULL,						  						NULL,								NULL,					NULL,							NULL),
        ('PNR00008', 'D*', 'Design (Engineering) Consultant',			NULL,			NULL,						  						NULL,								NULL,					NULL,							NULL),
        ('PNR00009', 'G1', 'Geological Survey Consultant',				'GEOGENY',		'GEOGENY CONSULTANTS GROUP INC.',					NULL,								'LEE JEONG SANG',		'Senior Director',				N'88 Dongkwang-ro(St) Seocho-gu, Seoul, Korea, 06585'),
        ('PNR00010', 'T*', 'Technical Consultant / Technical Advisor',	NULL,			NULL,						  						NULL,								NULL,					NULL,							NULL),
        ('PNR00011', '11', 'Contractor/Supplier/Vendor (**)',			'GDTS',			'GROUND DATA TECHNOLOGY SOLUTIONS COMPANY LIMITED',	'0316555128',						'TRẦN ANH TÚ',			'Giám đốc',						N'Tầng 12, Toà nhà trụ sở điều hành và trung tâm thương mại Viettel, số 285 Cách Mạng Tháng Tám, Phườgn 12, Quận 10, Thành phố Hồ Chí Minh, Việt Nam'),
        ('PNR00012', '21', 'Contractor/Supplier/Vendor (**)',			'ENVISOLUTION',	'ENVISOLUTION',										NULL,								'LÊ QUANG HUY',			'Giám đốc kỹ thuật',			N'32C Sương Nguyệt Ánh, Đà Lạt'),
        ('PNR00013', '31', 'Contractor/Supplier/Vendor (**)',			'TIN PHAT',		'TIN PHAT LAWFIRM',									NULL,								'NGUYỄN THỊ VÂN',		'Trưởng văn phòng',				N'VP tư vấn: Sảnh 1, Trung tâm hành chính tỉnh, số 36 Trần Phú, Phường 4, Đà Lạt, tỉnh Lâm Đồng ĐC: Số 131 Yersin, Phường 9, Đà Lạt, Lâm Đồng')

-- EMPLOYEE
INSERT INTO EMPLOYEE
        (ID,		 LAST_NAME, MIDDLE_NAME, 	FIRST_NAME,	SEX, DATE_OF_BIRTH,	CITIZEN_ID_NUMBER,	TYPE,	DEPARTMENT_ID)
VALUES	('EMP00001', N'Thục',	 N'Bình',	 	N'Quân',	1,	 '1985-9-27',	029144531829,		2,		'MNG00001'),
        ('EMP00002', N'Bùi',	 N'Thiên',	 	N'Mai', 	0,	 '1995-1-16', 	021471865207, 		2, 		'MNG00001'),
        ('EMP00003', N'Lê',		 N'Phương',	 	N'Lan', 	0,	 '1991-5-27', 	025929027435, 		2, 		'MNG00001'),
        
        ('EMP00004', N'Hướng',	 N'Duy',		N'Hải', 	1,	 '1975-8-13', 	023320208596, 		0, 		'PDC00001'),
        ('EMP00005', N'Lộ',		 N'Tường',	 	N'Lĩnh', 	1,	 '1965-7-10', 	020532789354, 		1, 		'PDC00001'),
        ('EMP00006', N'Tiêu',	 N'Thơ',		N'Thơ', 	0,	 '2000-8-24', 	021275019873, 		2, 		'PDC00001'),

        ('EMP00007', N'Công',	 N'Thuần',	 	N'Hậu', 	0,	 '1999-6-13', 	027732985174, 		0, 		'FNA00001'),
        ('EMP00008', N'Cao',	 N'Thanh',	 	N'Hà', 		0,	 '1984-7-11', 	023320917624, 		1, 		'FNA00001'),
        ('EMP00009', N'Tông',	 N'Uy',		 	N'Vũ', 		1,	 '1994-5-31', 	027345324178, 		2, 		'FNA00001'),

        ('EMP00010', N'Thái',	 N'Hồng',	 	N'Thuý', 	0,	 '1975-7-17', 	027724573280, 		0, 		'MKT00001'),
        ('EMP00011', N'Lý',		 N'Ngọc',	 	N'Trinh', 	0,	 '1970-7-13', 	025765936420, 		1, 		'MKT00001'),
        ('EMP00012', N'Tạ',		 N'Yến',		N'Hồng', 	0,	 '1998-5-10', 	022620641830, 		2, 		'MKT00001'),

        ('EMP00013', N'Viên',	 N'Mạnh',	 	N'Dũng', 	1,	 '2002-5-16',	021432704381, 		0, 		'ADO00001'),
        ('EMP00014', N'Lãnh',	 N'Đắc',		N'Di', 		1,	 '1980-4-2', 	021841803426, 		1, 		'ADO00001'),
        ('EMP00015', N'Quảng',	 N'Thuỵ',	 	N'Vân', 	0,	 '1973-6-16',	021920521076, 		2, 		'ADO00001'),

        ('EMP00016', N'Lý',		 N'Đức',		N'Anh', 	1,	 '1990-4-2', 	023463725826, 		2, 		'DRT00001'),
        ('EMP00017', N'Từ',		 N'Thanh Như',	N'Ngọc', 	0,	 '1983-6-16',	021926356376, 		2, 		'DRT00001'),
        ('EMP00018', N'Hồ',		 N'Bùi Ngọc',	N'Trúc', 	0,	 '1983-6-16',	021920534676, 		2, 		'DRT00001'),

        ('EMP00019', N'Hồ',		 N'Phạm Minh',	N'Trọng', 	1,	 '1998-7-20', 	023463435826, 		0, 		'PDC00001'),
        ('EMP00020', N'Nguyễn',	 N'Văn',		N'Nghiêm', 	1,	 '1983-6-16',	021920556756, 		1, 		'PDC00001'),
        ('EMP00021', N'Thái',	 N'Minh',		N'Trân', 	0,	 '1983-6-16',	021928765438, 		2, 		'PDC00001')

-- PROJECT
INSERT INTO PROJECT
        (ID,		 NAME,		 ACCESS_RIGHT,	STATUS,	CUSTOMER_NAME,	PROJECT_MANAGER_ID)
VALUES	('PRJ00001', N'Dự án A', 1, 			0, 		N'DA A', 		'EMP00001'),
        ('PRJ00002', N'Dự án B', 1, 			1, 		N'DA A', 		'EMP00002'),
        ('PRJ00003', N'Dự án C', 1, 			2, 		N'DA A', 		'EMP00003')

-- EMPLOYEE_BELONG_TO_PROJECT
INSERT INTO EMPLOYEE_BELONG_TO_PROJECT
        (EMPLOYEE_ID, 	PROJECT_ID) 
VALUES 	('EMP00001', 	'PRJ00001'),
        ('EMP00004',	'PRJ00001'),
        ('EMP00005',	'PRJ00001'),
        ('EMP00006',	'PRJ00001'),
        ('EMP00007',	'PRJ00001'),
        ('EMP00008',	'PRJ00001'),
        ('EMP00009',	'PRJ00001'),

        ('EMP00002',	'PRJ00002'),
        ('EMP00007',	'PRJ00002'),
        ('EMP00008',	'PRJ00002'),
        ('EMP00009',	'PRJ00002'),
        ('EMP00010',	'PRJ00002'),
        ('EMP00011',	'PRJ00002'),
        ('EMP00012',	'PRJ00002'),

        ('EMP00003',	'PRJ00003'),
        ('EMP00010',	'PRJ00003'),
        ('EMP00011',	'PRJ00003'),
        ('EMP00012',	'PRJ00003'),
        ('EMP00013',	'PRJ00003'),
        ('EMP00014',	'PRJ00003'),
        ('EMP00015',	'PRJ00003')

-- ACCOUNT
INSERT INTO ACCOUNT
        (ID,	 	 EMPLOYEE_ID,	PASSWORD,	IS_ACTIVE) 
VALUES	('ACC00001', 'EMP00001',	'Bcmp@123', 1),
        ('ACC00002', 'EMP00002',	'Bcmp@123', 1),
        ('ACC00003', 'EMP00003',	'Bcmp@123', 1),

        ('ACC00004', 'EMP00004',	'Bcmp@123', 1),
        ('ACC00005', 'EMP00005',	'Bcmp@123', 1),
        ('ACC00006', 'EMP00006',	'Bcmp@123', 1),

        ('ACC00007', 'EMP00007',	'Bcmp@123', 1),
        ('ACC00008', 'EMP00008',	'Bcmp@123', 1),
        ('ACC00009', 'EMP00009',	'Bcmp@123', 1),

        ('ACC00010', 'EMP00010',	'Bcmp@123', 1),
        ('ACC00011', 'EMP00011',	'Bcmp@123', 1),
        ('ACC00012', 'EMP00012',	'Bcmp@123', 1),

        ('ACC00013', 'EMP00013',	'Bcmp@123', 1),
        ('ACC00014', 'EMP00014',	'Bcmp@123', 1),
        ('ACC00015', 'EMP00015',	'Bcmp@123', 1),

        ('ACC00016', 'EMP00016',	'Bcmp@123', 1),
        ('ACC00017', 'EMP00017',	'Bcmp@123', 1),
        ('ACC00018', 'EMP00018',	'Bcmp@123', 1),

        ('ACC00019', 'EMP00019',	'Bcmp@123', 0),
        ('ACC00020', 'EMP00020',	'Bcmp@123', 0),
        ('ACC00021', 'EMP00021',	'Bcmp@123', 0)

-- EMPLOYEE_PHONE_NUMBER
INSERT INTO EMPLOYEE_PHONE_NUMBER
        (ID,		 EMPLOYEE_ID,	PHONE_NUMBER)
VALUES 	('EPN00001', 'EMP00001',	'0984321980'),
        ('EPN00002', 'EMP00002',	'0987621980'),
        ('EPN00003', 'EMP00002',	'0962457880'),
        ('EPN00004', 'EMP00002',	'0988468880'),
        ('EPN00005', 'EMP00003',	'0987511981'),

        ('EPN00006', 'EMP00004',	'0962501981'),
        ('EPN00007', 'EMP00005',	'0866641989'),
        ('EPN00008', 'EMP00006',	'0866751989'),
        ('EPN00009', 'EMP00006',	'0867327889'),

        ('EPN00010', 'EMP00007',	'0868663499'),
        ('EPN00011', 'EMP00008',	'0356514988'),
        ('EPN00012', 'EMP00009',	'0971745424'),

        ('EPN00013', 'EMP00010',	'0369500086'),
        ('EPN00014', 'EMP00011',	'0867674114'),
        ('EPN00015', 'EMP00011',	'0862752514'),
        ('EPN00016', 'EMP00012',	'0389115488'),
        ('EPN00017', 'EMP00012',	'0337113758'),

        ('EPN00018', 'EMP00013',	'0348140291'),
        ('EPN00019', 'EMP00014',	'0385010895'),
        ('EPN00020', 'EMP00015',	'0354940886'),
        ('EPN00021', 'EMP00015',	'0357370536'),
        ('EPN00022', 'EMP00015',	'0353453453'),
        ('EPN00023', 'EMP00015',	'0353075286')

-- ROLE
INSERT INTO ROLE
        (ID,			NAME,			PERMISSION_LEVEL,	EMPLOYEE_ID)
VALUES	('RLE00001',	N'Quản lý',		1,					'EMP00001'),
        ('RLE00002',	N'Quản lý',		1,					'EMP00002'),
        ('RLE00003',	N'Quản lý',		1,					'EMP00003'),

        ('RLE00004',	N'Nhân viên',	2,					'EMP00004'),
        ('RLE00005',	N'Nhân viên',	2,					'EMP00005'),
        ('RLE00006',	N'Nhân viên',	2,					'EMP00006'),

        ('RLE00007',	N'Nhân viên',	2,					'EMP00007'),
        ('RLE00008',	N'Nhân viên',	2,					'EMP00008'),
        ('RLE00009',	N'Nhân viên',	2,					'EMP00009'),

        ('RLE00010',	N'Nhân viên',	2,					'EMP00010'),
        ('RLE00011',	N'Nhân viên',	2,					'EMP00011'),
        ('RLE00012',	N'Nhân viên',	2,					'EMP00012'),

        ('RLE00013',	N'Nhân viên',	2,					'EMP00013'),
        ('RLE00014',	N'Nhân viên',	2,					'EMP00014'),
        ('RLE00015',	N'Nhân viên',	2,					'EMP00015'),

        ('RLE00016',	N'CEO',			0,					'EMP00016'),
        ('RLE00017',	N'CEO',			0,					'EMP00017'),
        ('RLE00018',	N'CEO',			0,					'EMP00018'),

        ('RLE00019',	N'Nhân viên',	2,					'EMP00019'),
        ('RLE00020',	N'Nhân viên',	2,					'EMP00020'),
        ('RLE00021',	N'Nhân viên',	2,					'EMP00021')

-- JOB
INSERT INTO JOB
        (ID,		 JOB_MANAGER_ID, NAME,				ACCESS_RIGHT,	STATUS,	PROJECT_PUBLIC,	DEPARTMENT_PUBLIC,	PROJECT_ID,	JOB_START_DATE,	JOB_END_DATE,	NUMBER_OF_DOCUMENTS)
VALUES  ('JOB00001', 'EMP00004',	 N'Công việc 1',	1,				1,		1,				1,					'PRJ00001',	'2023-1-1',		'2023-3-30',	1),
        ('JOB00002', 'EMP00005',	 N'Công việc 2',	1,				1,		1,				1,					'PRJ00001',	'2023-1-1',		'2023-3-30',	1),
        ('JOB00003', 'EMP00006',	 N'Công việc 3',	1,				1,		1,				1,					'PRJ00001',	'2023-1-1',		'2023-3-30',	1),
        ('JOB00004', 'EMP00007',	 N'Công việc 4',	1,				1,		1,				1,					'PRJ00001',	'2023-1-1',		'2023-3-30',	1),
        ('JOB00005', 'EMP00008',	 N'Công việc 5',	1,				1,		1,				1,					'PRJ00001',	'2023-1-1',		'2023-3-30',	1),
        ('JOB00006', 'EMP00009',	 N'Công việc 6',	1,				1,		1,				1,					'PRJ00001',	'2023-1-1',		'2023-3-30',	1),
        ('JOB00007', 'EMP00010',	 N'Công việc 7',	1,				1,		1,				1,					'PRJ00001',	'2023-1-1',		'2023-3-30',	1),
        ('JOB00008', 'EMP00011',	 N'Công việc 8',	1,				1,		1,				1,					'PRJ00001',	'2023-1-1',		'2023-3-30',	1),
        ('JOB00009', 'EMP00012',	 N'Công việc 9',	1,				1,		1,				1,					'PRJ00001',	'2023-1-1',		'2023-3-30',	1),
        ('JOB00010', 'EMP00013',	 N'Công việc 10',	1,				1,		1,				1,					'PRJ00001',	'2023-1-1',		'2023-3-30',	1),
        ('JOB00011', 'EMP00014',	 N'Công việc 11',	1,				1,		1,				1,					'PRJ00001',	'2023-1-1',		'2023-3-30',	1),
        ('JOB00012', 'EMP00015',	 N'Công việc 12',	1,				1,		1,				1,					'PRJ00001',	'2023-1-1',		'2023-3-30',	1),
        ('JOB00013', 'EMP00016',	 N'Công việc 13',	1,				1,		1,				1,					'PRJ00001',	'2023-1-1',		'2023-3-30',	1),
        ('JOB00014', 'EMP00017',	 N'Công việc 14',	1,				1,		1,				1,					'PRJ00001',	'2023-1-1',		'2023-3-30',	1),
        ('JOB00015', 'EMP00018',	 N'Công việc 15',	1,				1,		1,				1,					'PRJ00001',	'2023-1-1',		'2023-3-30',	1),
        ('JOB00016', 'EMP00019',	 N'Công việc 1',	1,				1,		1,				1,					'PRJ00002',	'2023-2-1',		'2023-3-01',	1),
        ('JOB00017', 'EMP00020',	 N'Công việc 2',	1,				1,		1,				1,					'PRJ00002',	'2023-2-1',		'2023-3-01',	1),
        ('JOB00018', 'EMP00021',	 N'Công việc 3',	1,				1,		1,				1,					'PRJ00002',	'2023-2-1',		'2023-3-01',	1),
        ('JOB00019', 'EMP00004',	 N'Công việc 4',	1,				1,		1,				1,					'PRJ00002',	'2023-2-1',		'2023-3-01',	1),
        ('JOB00020', 'EMP00005',	 N'Công việc 5',	1,				1,		1,				1,					'PRJ00002',	'2023-2-1',		'2023-3-01',	1),
        ('JOB00021', 'EMP00006',	 N'Công việc 6',	1,				1,		1,				1,					'PRJ00002',	'2023-2-1',		'2023-3-01',	1),
        ('JOB00022', 'EMP00007',	 N'Công việc 7',	1,				1,		1,				1,					'PRJ00002',	'2023-2-1',		'2023-3-01',	1),
        ('JOB00023', 'EMP00008',	 N'Công việc 8',	1,				1,		1,				1,					'PRJ00002',	'2023-2-1',		'2023-3-01',	1),
        ('JOB00024', 'EMP00009',	 N'Công việc 9',	1,				1,		1,				1,					'PRJ00002',	'2023-2-1',		'2023-3-01',	1),
        ('JOB00025', 'EMP00010',	 N'Công việc 10',	1,				1,		1,				1,					'PRJ00002',	'2023-2-1',		'2023-3-01',	1),
        ('JOB00026', 'EMP00011',	 N'Công việc 11',	1,				1,		1,				1,					'PRJ00002',	'2023-2-1',		'2023-3-01',	1),
        ('JOB00027', 'EMP00012',	 N'Công việc 12',	1,				1,		1,				1,					'PRJ00002',	'2023-2-1',		'2023-3-01',	1),
        ('JOB00028', 'EMP00013',	 N'Công việc 13',	1,				1,		1,				1,					'PRJ00002',	'2023-2-1',		'2023-3-01',	1),
        ('JOB00029', 'EMP00014',	 N'Công việc 14',	1,				1,		1,				1,					'PRJ00002',	'2023-2-1',		'2023-3-01',	1),
        ('JOB00030', 'EMP00015',	 N'Công việc 15',	1,				1,		1,				1,					'PRJ00002',	'2023-2-1',		'2023-3-01',	1),
        ('JOB00031', 'EMP00016',	 N'Công việc 1',	1,				1,		1,				1,					'PRJ00003',	'2022-3-10',	'2022-4-01',	1),
        ('JOB00032', 'EMP00017',	 N'Công việc 2',	1,				1,		1,				1,					'PRJ00003',	'2022-3-10',	'2022-4-01',	1),
        ('JOB00033', 'EMP00018',	 N'Công việc 3',	1,				1,		1,				1,					'PRJ00003',	'2022-3-10',	'2022-4-01',	1),
        ('JOB00034', 'EMP00019',	 N'Công việc 4',	1,				1,		1,				1,					'PRJ00003',	'2022-3-10',	'2022-4-01',	1),
        ('JOB00035', 'EMP00020',	 N'Công việc 5',	1,				1,		1,				1,					'PRJ00003',	'2022-3-10',	'2022-4-01',	1),
        ('JOB00036', 'EMP00021',	 N'Công việc 6',	1,				1,		1,				1,					'PRJ00003',	'2022-3-10',	'2022-4-01',	1),
        ('JOB00037', 'EMP00004',	 N'Công việc 7',	1,				1,		1,				1,					'PRJ00003',	'2022-3-10',	'2022-4-01',	1),
        ('JOB00038', 'EMP00005',	 N'Công việc 8',	1,				1,		1,				1,					'PRJ00003',	'2022-3-10',	'2022-4-01',	1),
        ('JOB00039', 'EMP00006',	 N'Công việc 9',	1,				1,		1,				1,					'PRJ00003',	'2022-3-10',	'2022-4-01',	1),
        ('JOB00040', 'EMP00007',	 N'Công việc 10',	1,				1,		1,				1,					'PRJ00003',	'2022-3-10',	'2022-4-01',	1),
        ('JOB00041', 'EMP00008',	 N'Công việc 11',	1,				1,		1,				1,					'PRJ00003',	'2022-3-10',	'2022-4-01',	1),
        ('JOB00042', 'EMP00009',	 N'Công việc 12',	1,				1,		1,				1,					'PRJ00003',	'2022-3-10',	'2022-4-01',	1),
        ('JOB00043', 'EMP00010',	 N'Công việc 13',	1,				1,		1,				1,					'PRJ00003',	'2022-3-10',	'2022-4-01',	1),
        ('JOB00044', 'EMP00011',	 N'Công việc 14',	1,				1,		1,				1,					'PRJ00003',	'2022-3-10',	'2022-4-01',	1),
        ('JOB00045', 'EMP00012',	 N'Công việc 15',	1,				1,		1,				1,					'PRJ00003',	'2022-3-10',	'2022-4-01',	1),
        ('JOB00046', 'EMP00013',	 N'Công việc 16',	1,				1,		1,				1,					'PRJ00003',	'2022-3-10',	'2022-4-01',	1)

-- JOIN_JOB
INSERT INTO JOIN_JOB
        (EMPLOYEE_ID, JOB_ID,	 JOB_START_DATE, JOB_END_DATE)
VALUES	('EMP00004', 'JOB00001', '2023-1-1',	 '2023-1-1'),
        ('EMP00005', 'JOB00001', '2023-1-1',	 '2023-1-1'),
        ('EMP00005', 'JOB00002', '2023-1-1',	 '2023-1-1'),
        ('EMP00006', 'JOB00002', '2023-1-1',	 '2023-1-1'),
        ('EMP00006', 'JOB00003', '2023-1-1',	 '2023-1-1'),
        ('EMP00007', 'JOB00003', '2023-1-1',	 '2023-1-1'),
        ('EMP00007', 'JOB00004', '2023-1-1',	 '2023-1-1'),
        ('EMP00008', 'JOB00004', '2023-1-1',	 '2023-1-1'),
        ('EMP00008', 'JOB00005', '2023-1-1',	 '2023-1-1'),
        ('EMP00009', 'JOB00005', '2023-1-1',	 '2023-1-1'),
        ('EMP00009', 'JOB00006', '2023-1-1',	 '2023-1-1'),
        ('EMP00010', 'JOB00006', '2023-1-1',	 '2023-1-1'),
        ('EMP00010', 'JOB00007', '2023-1-1',	 '2023-1-1'),
        ('EMP00011', 'JOB00007', '2023-1-1',	 '2023-1-1'),
        ('EMP00011', 'JOB00008', '2023-1-1',	 '2023-1-1'),
        ('EMP00012', 'JOB00008', '2023-1-1',	 '2023-1-1'),
        ('EMP00012', 'JOB00009', '2023-1-1',	 '2023-1-1'),
        ('EMP00013', 'JOB00009', '2023-1-1',	 '2023-1-1'),
        ('EMP00013', 'JOB00010', '2023-1-1',	 '2023-1-1'),
        ('EMP00014', 'JOB00010', '2023-1-1',	 '2023-1-1'),
        ('EMP00014', 'JOB00011', '2023-1-1',	 '2023-1-1'),
        ('EMP00015', 'JOB00011', '2023-1-1',	 '2023-1-1'),
        ('EMP00015', 'JOB00012', '2023-1-1',	 '2023-1-1'),
        ('EMP00016', 'JOB00012', '2023-1-1',	 '2023-1-1'),
        ('EMP00016', 'JOB00013', '2023-1-1',	 '2023-1-1'),
        ('EMP00017', 'JOB00013', '2023-1-1',	 '2023-1-1'),
        ('EMP00017', 'JOB00014', '2023-1-1',	 '2023-1-1'),
        ('EMP00018', 'JOB00014', '2023-1-1',	 '2023-1-1'),
        ('EMP00018', 'JOB00015', '2023-1-1',	 '2023-1-1'),
        ('EMP00019', 'JOB00015', '2023-1-1',	 '2023-1-1'),
        ('EMP00019', 'JOB00016', '2023-1-1',	 '2023-1-1'),
        ('EMP00020', 'JOB00016', '2023-1-1',	 '2023-1-1'),
        ('EMP00020', 'JOB00017', '2023-1-1',	 '2023-1-1'),
        ('EMP00021', 'JOB00017', '2023-1-1',	 '2023-1-1'),
        ('EMP00021', 'JOB00018', '2023-1-1',	 '2023-1-1'),
        ('EMP00004', 'JOB00018', '2023-1-1',	 '2023-1-1'),
        ('EMP00004', 'JOB00019', '2023-1-1',	 '2023-1-1'),
        ('EMP00005', 'JOB00019', '2023-1-1',	 '2023-1-1'),
        ('EMP00005', 'JOB00020', '2023-1-1',	 '2023-1-1'),
        ('EMP00006', 'JOB00020', '2023-1-1',	 '2023-1-1'),
        ('EMP00006', 'JOB00021', '2023-1-1',	 '2023-1-1'),
        ('EMP00007', 'JOB00021', '2023-1-1',	 '2023-1-1'),
        ('EMP00007', 'JOB00022', '2023-1-1',	 '2023-1-1'),
        ('EMP00008', 'JOB00022', '2023-1-1',	 '2023-1-1'),
        ('EMP00008', 'JOB00023', '2023-1-1',	 '2023-1-1'),
        ('EMP00009', 'JOB00023', '2023-1-1',	 '2023-1-1'),
        ('EMP00009', 'JOB00024', '2023-1-1',	 '2023-1-1'),
        ('EMP00010', 'JOB00024', '2023-1-1',	 '2023-1-1'),
        ('EMP00010', 'JOB00025', '2023-1-1',	 '2023-1-1'),
        ('EMP00011', 'JOB00025', '2023-1-1',	 '2023-1-1'),
        ('EMP00011', 'JOB00026', '2023-1-1',	 '2023-1-1'),
        ('EMP00012', 'JOB00026', '2023-1-1',	 '2023-1-1'),
        ('EMP00012', 'JOB00027', '2023-1-1',	 '2023-1-1'),
        ('EMP00013', 'JOB00027', '2023-1-1',	 '2023-1-1'),
        ('EMP00013', 'JOB00028', '2023-1-1',	 '2023-1-1'),
        ('EMP00014', 'JOB00028', '2023-1-1',	 '2023-1-1'),
        ('EMP00014', 'JOB00029', '2023-1-1',	 '2023-1-1'),
        ('EMP00015', 'JOB00029', '2023-1-1',	 '2023-1-1'),
        ('EMP00015', 'JOB00030', '2023-1-1',	 '2023-1-1'),
        ('EMP00016', 'JOB00030', '2023-1-1',	 '2023-1-1'),
        ('EMP00016', 'JOB00031', '2023-1-1',	 '2023-1-1'),
        ('EMP00017', 'JOB00031', '2023-1-1',	 '2023-1-1'),
        ('EMP00017', 'JOB00032', '2023-1-1',	 '2023-1-1'),
        ('EMP00018', 'JOB00032', '2023-1-1',	 '2023-1-1'),
        ('EMP00018', 'JOB00033', '2023-1-1',	 '2023-1-1'),
        ('EMP00019', 'JOB00033', '2023-1-1',	 '2023-1-1'),
        ('EMP00019', 'JOB00034', '2023-1-1',	 '2023-1-1'),
        ('EMP00020', 'JOB00034', '2023-1-1',	 '2023-1-1'),
        ('EMP00020', 'JOB00035', '2023-1-1',	 '2023-1-1'),
        ('EMP00021', 'JOB00035', '2023-1-1',	 '2023-1-1'),
        ('EMP00021', 'JOB00036', '2023-1-1',	 '2023-1-1'),
        ('EMP00004', 'JOB00036', '2023-1-1',	 '2023-1-1'),
        ('EMP00004', 'JOB00037', '2023-1-1',	 '2023-1-1'),
        ('EMP00005', 'JOB00037', '2023-1-1',	 '2023-1-1'),
        ('EMP00005', 'JOB00038', '2023-1-1',	 '2023-1-1'),
        ('EMP00006', 'JOB00038', '2023-1-1',	 '2023-1-1'),
        ('EMP00006', 'JOB00039', '2023-1-1',	 '2023-1-1'),
        ('EMP00007', 'JOB00039', '2023-1-1',	 '2023-1-1'),
        ('EMP00007', 'JOB00040', '2023-1-1',	 '2023-1-1'),
        ('EMP00008', 'JOB00040', '2023-1-1',	 '2023-1-1'),
        ('EMP00008', 'JOB00041', '2023-1-1',	 '2023-1-1'),
        ('EMP00009', 'JOB00041', '2023-1-1',	 '2023-1-1'),
        ('EMP00009', 'JOB00042', '2023-1-1',	 '2023-1-1'),
        ('EMP00010', 'JOB00042', '2023-1-1',	 '2023-1-1'),
        ('EMP00010', 'JOB00043', '2023-1-1',	 '2023-1-1'),
        ('EMP00011', 'JOB00043', '2023-1-1',	 '2023-1-1'),
        ('EMP00011', 'JOB00044', '2023-1-1',	 '2023-1-1'),
        ('EMP00012', 'JOB00044', '2023-1-1',	 '2023-1-1'),
        ('EMP00012', 'JOB00045', '2023-1-1',	 '2023-1-1'),
        ('EMP00013', 'JOB00045', '2023-1-1',	 '2023-1-1'),
        ('EMP00013', 'JOB00046', '2023-1-1',	 '2023-1-1'),
        ('EMP00014', 'JOB00046', '2023-1-1',	 '2023-1-1')

-- IMPLEMENT_PROJECT
INSERT INTO IMPLEMENT_PROJECT
        (DEPARTMENT_ID,	PROJECT_ID,	PROJECT_START_DATE,	PROJECT_END_DATE)
VALUES  ('PDC00001',	'PRJ00001',	'2022-12-20',		'2023-8-10'),
        ('MKT00001',	'PRJ00002',	'2023-1-25',		'2023-6-25'),
        ('ADO00001',	'PRJ00003',	'2022-2-5',			'2022-9-10')

-- DOCUMENT
INSERT INTO DOCUMENT
        (ID,		 JOB_ID,  	 PACKAGE,	WORK_ITEM,						TYPE,	PARTNER_CODE,	REVISION_NUMBER, LASTEST_REVISION,	DATE,			ISSUE_PURPOSE,	PREPARED_BY,														CHECKED_BY,												APPROVED_BY,											ACTION,			SUPPORT,			REFERRENCE,		TO_COMPANY,																		ISSUSED_ON,		ISSUSED_VIA,					TITLE)
VALUES	('DOC00001', 'JOB00001', 'Common',	'Project Site Investigation',	'D',	'P1',			'A',			 'Latest',			'2023-1-25',	'F1',			'Tran Anh Tu GDTS / Director',										'An Ji Hyun BCMP R&D Center / Manager',					'Kim Ho Yeong BCMP / Vice President',					'BCMP KOREA',	'BCMP VIETNAM',		NULL,			'Duc Trong PC. Lam Dong PC, LD DONRE, LD DOIT',									'2022-10-25',	'LDUCS/BCMP-DUCTRONG/L-0002',	N'Initial Plan of Project Site Location'),
        ('DOC00002', 'JOB00002', 'Common',	'Investment Project Proposal',	'D',	'P1',			'A',			 'Latest',			'2023-1-31',	'F1',			'An Ji Hyun BCMP R&D Center / Manager',								'Kim Ho Yeong BCMP / Vice President',					'Shin Yong Hoon BCMP / President',						'BCMP KOREA',	'BCMP VIETNAM',		NULL,			NULL,																			'2022-10-31',	'LDUCS/BCMP-DUCTRONG/L-0002',	N'Layout of Container Arrangement in Duc Trong'),
        ('DOC00003', 'JOB00003', 'Common',	'Investment Project Proposal',	'D',	'P1',			'A',			 'Latest',			'2023-1-25',	'F1',			'An Ji Hyun BCMP R&D Center / Manager',								'Kim Ho Yeong BCMP / Vice President',					'Shin Yong Hoon BCMP / President',						'BCMP KOREA',	'BCMP VIETNAM',		NULL,			NULL,																			'2022-10-31',	'LDUCS/BCMP-DUCTRONG/L-0002',	N'Initial Plan of Project Site Location in Lac Duong'),
        ('DOC00004', 'JOB00004', 'Common',	'"Project Licensing',			'D',	'P1',			'A',			 'Latest',			'2023-1-10',	'F1',			'Kim Du Hwan Chief of BCMP VIETNAM',								'Kim Ho Yeong BCMP / Vice President',					'Shin Yong Hoon BCMP / President',						'BCMP KOREA',	'BCMP VIETNAM',		NULL,			NULL,																			NULL,			NULL,							N'Initial Project Licensing Plan (Duc Trong Site)'),
        ('DOC00005', 'JOB00005', 'Common',	'DFS',							'D',	'P1',			'A',			 'Latest',			'2023-1-05',   'F1',			'Kim Ho Yeong BCMP / Vice President',								NULL,													'Shin Yong Hoon BCMP / President',						'BCMP KOREA',	'BCMP VIETNAM',		NULL,			NULL,																			NULL,			NULL,							N'득쫑 (Duc Trong) 지하냉장물류시설 DFS 추진계획'),
        ('DOC00006', 'JOB00006', 'Common',	'DFS',							'D',	'P1',			'A',			 'Latest',			'2023-1-10',	'F1',			'Shin Yong Hoon BCMP / President',									NULL,													NULL,													'BCMP KOREA',	'BCMP VIETNAM',		NULL,			NULL,																			NULL,			NULL,							N'LDCOLD 인허가 절차 및 현안사항'),
        ('DOC00007', 'JOB00007', 'Common',	'DFS',							'D',	'P1',			'A',			 'Latest',			'2023-1-13',	'F1',			'An Ji Hyun BCMP R&D Center / Manager',								'Kim Ho Yeong BCMP / Vice President',					'Shin Yong Hoon BCMP / President',						'BCMP KOREA',	'BCMP VIETNAM',		NULL,			NULL,																			NULL,			NULL,							N'베트남 람동 지하저온물류터미널 프로젝트의 DFS과업지시서'),
        ('DOC00008', 'JOB00008', 'Common',	'DFS',							'D',	'P1',			'A',			 'Latest',			'2023-1-17',	'F1',			'Shin Jeong In BCM KOREA',											'Kim Ho Yeong BCMP / Vice President',					'Shin Yong Hoon BCMP / President',						'BCMP KOREA',	'BCMP VIETNAM',		NULL,			NULL,																			NULL,			NULL,							N'Duc Trong Site Layout and Boundary Case 1'),
        ('DOC00009', 'JOB00009', 'Common',	'DFS',							'D',	'P1',			'A',			 'Latest',			'2023-1-17',	'F1',			'Shin Jeong In BCM KOREA',											'Kim Ho Yeong BCMP / Vice President',					'Shin Yong Hoon BCMP / President',						'BCMP KOREA',	'BCMP VIETNAM',		NULL,			NULL,																			NULL,			NULL,							N'Duc Trong Site Layout and Boundary Case 2'),
        ('DOC00010', 'JOB00010', 'Common',	'Project Site Selection',		'E',	'P1',			'A',			 'Latest',			'2023-1-20',	'F1',			'An Ji Hyun BCMP R&D Center / Manager',								'Kim Ho Yeong BCMP / Vice President',					'Shin Yong Hoon BCMP / President',						'BCMP KOREA',	'BCMP VIETNAM',		NULL,			'Duc Trong PC. Lam Dong PC, LD DONRE, LD DOIT',									NULL,			'LDUCS/BCMP-DUCTRONG/L-0001',	N'Initial Bench Marks of Project Site in Lac Duong District, Lam Dong Province, Vietnam'),
        ('DOC00011', 'JOB00011', 'Common',	'Project Site Selection',		'E',	'P1',			'A',			 'Latest',			'2023-1-20',	'F1',			'An Ji Hyun BCMP R&D Center / Manager',								'Kim Ho Yeong BCMP / Vice President',					'Shin Yong Hoon BCMP / President',						'BCMP KOREA',	'BCMP VIETNAM',		NULL,			'Duc Trong PC. Lam Dong PC, LD DONRE, LD DOIT',									NULL,			'LDUCS/BCMP-DUCTRONG/L-0002',	N'Initial Bench Marks of Project Site in Duc Trong District, Lam Dong Province, Vietnam'),
        ('DOC00012', 'JOB00012', 'Common',	'DFS',							'F',	'P1',			'A',			 'Latest',			'2023-1-10',	'F1',			'Kim Ho Yeong BCMP / Vice President',								NULL,													'Shin Yong Hoon BCMP / President',						'BCMP KOREA',	'BCMP VIETNAM',		NULL,			NULL,																			NULL,			NULL,							N'Request for Quotation for Duc Trong Site Investigation'),
        ('DOC00013', 'JOB00013', 'Common',	'DFS',							'F',	'P1',			'A',			 'Latest',			'2023-1-21',	'F1',			'Kim Ho Yeong BCMP / Vice President',								NULL,													'Shin Yong Hoon BCMP / President',						'BCMP KOREA',	'BCMP VIETNAM',		NULL,			NULL,																			NULL,			NULL,							N'Invitation for Bidder for Work No. 02 (Sample)'),
        ('DOC00014', 'JOB00014', 'Common',	'DFS',							'F',	'P1',			'A',			 'Latest',			'2023-1-28',	'F1',			'Kim Ho Yeong BCMP / Vice President',								NULL,													'Shin Yong Hoon BCMP / President',						'BCMP KOREA',	'BCMP VIETNAM',		NULL,			NULL,																			NULL,			NULL,							N'Request for Quotation for Work No. 03 (Sample)'),
        ('DOC00015', 'JOB00015', 'Common',	'DFS',							'S',	'P1',			'A',			 'Latest',			'2023-1-30',	'F1',			'Shin Jeong In An Ji Hyun BCMP R&D Center Vanila / BCMP Vietnam',	'Kim Ho Yeong BCMP / Vice President',					'Shin Yong Hoon BCMP / President',						'BCMP KOREA',	'BCMP VIETNAM',		NULL,			NULL,																			NULL,			NULL,							N'General Information of Project'),
        ('DOC00016', 'JOB00016', 'Common',	'DFS',							'S',	'P1',			'A',			 'Latest',			'2023-02-16',	'F1',			'Vanila / BCMP Vietnam',											NULL,													'Kim Ho Yeong BCMP / Vice President',					'BCMP KOREA',	'BCMP VIETNAM',		NULL,			NULL,																			NULL,			NULL,							N'Overal Sequence for IPA of Project'),
        ('DOC00017', 'JOB00017', 'Common',	'DFS',							'S',	'P1',			'A',			 NULL,				'2023-02-16',	'F1',			'Vanila / BCMP Vietnam',											NULL,													NULL,													'BCMP KOREA',	'BCMP VIETNAM',		NULL,			NULL,																			NULL,			NULL,							N'Overview of Lam Dong Provinces Functional Organization'),
        ('DOC00018', 'JOB00018', 'Common',	'DFS',							'S',	'P1',			'A',			 'Latest',			'2023-02-05',	'F1',			'Vanila / BCMP Vietnam',											NULL,													NULL,													'BCMP KOREA',	'BCMP VIETNAM',		NULL,			NULL,																			NULL,			NULL,							N'Overview of Lam Dong Provinces Functional Organization'),
        ('DOC00019', 'JOB00019', 'Common',	'General Procedure',			'S',	'P1',			'A',			 'Latest',			'2023-02-05',	'F1',			'Vanila / BCMP Vietnam',											NULL,													NULL,													'BCMP KOREA',	'BCMP VIETNAM',		NULL,			NULL,																			NULL,			NULL,							N'Project Document Control Guidance'),
        ('DOC00020', 'JOB00020', 'Common',	'Project Site Selection',		'L',	'E4',			'A',			 'Latest',			'2023-02-18',	'F1',			'Vanila / BCMP Vietnam',											'Kim Ho Yeong BCMP / Vice President',					'Shin Yong Hoon BCMP / President',						'BCMP KOREA',	'BCMP VIETNAM',		NULL,			'Envisolution',																	'2023-05-18',	'Email: huylq@dlu.edu.vn',		N'Negotiation for Service Contract on Measurement and Mapping of Project Land in Duc Trong Site regarding the Underground Cold Storage and Logistics Terminal Project in Lam Dong Province, Vietnam ("LDCOLD Project" or "LDUCS")'),
        ('DOC00021', 'JOB00021', 'Common',	'Project Site Selection',		'L',	'E4',			'A',			 'Latest',			'2023-02-24',	'F1',			'Vanila / BCMP Vietnam',											'Kim Ho Yeong BCMP / Vice President',					'Shin Yong Hoon BCMP / President',						'BCMP KOREA',	'BCMP VIETNAM',		NULL,			NULL,																			NULL,			NULL,							N'Letter of Award for the Consultant Service on Measurement and Mapping of Project Land in Duc Trong Site regarding the Underground Cold Storage and Logistics Terminal Project in Lam Dong Province, Vietnam ("LDCOLD Project" or "LDUCS")'),
        ('DOC00023', 'JOB00023', 'Common',	'Project Site Selection',		'H',	'E4',			'A',			 'Latest',			'2023-02-24',	'F1',			'Vanila / BCMP Vietnam',											'Kim Ho Yeong BCMP / Vice President',					'Shin Yong Hoon BCMP / President',						'BCMP KOREA',	'BCMP VIETNAM',		NULL,			NULL,																			NULL,			NULL,							N'POA to Envisolution - Mrs. Le Thi Ngoc Hai'),
        ('DOC00022', 'JOB00022', 'Common',	'Project Site Selection',		'H',	'E4',			'A',			 'Latest',			'2023-02-24',	'F1',			'Vanila / BCMP Vietnam',											'Kim Ho Yeong BCMP / Vice President',					'Shin Yong Hoon BCMP / President',						'BCMP KOREA',	'BCMP VIETNAM',		NULL,			NULL,																			NULL,			NULL,							N'POA to Envisolution - Mr. Le Quang Huy'),
        ('DOC00024', 'JOB00024', 'Common',	'Investment Project Proposal',	'E',	'EP',			'A',			 'Latest',			'2023-02-14',	'F1',			'Shin Jeong In An Ji Hyun BCMP R&D Center Vanila / BCMP Vietnam',	'Oh Se Joong PASSET Shin Yong Hoon BCMP / President',	'Oh Se Joong PASSET Shin Yong Hoon BCMP / President',	'BCMP - PASSET','BCMP VIETNAM',		NULL,			'Lam Dong PC, LD DONRE, LD DOIT, LD DAR, LD DPI, Duc  Trong PC, Lac Duong PC',	'2022-10-31',	'LDUCS/BCMP-LAMDONGPC/L-0001',	N'Conceptual Proposal Report for the Underground Cold Storage and Logistics Terminal Project in Lam Dong Province, Vietnam'),
        ('DOC00025', 'JOB00025', 'Common',	'Investment Project Proposal',	'E',	'EP',			'A',			 'Latest',			'2023-02-20',	'FA',			NULL,																NULL,													NULL,													NULL,			NULL,				NULL,			NULL,																			NULL,			NULL,							N'Application for Investment Project Execution of The Underground Cold Storage and Logistics Terminal Project in Lam Dong Province, Vietnam'),
        ('DOC00026', 'JOB00026', 'Common',	'Investment Project Proposal',	'E',	'EP',			'A',			 'Latest',			'2023-02-20',	'FA',			NULL,																NULL,													NULL,													NULL,			NULL,				NULL,			NULL,																			NULL,			NULL,							N'Investment Project Proposal for the Underground Cold Storage and Logistics Terminal Project in Lam Dong Province, Vietnam'),
        ('DOC00027', 'JOB00027', 'Common',	'Investment Project Proposal',	'E',	'EP',			'A',			 'Latest',			'2023-02-20',	'FA',			'Oh Se Joong',														NULL,													NULL,													NULL,			NULL,				NULL,			NULL,																			NULL,			NULL,							N'베트남 람동 득쫑 지하저온물류터미널 3만톤 IM'),
        ('DOC00028', 'JOB00028', 'Common',	'Investment Project Proposal',	'E',	'EP',			'A',			 'Latest',			'2023-02-20',	'FA',			'Oh Se Joong',														NULL,													NULL,													NULL,			NULL,				NULL,			NULL,																			NULL,			NULL,							N'베트남람동 저온창고PJ Teaser'),
        ('DOC00029', 'JOB00029', 'Common',	'Investment Project Proposal',	'Q',	'EP',			'A',			 'A',				'2023-02-14',	'F1',			'Vanila ',															'Kim Ho Yeong BCMP / Vice President',					'Kim Ho Yeong BCMP / Vice President',	                'BCMP KOREA',	'BCMP VIETNAM',		NULL,			NULL,																			NULL,			NULL,							N'Project Investment Proposal History Summary'),
        ('DOC00030', 'JOB00030', 'Common',	'Investment Project Proposal',	'Q',	'EP',			'B',			 'Latest',			'2023-02-07',	'F1',			'Vanila',															'Kim Ho Yeong BCMP / Vice President',					'Kim Ho Yeong BCMP / Vice President',	                'BCMP KOREA',	'BCMP VIETNAM',		NULL,			NULL,																			NULL,			NULL,							N'Project Investment Proposal History Summary'),
        ('DOC00031', 'JOB00031', 'Common',	'Manpower',						'H',	'E1',			'A',			 'Latest',			'2022-03-28',	'F1',			'Oh Se Joong',														NULL,													'Lee Chun Woo /CEO',									NULL,			NULL,				'BCMP VIETNAM',	NULL,																			NULL,			NULL,							N'Power of Attorney to Mr. Oh Se Joong'),
        ('DOC00032', 'JOB00032', 'Common',	'Investment Project Proposal',	'F',	'E1',			'A',			 'Latest',			'2022-03-24',	'F1',			'Oh Se Joong',														NULL,													NULL,													'BCMP KOREA',	'BCMP VIETNAM',		NULL,			NULL,																			NULL,			NULL,							N'Investment and Licensing Business Plan'),
        ('DOC00033', 'JOB00033', 'Common',	'Investment Project Proposal',	'S',	'E2',			'A',			 'Latest',			'2022-03-14',	'F1',			'AKDF',																NULL,													NULL,													'BCMP KOREA',	'BCMP VIETNAM',		NULL,			NULL,																			NULL,			NULL,							N'베트남 람동성 득쫑현 지하냉장창고 사업 DFS 과업지시서'),
        ('DOC00034', 'JOB00034', 'Common',	'Investment Project Proposal',	'S',	'E3',			'A',			 'Latest',			NULL,			'F1',			'THE MIND',															NULL,													NULL,													'BCMP KOREA',	'BCMP VIETNAM',		NULL,			NULL,																			NULL,			NULL,							NULL),
        ('DOC00035', 'JOB00035', 'Common',	'Project Site Investigation',	'M',	'11',			'A',			 'Latest',			'2022-03-14',	'FR',			'Ly Nhat Tan, Dinh Quoc Tuan, Tran Quoc Trung',						'Vo Tran The Vi, Tran Anh Tu, Nguyen Nam',				'Tran Anh Tu GDTS / Director',							'BCMP KOREA',	'BCMP VIETNAM',		NULL,			'Duc Trong PC. Lam Dong PC, LD DONRE',											'2023-01-05',	'LDUCS/EP-DUCTRONG/L-0001',		N'Report for Project Site Investigation in Duc Trong District, Lam Dong Province, VietnaM'),
        ('DOC00036', 'JOB00036', 'Common',	'Project Licensing',			'F',	'21',			'A',			 'Latest',			'2022-03-26',	'FR',			'Le Thi Ngoc Hai ENVISOLUTION',										NULL,													'Le Quang Huy ENVISOLUTION / Technical Director',		'BCMP KOREA',	'BCMP VIETNAM',		NULL,			NULL,																			NULL,			NULL,							N'Quotation for EIA & Land Consultant in Duc Trong'),
        ('DOC00037', 'JOB00037', 'Common',	'Project Licensing',			'F',	'21',			'A',			 'Latest',			'2022-03-26',	'FR',			'Le Thi Ngoc Hai ENVISOLUTION',										NULL,													'Le Quang Huy ENVISOLUTION / Technical Director',		'BCMP KOREA',	'BCMP VIETNAM',		NULL,			NULL,																			NULL,			NULL,							N'Quotation for EIA & Land Consultant in Lac Duong'),
        ('DOC00038', 'JOB00038', 'Common',	'Project Licensing',			'S',	'21',			'A',			 'Latest',			'2022-03-26',	'FR',			'Le Thi Ngoc Hai ENVISOLUTION',										NULL,													'Le Quang Huy ENVISOLUTION / Technical Director',		'BCMP KOREA',	'BCMP VIETNAM',		NULL,			NULL,																			NULL,			NULL,							N'Scope of work for EIA & Land Consultant in Duc Trong'),
        ('DOC00039', 'JOB00039', 'Common',	'Project Licensing',			'S',	'21',			'A',			 'Latest',			'2022-03-26',	'FR',			'Le Thi Ngoc Hai ENVISOLUTION',										NULL,													'Le Quang Huy ENVISOLUTION / Technical Director',		'BCMP KOREA',	'BCMP VIETNAM',		NULL,			NULL,																			NULL,			NULL,							N'Scope of work for EIA & Land Consultant in Lac Duong'),
        ('DOC00040', 'JOB00040', 'Common',	'Project Licensing',			'F',	'31',			'A',			 'Latest',			'2022-03-15',	'FR',			'Nguyen Thi Van TIN PHAT / Lawyer',									NULL,													'Nguyen Thi Van TIN PHAT / Lawyer',						'BCMP KOREA',	'BCMP VIETNAM',		NULL,			NULL,																			NULL,			NULL,							N'Quotation for IPA Process Consultant in Duc Trong'),
        ('DOC00041', 'JOB00041', 'Common',	'Project Licensing',			'F',	'31',			'A',			 'Latest',			'2022-03-15',	'FR',			'Nguyen Thi Van TIN PHAT / Lawyer',									NULL,													'Nguyen Thi Van TIN PHAT / Lawyer',						'BCMP KOREA',	'BCMP VIETNAM',		NULL,			NULL,																			NULL,			NULL,							N'Quotation for IPA Process Consultant in Lac Duong'),
        ('DOC00042', 'JOB00042', 'Common',	'Project Licensing',			'S',	'31',			'A',			 'Latest',			'2022-03-15',	'FR',			'Nguyen Thi Van TIN PHAT / Lawyer',									NULL,													'Nguyen Thi Van TIN PHAT / Lawyer',						'BCMP KOREA',	'BCMP VIETNAM',		NULL,			NULL,																			NULL,			NULL,							N'Scope of Work for IPA Process Consultant in Duc Trong'),
        ('DOC00043', 'JOB00043', 'Common',	'Project Licensing',			'S',	'31',			'A',			 'Latest',			'2022-03-15',	'FR',			'Nguyen Thi Van TIN PHAT / Lawyer',									NULL,													'Nguyen Thi Van TIN PHAT / Lawyer',						'BCMP KOREA',	'BCMP VIETNAM',		NULL,			NULL,																			NULL,			NULL,							N'Scope of Work for IPA Process Consultant in Lac Duong'),
        ('DOC00044', 'JOB00044', 'Common',	'Site Investigation',			'S',	'G1',			'A',			 'Latest',			'2022-03-18',	'F1',			NULL,																NULL,													'Lee Jeong Sang Senior Director',						'BCMP KOREA',	'BCMP VIETNAM',		NULL,			NULL,																			NULL,			NULL,							N'On Site Workflow and Checklist for Site Investigation Work'),
        ('DOC00045', 'JOB00045', 'Common',	'Site Investigation',			'S',	'G1',			'A',			 'Latest',			'2022-03-26',	'F1',			NULL,																NULL,													'Lee Jeong Sang Senior Director',						'BCMP KOREA',	'BCMP VIETNAM',		NULL,			NULL,																			NULL,			NULL,							N'Scope of Assistant Work by local company for Site Investigation Work in Lam Dong'),
        ('DOC00046', 'JOB00046', 'Common',	'Site Investigation',			'S',	'G1',			'A',			 'Latest',			'2022-03-26',	'F1',			NULL,																NULL,													'Lee Jeong Sang Senior Director',						'BCMP KOREA',	'BCMP VIETNAM',		NULL,			NULL,																			NULL,			NULL,							N'Electrical Resistivity Survey Method Statement')

-- DOCUMENT_NATIVE_FILE_FORMAT
INSERT INTO DOCUMENT_NATIVE_FILE_FORMAT
        (ID,		 NAME, NATIVE_FILE_FORMAT,	LINK)		
VALUES	('DOC00001', NULL, NULL,				NULL),
        ('DOC00002', NULL, NULL,				NULL),
        ('DOC00003', NULL, NULL,				NULL),
        ('DOC00004', NULL, NULL,				NULL),
        ('DOC00005', NULL, NULL,				NULL),
        ('DOC00006', NULL, NULL,				NULL),
        ('DOC00007', NULL, NULL,				NULL),
        ('DOC00008', NULL, NULL,				NULL),
        ('DOC00009', NULL, NULL,				NULL),
        ('DOC00010', NULL, NULL,				NULL),
        ('DOC00011', NULL, NULL,				NULL),
        ('DOC00012', NULL, NULL,				NULL),
        ('DOC00013', NULL, NULL,				NULL),
        ('DOC00014', NULL, NULL,				NULL),
        ('DOC00015', NULL, NULL,				NULL),
        ('DOC00016', NULL, NULL,				NULL),
        ('DOC00017', NULL, NULL,				NULL),
        ('DOC00018', NULL, NULL,				NULL),
        ('DOC00019', NULL, NULL,				NULL),
        ('DOC00020', NULL, NULL,				NULL),
        ('DOC00021', NULL, NULL,				NULL),
        ('DOC00023', NULL, NULL,				NULL),
        ('DOC00022', NULL, NULL,				NULL),
        ('DOC00024', NULL, NULL,				NULL),
        ('DOC00025', NULL, NULL,				NULL),
        ('DOC00026', NULL, NULL,				NULL),
        ('DOC00027', NULL, NULL,				NULL),
        ('DOC00028', NULL, NULL,				NULL),
        ('DOC00029', NULL, NULL,				NULL),
        ('DOC00030', NULL, NULL,				NULL),
        ('DOC00031', NULL, NULL,				NULL),
        ('DOC00032', NULL, NULL,				NULL),
        ('DOC00033', NULL, NULL,				NULL),
        ('DOC00034', NULL, NULL,				NULL),
        ('DOC00035', NULL, NULL,				NULL),
        ('DOC00036', NULL, NULL,				NULL),
        ('DOC00037', NULL, NULL,				NULL),
        ('DOC00038', NULL, NULL,				NULL),
        ('DOC00039', NULL, NULL,				NULL),
        ('DOC00040', NULL, NULL,				NULL),
        ('DOC00041', NULL, NULL,				NULL),
        ('DOC00042', NULL, NULL,				NULL),
        ('DOC00043', NULL, NULL,				NULL),
        ('DOC00044', NULL, NULL,				NULL),
        ('DOC00045', NULL, NULL,				NULL),
        ('DOC00046', NULL, NULL,				NULL)

-- JOIN_PROJECT 
INSERT INTO JOIN_PROJECT 
        (PROJECT_ID, PARTNER_ID)
VALUES	('PRJ00001', 'PNR00001'),
        ('PRJ00002', 'PNR00002'),
        ('PRJ00003', 'PNR00003')
GO

--------------------------------------------------------- <STORED PROCEDURE> ---------------------------------------------------------
--CREATE PROCEDURE SP_SELECT_ALL_PROJECT
--AS SELECT * FROM PROJECT
--GO

--EXECUTE SP_SELECT_ALL_PROJECT
--GO
-- haizzzzzzzzz