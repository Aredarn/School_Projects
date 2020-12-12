-- drop database kutyak;
-- 1. Hozzon létre adatbázist kutyak néven utf-8 kódolással, magyar ábécé serinti rendezéssel!
CREATE DATABASE kutyak
default charset utf8
collate utf8_hungarian_ci;

use kutyak;
-- 2. Készítsen adattáblát kutya néven! A tábla mezői:
-- azon 		A kutya azonosítója, egész szám, elsődleges kulcs, nem lehet üres
-- nev			A kutya neve, szöveg, max 32 karakter
-- fajta 		A kutya fajtája, szöveg, max 45 karakter
-- mag		 	A kutya magassága centiméterben, egész szám
-- suly			A kutya súlya kilogramban, valós szám
-- kan			Kan kutya esetén igaz, egyébként hamis, logikai típus
-- szul 		A kutya születési időpontja, ha ismert, dátum típus

create table kutya(
	azon int primary key not null,
	nev varchar(32), 
    fajta varchar(45), 
    mag int, 
    suly double, 
    kan bool, 
    szul date
);

show tables;
-- 3. Vegye fel Buksi adatait: keverék kan kutya, 50 cm magas, 17,5 kg, az azonosítója 300.
insert into kutya
values (300, 'Buksi', 'keverék', 50, 17.5, true, null);

select * from kutya;

-- 4. Futtassa a kutyak_sql_adatok.sql állományban található utasítást további adatok beszúrásához!
-- 5. Vegyen fel egy elsogazda mezőt logikai típussal, alapértelmezett értéke legyen igaz!

alter table kutya
add (elsogazda bool default true);

-- 6. Módosítsa a 304-es azonosítójú kutya súlyát 34 kg-ra!
update kutya
set suly=34
where azon=304;


-- 7. törölje a 315-ös azonosítójú kutya sorát a táblából!

delete from kutya
where azon =315

/******** Lekérdezések **********/
-- 8. Írassa ki a fajtákat ábécé rendben! Minden fajtanév csak egyszer jelenjen meg.


-- 9. Írja ki azoknak a kutyáknak a nevét, fajtáját és a születésük időpontját, amelyekről tudjuk, hogy mikor születtek!


-- 10. Írassa ki a 10 kg-nál nehezebb nem keverék kan kutyák nevét, fajtáját és súlyát! Az adatokat sűly szerint növekvően rendezze!


-- 11. Írja ki az M betűvel kezdődő kutyaneveket! A kutyák neme is jelenjen meg.alter



-- 12. Írassa ki a legmagasabb kutya nevét fajtáját és magasságát!


-- 13. Írassa ki a legalacsonyabb nem keverék szuka kutya nevét fajtáját és magasságát!


-- 14. Írasas ki a 2017-ben született kutyák nevét, fajtáját, születési idejét. A lista a legfiatalabb kutyával kezdődjön.


-- 15. Hány darab kutya van az adatbázisban? A mező neve kutyák száma legyen!


-- 16. Hány darab kan és szuka kutya van az adatbázisban?


-- 16. Hány darab keverék kutya van?


-- 17. Fajtánként hány darab kutya van? Fajtanév szerint rendezett legyen a lista!


-- 18. Írqassa ki azokat a kutyafajtákat amelyekből egynél több van. A keverék ne jelenjen meg!


-- 19. Mennyi a kan kutyák átlagos súlya és magassága?


-- 20. Mennyi az összsúly azoknak a kutyáknak, amelyeknek nem ismerjük a születési idejét?alter


-- 21. Írassa ki az átlagosnál magasabb kutyák nevét és magasságát!
