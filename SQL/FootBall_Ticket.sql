create database UEFA_Ticket
use UEFA_Ticket

create table NameRoundd
(
   NameRoundID int not null,
   NameRound nvarchar(50),
);
create table SoccerMatch
(
    SoccerID CHAR(10) not null,
	SoccerName varchar(50),
	Showtime varchar(10),
	Day datetime,
	NameRoundID int not null,
	NameReferee nvarchar(90),
	NameStadium nvarchar(90),
	Price FLOAT,
    TotalTicket int
);

Create table ResultSoccer
(
    STT int not null,
    SoccerID CHAR(10) not null,
	Score Varchar(10),
);

create table ResultSoccerTotal
(
   TotalID int not null,
   SoccerID CHAR(10) unique not null,
   NameRound nvarchar(30),
   TotalResult varchar(10),
  
);

Create table Winner
(
    WinnerID int not null,
	SoccerName varchar(50),
	NameCoach varchar(30),
	Total varchar(30),
	TotalID int unique not null
	
);
Create table Login
(
    TenTaiKhoan Nvarchar(50) not null,
	MatKhau Nvarchar(50),
	Email Nvarchar(50)
)

Create table Customer
(
    CustomerID int not null,
    Names Nvarchar(40),
	TelephoneCustomer varchar(30),
	Address Nvarchar(30),
	BirthDate nvarchar(40),
	Gender Nvarchar(20),
	PaymentID int not null,
	TenTaiKhoan Nvarchar(50) unique not null,
);
Create table Payment
(
    PaymentID int not null,
	PayMethod nvarchar(30)
);
Create table Tickets
(
   TicketID int IDENTITY not null,
   CustomerID int not null,
   NameRoundID int not null,
   SoccerID CHAR(10) not null,
   Quantity Int
);

--Tạo khoá chính
alter table Login add constraint PK_TenTaiKhoan primary key(TenTaiKhoan)
alter table SoccerMatch add constraint PK_SoccerID primary key(SoccerID)
alter table ResultSoccer add constraint PK_STT primary key(STT)
alter table Customer add constraint PK_CustomerID primary key(CustomerID)
alter table Tickets add constraint PK_TicketID primary key(TicketID)
alter table Payment add constraint PK_PaymentID primary key (PaymentID)
alter table Winner add constraint PK_WinnerID primary key(WinnerID)
alter table ResultSoccerTotal add constraint PK_TotalID primary key(TotalID)
alter table NameRoundd add constraint PK_NameRoundID primary key(NameRoundID)
--Tạo khoá phụ
alter table SoccerMatch add constraint FK_NameRoundID foreign key(NameRoundID) references  NameRoundd(NameRoundID)				
alter table ResultSoccer add 
                         constraint FK_SoccerID foreign key(SoccerID) references  SoccerMatch(SoccerID)
alter table Tickets add 
                        constraint FK_SoccerID1 foreign key(SoccerID) references  SoccerMatch(SoccerID),
						constraint FK_CustomerID foreign key(CustomerID) references  Customer(CustomerID)
alter table Customer add 
                          constraint FK_PaymentID foreign key(PaymentID) references  Payment(PaymentID),
						  constraint FK_TenTaiKhoan foreign key(TenTaiKhoan) references  Login(TenTaiKhoan)
alter table ResultSoccerTotal add 
                               constraint FK_SoccerID2 foreign key(SoccerID) references  SoccerMatch(SoccerID)
alter table Winner add constraint FK_TotalID foreign key(TotalID) references  ResultSoccerTotal(TotalID)

Insert NameRoundd values
(1,N'Vòng 1/8 lượt đi'),	
(2,N'Vòng 1/8 lượt về'),
(3,N'Tứ kết lượt đi'),
(4,N'Tứ kết lượt về'),
(5,N'Bán kết lượt đi'),	
(6,N'Bán kết lượt về');						  							  
Insert SoccerMatch values
('OA2','Sporting Lisbon VS Man City','03:00','02/16/2022',1,N'Srđan Jovanovic',N'Estádio José Alvalade',15000,50000),
('OA1','PSG VS Real Madrid','03:00','02/16/2022',1,N'Whoscored',N'Paris Saint-Germain',20000,51000),
('OA3','Inter Milan VS Liverpool','03:00','02/17/2022',1,N'Szymon Marciniak',N'Stadio Giuseppe Meazza',20000,53000),
('OA4','Salzburg VS Bayern München','03:00','02/17/2022',1,N'Michael Oliver',N'Red Bull Arena',17000,52000),
('OA5','Villarreal VS Juventus','03:00','02/23/2022',1,N'Jesús Gil Manzano',N'Stamford Bridge',18000,50000),
('OA6','Chelsea VS Lille','03:00','02/23/2022',1,N'Michael Oliver',N'Red Bull Arena',17000,49000),
('OA7','Atlético Madrid VS Manchester United','03:00','02/24/2022',1,N'Ovidiu Alin Hațegan',N'Estadio Wanda Metropolitano',19000,51000),
('OA8','Benfica VS Ajax','03:00','02/24/2022',1,N'Slavko Vinčić',N'Estádio do Sport Lisboa e Benfica (da Luz)',18000,49000),
('OA9','Liverpool VS Inter Milan','03:00','03/09/2022',2,N'Antonio Miguel Mateu Lahoz',N'Anfield',51000,61000),
('OA10','Bayern München VS Salzburg','03:00','03/09/2022',2,N'Antonio Miguel Mateu Lahoz',N'Anfield',51000,61000),
('OA11','Real Madrid VS PSG','03:00','03/10/2022',2,N'Danny Desmond Makkelie',N'Estadio Santiago Bernabéu',50000,61000),
('OA12','Manchester City VS Sporting CP','03:00','03/10/2022',2,N'Danny Desmond',N'Eathath',51000,59000),
('OA13','Manchester United VS Atlético Madrid','03:00','03/16/2022',2,N'Slavko Vinčić',N'Old Trafford',49000,61000),
('OA14','Ajax VS Benfica','03:00','03/16/2022',2,N'Danny Desmond',N'Santiago Bernabéu',43000,58000),
('OA15','Juventus VS Villarreal','03:00','03/17/2022',2,N'Szymon Marciniak',N'Allianz Stadium',53000,55000),
('OA16','Lille VS Chelsea','03:00','03/17/2022',2,N'Davide Massa',N'Stade Pierre-Mauroy',53000,55000),
('OA17','Benfica VS Liverpool','02:00','04/06/2022',3,N'Jesús Gil Manzano',N'Estádio do Sport Lisboa e Benfica (da Luz)',53000,55000),
('OA18','Manchester City VS Atlético Madrid','02:00','04/06/2022',3,N'Anthony Taylor',N'Estadio de la Cerámica',51000,52000),
('OA19','Villarreal VS Bayern München','02:00','04/07/2022',3,N'Anthony Taylor',N'Estadio de la Cerámica',51000,52000),
('OA20','Chelsea VS Real Madrid','02:00','04/07/2022',3,N'Anthony Taylor',N'Estadio Santiago Bernabéu',50000,43000),
('OA21','Bayern München VS Villarreal','02:00','04/13/2022',4,N'Szymon Marciniak',N'Santiago Bernabéu',52000,45000),
('OA22','Real Madrid VS Chelsea','02:00','04/13/2022',4,N'Szymon Marciniak',N'Santiago Bernabéu',51000,43000),
('OA23','Liverpool VS Benfica','02:00','04/14/2022',4,N'Serdar Gözübüyük',N'Anfield',53000,41000),
('OA24','Atlético Madrid VS Manchester City','02:00','04/14/2022',4,N'Serdar ',N'Eatihat',53000,53000);

 insert ResultSoccer values
 (1,'OA1','1-0'),
 (2,'OA2','0-5'),
 (3,'OA3','0-2'),
 (4,'OA4','1-1'),
 (5,'OA5','1-1'),
 (6,'OA6','2-0'),
 (7,'OA7','1-1'),
 (8,'OA8','2-2'),
 (9,'OA9','0-1'),
 (10,'OA10','7-1'),
 (11,'OA11','3-1'),
 (12,'OA12','0-0'),
 (13,'OA13','0-1'),
 (14,'OA14','0-1'),
 (15,'OA15','0-3'),
 (16,'OA16','1-2');

insert ResultSoccerTotal values
(1,'OA1',N'Kết quả chung cuộc','2-3'),
(2,'OA12',N'Kết quả chung cuộc','5-0'),
(3,'OA23',N'Kết quả chung cuộc','2-1'),
(4,'OA15',N'Kết quả chung cuộc','1-4'),
(5,'OA10',N'Kết quả chung cuộc','8-2'),
(6,'OA16',N'Kết quả chung cuộc','1-4'),
(7,'OA13',N'Kết quả chung cuộc','1-2'),
(8,'OA14',N'Kết quả chung cuộc','2-3');

insert Winner values
(1,'Real Madrid','Carlo Ancelotti','Winner',1),
(2,'Manchester City','Josep Guardiola','Winner',2),
(3,'Liverpool','Jürgen Klopp','Winner',3),
(4,'Villarreal','Unai Emery','Winner',4),
(5,'Bayern München','Julian Nagelsmann','Winner',5),
(6,'Chelsea','Thomas Tuchel','Winner',6),
(7,'Atlético Madrid','Diego Simeone','Winner',7),
(8,'Benfica','Nélson Veríssimo','Winner',8);
insert Payment values
(1,N'Chuyển khoản'),
(2,N'Thanh toán trên hệ thống');
insert Login values
(N'HoangLong',N'HoangLong123',N'Long@gmail.com'),
(N'ThuyTien',N'ThuyTien123',N'ThuyTien@gmail.com'),
(N'ThuAn',N'ThuAn123',N'ThuAn@gmail.com'),
(N'VanNam',N'VanNam123',N'VanNam@gmail.com'),
(N'DinhNghe',N'DinhNghe123',N'DinhNghe@gmail.com'),
(N'TranHuyen',N'TranHuyen123',N'TranHuyen@gmail.com'),
(N'KimChi',N'KimChi123',N'KimChi@gmail.com'),
(N'VanKhai',N'VanKhai123',N'VanKhai@gmail.com');
insert Customer values
(01,N'Nguyên Hoàng Long','0999232',N'Nam Định','1996/12/12',N'Nam',1,N'HoangLong'),
(02,N'Lê Thủy Tiên','09934232',N'Phú Thọ','2002/10/22',N'Nữ',2,N'ThuyTien'),
(03,N'Hà Thu An','00389798',N'Hồ Chí Minh','2003/9/24',N'Nữ',1,N'ThuAn'),
(04,N'Lương Văn Nam','09990732',N'Hà Nội','2000/7/13',N'Nam',2,N'VanNam'),
(05,N'Lương Đình Nghệ','09990732',N'Hà Nội','2000/7/15',N'Nam',2,N'DinhNghe'),
(06,N'Trần Thị Huyền','09340732',N'Hà Nội','2000/6/13',N'Nữ',1,N'TranHuyen'),
(07,N'Vũ Thị Kim Chi','09210732',N'Huế','2001/7/13',N'Nữ',2,N'KimChi'),
(08,N'Ma Văn Khải','05840732',N'Thanh Hoá','2002/7/15',N'Nữ',1,N'VanKhai');
SET IDENTITY_INSERT Tickets ON;
insert Tickets(TicketID,CustomerID,NameRoundID,SoccerID,Quantity) values
(1,3,3,'OA17',2),
(2,2,3,'OA21',1),
(3,4,3,'OA18',3),
(4,1,3,'OA22',2),
(5,5,4,'OA19',2),
(6,6,4,'OA20',2),
(7,7,4,'OA23',2),
(8,8,4,'OA24',2);
 select a.CustomerID,Names,SoccerName,Day,Showtime,d.NameRound,NameStadium,Quantity,Price*Quantity[Total] from Tickets a join SoccerMatch b on a.SoccerID=b.SoccerID join Customer c on a.CustomerID=c.CustomerID join NameRoundd d on d.NameRoundID=b.NameRoundID order by CustomerID asc
select * from SoccerMatch where NameRoundID=3 or NameRoundID=4

---số lượng vé còn tồn dư

select b.SoccerName, TotalTicket-(select SUM(Quantity)from Tickets a join SoccerMatch b on a.SoccerID=b.SoccerID where a.SoccerID='OA17' group by SoccerName, Price )[Số lượng vé tồn kho] from Tickets a full join SoccerMatch b on a.SoccerID=b.SoccerID where a.SoccerID='OA17' group by SoccerName,TotalTicket
--Tổng thiệt hại vé tồn kho của mỗi trận đấu


-- Tổng doanh thu tổn thất
select (TotalTicket - Quantity)*Price from Tickets a join SoccerMatch b on a.SoccerID=b.SoccerID 
--Số vé đã bán ra

select SoccerName,SUM(Quantity),TotalTicket from Tickets a join SoccerMatch b on a.SoccerID=b.SoccerID where a.SoccerID='OA17' group by SoccerName,TotalTicket
select SUM(Quantity)*Price from Tickets a join SoccerMatch b on a.SoccerID=b.SoccerID group by SoccerName, Price
Select Sum(D)[Tổng doanh thu] from (select (SUM(Quantity)*Price)[D] from Tickets a join SoccerMatch b on a.SoccerID=b.SoccerID group by SoccerName, Price) as t
Select Sum(D)[Tổng doanh thu tổn thất] from (select ((TotalTicket - Quantity)*Price)[D] from Tickets a join SoccerMatch b on a.SoccerID=b.SoccerID ) as t

Select Names,Sum(Total)[Tổng số tiền] from (Select b.CustomerID,Names,c.SoccerName,Quantity,SUM(Price*Quantity)[Total] from Customer a join Tickets b on a.CustomerID=b.CustomerID join SoccerMatch c on c.SoccerID=b.SoccerID where a.CustomerID=2 group by Names,b.CustomerID,SoccerName,Quantity ) as t group by t.Names
Select CustomerID,Names, TelephoneCustomer,Address,Email,Gender,BirthDate,PaymentID,b.TenTaiKhoan from Customer a full join Login b on a.TenTaiKhoan=b.TenTaiKhoan ;
select COUNT(*) from Customer