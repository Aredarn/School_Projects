-- drop database bp_lakas;
-- 1. feladat
-- Készítsen adatbázist bp_lakas néven, UTF-8 kódolással, magyar ábécé szerinti rendezéssel!

create database bp_lakas
default char set utf8
collate utf8_hungarian_ci;

use bp_lakas;


-- 2. feladat
-- Készítse el a táblát lakas néven! A tábla mezői:

-- id 			a lakás azonosítója, automatikus növelés, elsődleges kulcs, nem lehet üres
-- elado 		a lakást eladó tulajdonos neve, szöveg, max 60 karakter
-- hely 		Buda vagy Pest, szöveg, max 4 karakter
-- ker	 		a kerület száma, egész szám
-- panel 		lobikai típus, a lakás panel vagy nem
-- szoba		a szobák száma, lehet fél szoba is
-- alapt 		a lakás alapterülete négyzetméterben, egész szám
-- ar  			a lakás ára

create table lakas(
	id int primary key not null auto_increment,
    elado varchar(60),
    hely varchar(4),
	ker int,
    panel bool,
    szoba double,
    alapt int,
    ar int);

-- 3. feladat
-- Töltse fel a táblát a bp_lakas_adatok.sql állomány használatával!
-- Ellenőrizze a betöltés eredményét a tábla minden adatának lekérdezésével!
select *
from lakas;

-- 4. feladat
-- Melyik kerületekben vannak eladó lakások? Minden kerület száma csak egyszer jelenjen meg!
select distinct ker
from lakas;


-- 5. feladat
-- Listázza ki a pesti 2 szobás lakások kerületét, alapterületét és árát, ár szerint csökkenő sorrendben!
select ker, alapt, ar 
from lakas
where hely='Pest' and szoba=2
order by ar desc;


-- 6. feladat
-- Mennyi az átlagáruk a pesti egyszobás panellakásoknak?
select avg(ar) as Átlagár
from lakas
where hely='Pest' and szoba=1;


-- 7. feladat
-- Hány darab legalább 2 szobás budai lakás van?
select count(*) as Két_Szobás_Budai
from lakas
where szoba>=2 and Hely='Buda';


-- 8. feladat
-- Írja ki a lakások számát a szobák száma szerint!
select szoba, count(*)
from lakas
group by szoba;

-- 9. feladat
-- Írja ki azokat a kerületeket, ahol 5-nél több eladó panellakás van!
select ker ,count(*)
from lakas 
group by ker
having count(*) > 5;


-- 10. feladat	
-- Írassa ki a 9. kerületi lakások átlagos négyzetméterárát!

select avg(ar/alapt) as alapterület_Ára
from lakas
where ker = 9;


