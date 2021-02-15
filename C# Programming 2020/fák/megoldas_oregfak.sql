-- 1. feladat
-- Készítse el az adatbázist oregfak néven, UTF-8 kódolással, magyar ábécé szerinti rendezéssel!
-- Ezután futtassa a táblák.sql és az adatok.sql állományok tartalmát!
create database oregfak
default char set utf8
collate utf8_hungarian_ci;

use oregfak;

-- 2. feladat
-- Ábécérendben írja ki a 9 méternél nagyobb körméretű fák fajnevét és körméretét méterben!
select faj, kormeret/100
from fa
where kormeret > 900
order by faj;


-- 3. feladat
-- Írassa ki a legnagyobb kerületű fa fajnevét, körméretét és feljegyzésének évét!
select faj, kormeret, meres
from fa
order by kormeret desc
limit 1;


-- 4. feladat
-- Az egyes településekhez hány fa tartozik?! A lista darabszám szerint csökkenő legyen!
-- Azonos darabszám esetén a településnév szerint ábécérendbe rendezze!
select telepules, count(*)
from fa
group by telepules
order by count(*) desc, telepules ;

-- 5. feladat
-- Írass ki a szilfák fajtáját, települését és azt, hogy melyik megyében van
select faj, telepules, nev
from megye inner join fa on megye.id = fa.megyeid
where faj like '%szil';

-- 6. feladat
-- Megyénként hány fáról állnak rendelkezésre adatok?
select nev, count(*)
from megye inner join fa on megye.id = fa.megyeid
group by id;

-- 7. feladat
-- Gyűjtse ki azoknak a fáknak a fajnevét, amelyek ugyanazon a településen találhatók, amelyen tiszafa is van! 
-- A listában a tiszafa neve ne, minden további fajnév egyszer jelenjen meg!


select distinct faj
from fa
where faj != 'tiszafa' && telepules in (select telepules from fa  where faj = 'tiszafa');

-- 8. feladat
-- Írassa ki azokat a megyéket, ahol valamilyen gesztenyefa található! A megyék neve egyszer jelenjen meg!
select distinct megye.nev
from megye inner join fa on megye.id = fa.megyeid
where faj like '%gesztenye';

-- 9. feladat
-- Melyik megyében van a legnagyobb körméretű fa?
select nev
from megye inner join fa on megye.id = fa.megyeid
order by kormeret desc
limit 1;





