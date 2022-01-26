-- create database tasklist;
-- use tasklist;

create table teammembers
(
`id` int not null auto_increment primary key,
`name` nvarchar(50)
);
create table tasks
(
`id` int not null auto_increment primary key,
tmid int,
shortdescription nvarchar(125),
due_date nvarchar(20),
completed bit,
foreign key (tmid) references teammembers(id)
);

create table tmtodos
(
`id` int not null auto_increment primary key,
taskid int not null,
tmid int not null,
assigneddate nvarchar(20),
foreign key (taskid) references tasks(id),
foreign key (tmid) references teammembers(id)
);


