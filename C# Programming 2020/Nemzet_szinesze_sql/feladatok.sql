drop database nemzet;
-- 1. feladat: Hozza létre az adatbázist nemzet néven (utf8 és magyar abc szerinti rendezés)
create database nemzet
default char set utf8
collate utf8_hungarian_ci;

use nemzet;

-- 2. feladat:
-- Készítsen lekérdezést, amely kilistázza azokat a színészeket, akik elsőként, azaz 
-- 2000. augusztus 22-én kapták meg a Nemzet Színésze címet! Csak a neveket jelenítse meg ábécérendben!
select nev
from szinesz
where valasztas ='2000-08-22'
order by nev;
-- 3. feladat
-- Írja ki a Jászai Mari-díjas színészek neveit:
select nev
from szinesz inner join kapott on szinesz.id = kapott.szineszid
			 inner join elismeres on elismeres.id = kapott.elismeresid
where megnevezes = 'Jászai Mari-díj';


-- 4. feladat: 
-- Az élő színészek közül hányan kapták meg a különböző díjakat?
select megnevezes, count(*)
from szinesz inner join kapott on szinesz.id = kapott.szineszid
			 inner join elismeres on elismeres.id = kapott.elismeresid
where elhunyt is null
group by megnevezes;



-- 5. feladat:
-- Készítsen lekérdezést, amely megadja, hogy mely kitüntetéseket nyert el egy-egy színész
-- többször is! A színész nevét és az elismerés megnevezését jelenítse meg!
select nev, megnevezes
from szinesz inner join kapott on szinesz.id = kapott.szineszid
			 inner join elismeres on elismeres.id = kapott.elismeresid
group by nev, megnevezes
having count(*) > 1
order by nev;
             
-- 6. feladat:
-- Hányan kaptak Kiváló művész díjat?





