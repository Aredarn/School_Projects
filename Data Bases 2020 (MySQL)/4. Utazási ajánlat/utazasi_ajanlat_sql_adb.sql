-- Az utazasi_ajanlat adatbázis létrehozása:

create database utazasi_ajanlat
default char set utf8
collate utf8_hungarian_ci;

-- Belépés az utazasi_ajanlat adatbázisba:

use utazasi_ajanlat;

-- Az utak tábla létrehozása, ami az ajánlatok adatait tárolja:

create table utak (
id int primary key not null, 
taje varchar(30), 
ej int, 
csalados bool, 
honap varchar(10), 
maxfo int, 
foglalt int, 
ar int);

insert into utak
(id, taje, ej, csalados, honap, maxfo, foglalt, ar)
values
(1,'Mátra',1,False,'Január',40,20,86700),
(2,'Bükk',7,False,'Február',40,18,41100),
(3,'Tisza-tó',6,False,'Március',45,0,30800),
(4,'Mecsek',5,False,'Április',40,20,47400),
(5,'Bakony',6,False,'Május',45,20,83700),
(6,'Balaton',7,True,'Június',40,18,99900),
(7,'Zemplén',4,False,'Július',35,0,47300),
(8,'Balaton',4,True,'Augusztus',35,0,8500),
(9,'Bakony',4,False,'Szeptember',45,23,46100),
(10,'Pilis',2,False,'Október',35,20,37900),
(11,'Mecsek',6,True,'November',45,20,47600),
(12,'Bükk',7,False,'December',50,23,800),
(13,'Bükk',4,False,'Január',35,0,25600),
(14,'Zselic',6,False,'Február',35,20,10600),
(15,'Zselic',7,False,'Március',40,18,75800),
(16,'Tisza-tó',7,False,'Április',50,0,26400),
(17,'Tisza-tó',4,True,'Május',35,0,30600),
(18,'Bükk',2,True,'Június',25,25,40800),
(19,'Mecsek',7,True,'Július',50,23,8400),
(20,'Mátra',4,False,'Augusztus',35,0,79400),
(21,'Zselic',2,False,'Szeptember',25,25,17500),
(22,'Zemplén',2,True,'Október',45,20,57200),
(23,'Hortobágy',4,False,'November',25,20,88100),
(24,'Hortobágy',3,True,'December',30,30,3600),
(25,'Őrség',4,True,'Január',35,0,62800),
(26,'Zemplén',5,False,'Február',50,32,37200),
(27,'Mecsek',1,False,'Március',50,32,87300),
(28,'Mátra',3,True,'Április',50,23,46900),
(29,'Zemplén',6,True,'Május',25,25,35600),
(30,'Mátra',5,False,'Június',30,12,80800),
(31,'Balaton',2,True,'Július',45,20,49500),
(32,'Hortobágy',2,True,'Augusztus',35,20,75000),
(33,'Pilis',4,True,'Szeptember',45,23,91300),
(34,'Bakony',1,False,'Október',30,12,68500),
(35,'Mátra',4,False,'November',45,23,54400),
(36,'Bükk',4,False,'December',25,20,90500),
(37,'Őrség',1,True,'Január',30,12,35000),
(38,'Pilis',1,False,'Február',30,12,55900),
(39,'Zselic',4,True,'Március',45,23,53000),
(40,'Bükk',1,True,'Április',50,32,30000),
(41,'Hortobágy',5,False,'Május',40,20,72400),
(42,'Mátra',2,False,'Június',45,20,47700),
(43,'Balaton',5,False,'Július',30,12,20100),
(44,'Tisza-tó',4,True,'Augusztus',25,20,96800),
(45,'Mecsek',3,False,'Szeptember',30,30,25000),
(46,'Bakony',3,True,'Október',40,18,34300),
(47,'Hortobágy',1,False,'November',30,12,87200),
(48,'Bakony',5,False,'December',40,20,82600),
(49,'Bükk',5,True,'Január',30,12,27800),
(50,'Őrség',7,False,'Február',30,30,29900),
(51,'Hortobágy',4,True,'Március',35,0,76700),
(52,'Balaton',4,False,'Április',25,20,40600),
(53,'Balaton',7,True,'Május',30,30,14500),
(54,'Őrség',4,False,'Június',25,20,80500),
(55,'Pilis',5,True,'Július',50,32,76100),
(56,'Zemplén',3,True,'Augusztus',50,23,4800),
(57,'Pilis',3,False,'Szeptember',40,18,80900),
(58,'Bakony',7,True,'Október',50,23,61200),
(59,'Őrség',6,False,'November',25,25,80100),
(60,'Zemplén',4,False,'December',45,23,52800),
(61,'Bakony',2,False,'Január',35,20,75800),
(62,'Őrség',4,True,'Február',45,23,70600),
(63,'Bükk',3,False,'Március',30,30,61800),
(64,'Balaton',3,False,'Április',50,23,33500),
(65,'Mátra',1,False,'Május',50,32,43700),
(66,'Bakony',4,False,'Június',35,0,54900),
(67,'Bakony',4,True,'Július',25,20,24600),
(68,'Zemplén',1,False,'Augusztus',40,20,45700),
(69,'Hortobágy',3,True,'Szeptember',40,18,38600),
(70,'Pilis',7,True,'Október',30,30,43300),
(71,'Őrség',5,False,'November',50,32,82800),
(72,'Zselic',5,False,'December',30,12,85200),
(73,'Hortobágy',6,True,'Január',45,20,15600),
(74,'Tisza-tó',5,True,'Február',40,0,37400),
(75,'Zselic',4,True,'Március',25,20,81300),
(76,'Mecsek',4,False,'Április',45,23,31900),
(77,'Bükk',4,False,'Május',45,23,25400),
(78,'Pilis',6,False,'Június',25,25,42700),
(79,'Őrség',3,False,'Július',40,18,49400),
(80,'Zselic',1,True,'Augusztus',50,32,98900),
(81,'Őrség',2,True,'Szeptember',35,20,36800),
(82,'Mecsek',4,False,'Október',35,0,66100),
(83,'Balaton',1,False,'November',40,20,26300),
(84,'Őrség',1,True,'December',40,20,98300),
(85,'Mátra',6,False,'Január',35,20,5900),
(86,'Bakony',3,True,'Február',30,30,52500),
(87,'Zselic',2,False,'Március',45,20,800),
(88,'Hortobágy',2,False,'Április',25,25,6600),
(89,'Mecsek',2,True,'Május',25,25,40100),
(90,'Hortobágy',7,False,'Június',50,23,97400),
(91,'Mátra',7,True,'Július',40,18,800),
(92,'Bükk',6,False,'Augusztus',45,20,83300),
(93,'Bükk',5,True,'Szeptember',40,20,9300),
(94,'Balaton',5,False,'Október',50,32,66900),
(95,'Bükk',6,False,'November',35,20,74100),
(96,'Zemplén',7,False,'December',30,30,50100),
(97,'Balaton',6,True,'Január',35,20,74500),
(98,'Zselic',3,False,'Február',50,23,27200),
(99,'Mátra',4,True,'Március',25,20,1400),
(100,'Balaton',6,False,'Április',25,25,92500);
