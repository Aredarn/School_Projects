-- 1. feladat
-- Készítsen adatbázist repter néven, UTF-8 kódolással, magyar ábécé szerinti rendezéssel!
create database repter
default char set utf8
collate utf8_hungarian_ci;


use repter;
-- 2. feladat
-- Készítse el a táblát palya néven! A tábla mezői:

-- sorszam 		A kifutópálya azonosítója, automatikus növelés, elsődleges kulcs, nem lehet üres
-- nev 			A repülőtér neve, szöveg, max 45 karakter
-- hossz 		A kifutópálya hossza méterben, egész szám
-- szel 	A kifutópálya szélessége méterben, egész szám
-- anyag 		A kifutópálya borításának anyaga, szöveg, értéke fű vagy beton

create table palya(
	sorszam int primary key auto_increment not null,
	nev varchar(45), 
    hossz int,
    szel int,
    anyag varchar(5)
);


-- 3. feladat
-- Töltse fel a táblát a palyak.sql állomány használatával!
-- Ellenőrizze a betöltés eredményét a tábla minden adatának lekérdezésével!
select *
from  palya;

-- 4. feladat
-- Törölje a tévesen bekerült pápai (Pápa) füves pályát!
delete from palya
where nev='Pápa' and anyag='füves';

-- 5. feladat
-- A taszári repülőtér (Taszár) szélességét módosítsa 60-ra!
-- Lekérdezéssel ellenőrizze az eredményt!
update palya
set szel=60
where nev='Taszár';

-- 6. feladat
-- Írassa ki azokat a repülőtereket, amelynek nevében szerepel a nemzetközi szó!
-- Az azonos nevek csak egyszer jelenjenek meg!
select *
from palya
where nev like '%nemzetközi%';

-- 7. feladat
-- Írassa ki az 1500 méteres és ennél hosszabb betonos kifutópályákat!
-- A a repülőtér neve és a pálya hossza!

select nev, hossz 
from palya
where hossz > 1500 and anyag='beton';

-- 8. feladat
-- Adja meg repülőterenként a kifutópályák számát!
select nev, count(*) as pályák_száma
from palya
group by nev;

-- 9. feladat
-- Hány darab 1500 méternél hosszabb kifutópálya van?
select count(*)
from palya
where hossz>1500;

-- 10. feladat
-- Mekkora a füves kifutópályák átlagos szélessége?
select avg(szel)
from palya
where anyag='fü';