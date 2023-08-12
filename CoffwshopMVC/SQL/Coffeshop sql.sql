create table ReservationTable
(
id int primary key identity(1,1),
Name  varchar(500) not null,
Email varchar(500) not null,
Date varchar(500) not null,
Person varchar(500) not null
)

-- insert records into PersonalBio 
create or alter procedure Insertreservationtable(@Name nvarchar(100),@Email nvarchar(100),@Date nvarchar(100),@Person nvarchar(100))
as
begin

  insert into ReservationTable (Name,Email,Date,Person)values (@Name,@Email,@Date,@Person)
end

exec Insertreservationtable  'Sivanesn','s@gmail.com','14 th may','2'

-------select sp
create or alter procedure Selectreservationtable
as
begin

  Select * from ReservationTable

end

exec Selectreservationtable