create database SLNSSCEB;
use SLNSSCEB;

create table member(ID int identity (1,1), PF_Number varchar(10) primary key, 
			FirstName varchar(8), LastName varchar(10), NIC varchar(13), AddressLine1 varchar(20), 
			AddressLine2 varchar(20), city varchar(20), zipCode int, workStation varchar(20), Grade varchar(8),
			male bit, female bit, mobileNumber varchar(13));

create table adminPanel(username varchar(10) primary key, password varchar(8),
				PF_Number varchar(10) references member(PF_Number));

insert into adminPanel values ('admin', 'SLNSSCEB','PF 00000');
insert into member (PF_Number, FirstName, LastName, NIC, AddressLine1, AddressLine2, city, zipCode, workStation, Grade, mobileNumber)
			values ('PF 00000','Admin','User','0000000000','Matara','SL','M',0,'WEB Development','Admin','0110000000');

select * from member;
select * from adminPanel;