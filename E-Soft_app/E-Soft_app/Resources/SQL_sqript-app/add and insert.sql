use DataBase_for_App;
/*
alter table user_ drop constraint FK_id_role;
drop table if exists role_;
drop table if exists user_;
*/
create table role_
(
	id int primary key not null,
	name varchar(50) not null
)

create table user_
(
	id int primary key not null,
	id_role int not null constraint FK_id_role foreign key(id_role) references role_(id),
	login nvarchar(50) not null,
	password nvarchar(50) not null,
	name nvarchar(50) not null
);

insert into role_ (id, name)
values
(1, 'admin'),
(2, 'user')

insert into user_ (id, id_role, login, password, name)
values
(1, 1, 'terbik_admin', 1234, 'oleg'),
(2, 2, 'terbik_user', 1234, 'bob')