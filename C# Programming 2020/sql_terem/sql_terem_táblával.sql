drop database termek;

create database termek
default charset utf8 
collate utf8_hungarian_ci;

use termek;

create table terem(
szam 		int not null primary key,
tipus 		varchar(45),
emelet		int,
ferohely	int,
projektor	bool
);

insert into terem
(szam, tipus, emelet, ferohely, projektor)
values
(85, 'általános', 3, 34, 1),
(76,'nyelvi',3,22,1),
(57,'általános',2,30,1),
(12,'általános',0,40,1),
(68,'általános',3,38,0),
(35,'általános',1,30,1),
(71,'általános',3,40,1),
(11,'általános',0,30,0),
(75,'nyelvi',3,18,1),
(55,'nyelvi',2,14,0),
(82,'ének',3,42,1),
(56,'nyelvi',2,18,1),
(44,'informatika',1,22,1),
(32,'fizika',1,35,1),
(15,'informatika',0,20,0),
(45,'informatika',1,18,1),
(83,'általános',3,32,0),
(14,'általános',0,40,1),
(58,'rajz',2,34,1),
(84,'általános',3,32,0),
(31,'általános',1,20,1),
(54,'biológia',2,36,0),
(72,'informatika',3,20,1),
(43,'általános',1,26,0),
(67,'általános',3,36,1),
(86,'nyelvi',3,18,1),
(16,'informatika',0,16,1),
(59,'általános',2,30,0),
(52,'általános',2,35,1),
(46,'általános',1,36,1),
(42,'általános',1,40,0),
(47,'általános',1,38,1),
(74,'nyelvi',3,20,0),
(13,'kémia',0,35,1),
(36,'általános',1,35,1),
(73,'általános',3,20,0);








