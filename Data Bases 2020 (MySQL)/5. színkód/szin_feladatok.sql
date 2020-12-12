-- drop database szin;
-- 1. feladat:
create database szinkod
default char set utf8
collate utf8_hungarian_ci;

use szinkod;

-- 2. feladat:
create table szin(
	sorszam int primary key not null,
	nev varchar(30),
	hex varchar(7),
	r int,
	g int,
	b int
);

-- 3. feladat:
insert into szin
values
(137, 'white','#ffffff', 255,255,255),
(8, 'black','#000000', 0, 0, 0);

-- 5. feladat:
delete from szin
where sorszam=141;

-- 6. feladat:
delete from szin
where nev='paleo';

-- 7. feladat
update szin
set r = 250
where nev='salmon';

-- 8. feladat
update szin
set hex = '#00FFFF'
where nev='cyan';

-- 9. feladat
alter table szin
add index sx(nev);

-- 10. feladat
alter table szin
add (magyar_nev varchar(40));

-- 11. feladat
update szin
set magyar_nev = 'fekete'
where nev='black';

update szin
set magyar_nev = 'fehér'
where nev='white';

-- 12. feladat
select r, g, b 
from szin
where nev = 'pink';

-- 13. feladat
select nev
from szin
where g ='228';

-- 14. feladat
select nev
from szin
where r = 255 and g = 255;


-- 16. feladat
select nev
from szin
where r = 100 or g = 100 or b = 100;

-- 17. feladat
select nev
from szin
where (r and g and b) < 120;

-- 18. feladat
select nev
from szin
where r =0 and g >100
order by nev;

-- 19. feladat
select nev
from szin
where nev like 'b%';

-- 20. feladat
select nev
from szin
where nev like 's%';


select nev
from szin
where nev like '%green%';


select nev
from szin
where g = b;


select nev
from szin
where (r=g and g=b and r = b) and (r!=0 and r!=255);


