-- Az autok adatbázis létrehozása:

create database autok
default char set utf8
collate utf8_hungarian_ci;

-- Belépés az autok adatbázisba:

use autok;

-- Az auto tábla létrehozása:

create table auto (
rsz varchar(7) primary key not null, 
tipus varchar(30),
szin varchar(20),
h_urt int,
benzin bool,
forg int,
ar int
);

-- Az auto tábla feltöltése adatokkal:

insert into auto
(rsz, tipus, szin, h_urt, benzin, forg, ar)
values
('ALE-324','Opel','fehér',1600,0,1995,300000),
('BJS-331','Skoda','kék',1800,1,1996,250000),
('AWJ-621','Skoda','fekete',1900,0,1996,210000),
('DLA-452','Fiat','piros',1200,1,2000,350000),
('FGH-238','Citroen','ezüst',2000,0,2001,800000),
('KSA-561','Opel','kék',2000,0,2006,2100000),
('LBA-112','Audi','fekete',2200,0,2008,4500000),
('BML-589','Fiat','piros',1400,1,1998,450000),
('CHL-223','Citroen','kék',1600,1,1999,950000),
('CKL-523','Skoda','zöld',1200,1,1999,510000),
('BKH-553','Opel','fehér',2500,0,1997,630000),
('CAL-224','Opel','piros',1800,1,1998,690000),
('EFG-552','Audi','ezüst',2000,0,2000,1800000),
('HJI-114','Citroen','kék',1600,1,2002,2100000),
('JKS-555','Fiat','fehér',1800,1,2003,1250000),
('ESD-663','Opel','piros',2000,0,2001,1650000),
('FGH-213','Volvo','kék',2500,0,2001,2500000),
('EDS-323','Suzuki','piros',1200,1,2000,550000);

-- 1. feladat
select rsz,tipus, h_urt
from auto
where benzin =1 and h_urt <1500
order by tipus;

-- 2. feladat
select tipus, szin, h_urt
from auto
where ar < 1000000 and (szin='kék' or szin='piros');

-- 3. feladat
select tipus, rsz
from auto
where rsz like 'E%' and benzin = 0 and forg >2000;


-- 4. feladat
select tipus, szin
from auto
where ar >1000000 and ar <2000000
order by szin desc;


-- 5. feladat
select tipus, forg
from auto
order by ar desc
limit 1;


-- 6. feladat
select avg(h_urt) h_u_atlag
from auto
where tipus = 'Opel';

-- 7. feladat
select szin, count(*)
from auto
group by szin;

-- 8. feladat
select szin, count(*)
from auto 
group by szin
having count(*) > 2;

-- 9. feladat
select count(*) benzines_Skoda
from auto
where benzin = 1 and tipus ='Skoda';


-- 10. feladat
select avg(ar) átlagár
from auto
where h_urt = 2000;

-- 11. feladat
select tipus, avg(ar), max(h_urt)
from auto
group by tipus;

-- 12. feladat
select tipus, avg(h_urt)
from auto
where benzin=0 and (tipus='Audi' or tipus = 'Opel')
Group by tipus;

-- 13. feladat
select rsz, tipus, ar
from auto
where ar < (select ar from auto where rsz= 'DLA-452')







