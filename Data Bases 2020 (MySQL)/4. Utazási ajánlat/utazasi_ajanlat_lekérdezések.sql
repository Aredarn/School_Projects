--  1. feladat: 
select honap, ej, maxfo
from utak
where taje = 'Mátra'
order by ej desc;

--  2. feladat: 
select taje, ej, honap
from utak
where ej>=5 and csalados = true;

--  3. feladat: 
select taje, ej, ar
from utak
order by ar desc
limit 1;

--  4. feladat: 
select taje, ej, ar 
from utak
where (ar > 40000 and ar < 50000) and ej >=5
order by taje;

--  5. feladat: 
select taje, count(*) darab
from utak
group by taje;

--  6. feladat: 
select count(*) negyven_fő_feletti_út
from utak
where maxfo > 40;

--  7. feladat: 
select taje, count(*) darab
from utak
where csalados = false
group by taje;

--  8. feladat: 
select count(*) nem_csalados_hortobagyi_max5fo
from utak
where (ej<=5 and taje='hortobagy') and csalados = false;

--  9. feladat: 
select honap ,count(*)
from utak
group by honap
having count(*) > 8;

--  10. feladat: 
select avg(ar) szeptemberi_harom_ejszakas_átlagár
from utak
where honap = 'Szeptember' and ej =3;