create database sampledb;
go

use sampledb;
go

create table users(
	id int identity(1,1) primary key, 
	name nvarchar(32), 
	sex tinyint, 
	birthday datetime
);
go

insert into users values ('taro', '1', '2020-03-01T00:00:00.000');
insert into users values ('hanako', '2', '2020-03-02');
insert into users values (N'R“c‘¾˜Y', '1', '2020-03-03T01:23:45.678');
go