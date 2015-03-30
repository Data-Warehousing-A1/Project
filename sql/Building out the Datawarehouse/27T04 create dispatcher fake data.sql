drop table stage.dispatcher

create table stage.dispatcher
(
	dispatcher_wk int identity(1,1),
	name varchar(25),
	address varchar(40),
	phone bigint,
	work_location varchar(20),
	skill_level int,
	county varchar(15)
)

insert into stage.dispatcher (name, address, phone, work_location, skill_level, county) values ('Barbara Smith', '6303 Shetland Rd', 9047434399, 'hospital', 4, 'duval');
insert into stage.dispatcher (name, address, phone, work_location, skill_level, county)  values ('John Smith', '132 Main St', 3861234567, 'hospital', 3, 'apt');
insert into stage.dispatcher (name, address, phone, work_location, skill_level, county)  values ('Susan Gold', '245 Liberty St', 9045621345, 'medical center', 2, 'asi');
insert into stage.dispatcher (name, address, phone, work_location, skill_level, county)  values ('Kevin James', '398 1st St', 9047898523, 'hospital', 1, 'baker');
insert into stage.dispatcher (name, address, phone, work_location, skill_level, county)  values ('Jessica Barbie', '1345 Main', 9047632145, 'hospital', 9, 'century');
insert into stage.dispatcher (name, address, phone, work_location, skill_level, county)  values ('Susan Ortez', '333 2nd Plaza', 9045687455, 'trauma center', 2, 'clay');
insert into stage.dispatcher (name, address, phone, work_location, skill_level, county)  values ('Jessica Alba', '223 Elm St', 5687894123, 'hospital', 4, 'camden');
insert into stage.dispatcher (name, address, phone, work_location, skill_level, county)  values ('Debbie Gagnon', '123 Birchwood Lane', 7534561248, 'hospital', 2, 'helicopters');
insert into stage.dispatcher (name, address, phone, work_location, skill_level, county)  values ('Sarah Johnson', '6303 Longbranch Rd', 4567897455, 'hospital', 3, 'nassau');
