use DB02TMS155_1718

create table Table_Customer
(
CustomerSSNID bigint,
CustomerId bigint identity(10000000,1)  primary key,
CustomerName varchar(80),
Age int,
AddressLine1 varchar(80),
AddressLine2 varchar(80),
State varchar(80),
City varchar(80),
LastUpdate Date,
Message varchar(80),
Status Varchar(80)
);
insert into Table_Customer(CustomerSSNID ,CustomerName ,Age ,AddressLine1 ,AddressLine2,State,City,
LastUpdate ,Message ,Status ) values(123,'sarfaraz',21,'gkp','India','UP','j',getdate(),'dd','Active')


drop table Table_Customer
drop table Table_Accont_Executive

 create table Table_Accont_Executive(AccountID bigint identity(1000000,1)primary key,CustomerId bigint foreign key references Table_Customer(CustomerId),Accounttype varchar(80),Depositamount bigint,Accountstatus varchar(80),Message varchar(80),Last_Updated datetime)
 select * from Table_Accont_Executive
 select * from Table_Customer


 go
 alter proc
 create_account_exec
 @AccountID bigint out,@CustomerId bigint ,@Accounttype varchar(80),@Depositamount bigint
 as
 begin
 insert into Table_Accont_Executive(CustomerId  ,Accounttype ,Depositamount) values(@CustomerId  ,@Accounttype ,@Depositamount )
 set @AccountID=@@IDENTITY
 end;


 go
 alter proc
 create_Customer
 @CustomerId bigint out,@CustomerSSNID bigint,@CustomerName varchar(80),@Age int,@AddressLine1 varchar(80),@AddressLine2 varchar(80),@State varchar(80),@City varchar(80)
 as
 begin
 insert into Table_Customer(CustomerSSNID ,CustomerName ,Age ,AddressLine1 ,AddressLine2 ,State ,City ) values(@CustomerSSNID ,@CustomerName ,@Age ,@AddressLine1 ,@AddressLine2 ,@State ,@City  )
 set @CustomerId=@@IDENTITY
 end;
