-- drop database egitest;
-- Az egitest adatbázis létrehozása:

create database egitest
default char set utf8
collate utf8_hungarian_ci;

-- Belépés az egitest adatbázisba:

use egitest;

-- Az egit tábla létrehozása, ami az égitestek adatait tárolja:

create table egit (
id int primary key not null,
kering varchar(30),
nev varchar(30),
tav int,
irany bool,
atmero int,
felfedezo varchar(45),
felf_eve int);

insert into egit
(id, kering, nev, tav, irany, atmero, felfedezo, felf_eve)
values
(1,'Nap','Jupiter',778330,1,142984,null,null),
(2,'Nap','Szaturnusz',1429400,1,120536,null,null),
(3,'Nap','Uránusz',2870990,1,51118,'Herschel',1781),
(4,'Nap','Neptunusz',4504000,1,49528,'Galle',1846),
(5,'Nap','Föld',149600,1,12756,null,null),
(6,'Nap','Vénusz',108200,1,12104,null,null),
(7,'Nap','Mars',227940,1,6794,null,null),
(8,'Jupiter','Ganymede',1070,1,5262,'Galilei',1610),
(9,'Szaturnusz','Titan',1222,1,5150,'Huygens',1655),
(10,'Nap','Merkúr',57910,1,4878,null,null),
(11,'Jupiter','Callisto',1883,1,4800,'Galilei',1610),
(12,'Jupiter','Io',422,1,3630,'Galilei',1610),
(13,'Jupiter','Europa',671,1,3138,'Galilei',1610),
(14,'Neptunusz','Triton',355,0,2700,'Lassell',1846),
(15,'Nap','Plútó',5913520,1,2320,'Tombaugh',1930),
(16,'Uránusz','Titania',436,1,1578,'Herschel',1787),
(17,'Szaturnusz','Rhea',527,1,1530,'Cassini',1672),
(18,'Uránusz','Oberon',583,1,1522,'Herschel',1787),
(19,'Szaturnusz','Iapetus',3561,1,1460,'Cassini',1671),
(20,'Plútó','Charon',20,1,1270,'Christy',1978),
(21,'Uránusz','Umbriel',266,1,1170,'Lassell',1851),
(22,'Uránusz','Ariel',191,1,1158,'Lassell',1851),
(23,'Szaturnusz','Dione',377,1,1120,'Cassini',1684),
(24,'Szaturnusz','Tethys',295,1,1060,'Cassini',1684),
(25,'Szaturnusz','Enceladus',238,1,520,'Herschel',1789),
(26,'Uránusz','Miranda',130,1,472,'Kuiper',1948),
(27,'Neptunusz','Proteus',118,1,418,'Voyager-2',1989);

-- 1. feladat:
select nev
from egit
where kering='Nap'
order by tav;

-- 2. feladat:
select nev
from egit
where irany=1 and kering='Neptunusz';

-- 3. feladat:
select nev, tav, kering
from egit
order by tav
limit 1;

-- 4. feladat:
select nev, tav
from egit
where kering='Jupiter' and atmero<=4000;

-- 5. feladat:
select felfedezo, count(*)
from egit
where felfedezo is not null
group by felfedezo;

-- 6. feladat:
select count(*)
from egit
where felf_eve between 1600 and 1699;

-- 7. feladat
select avg(atmero) 
from egit
where kering = 'Nap';

-- 8. feladat
select count(*) Jupiter_körül_kering
from egit
where kering = 'Jupiter'; 


-- 9. feladat
select felf_eve, count(*)
from egit
where felf_eve is not null 
group by felf_eve
having count(*) >1;


-- 10. feladat
select count(*)
from egit
where tav<1000 and kering!='Nap';



