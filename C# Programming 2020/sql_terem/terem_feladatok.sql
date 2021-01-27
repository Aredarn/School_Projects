
-- 1. Írassa ki a táblázat minden adatát!
select * from terem;

-- 2. Írassa ki, hogy melyik terem hány férőhelyes, férőhely szerint csökkenő sorrendben!
select szam, ferohely 
from terem
order by ferohely desc;


-- 3. Írassa ki az első emeleti termek típusát és férőhelyét!
select tipus, ferohely
from terem
where emelet = 1;

-- 4. Írassa ki a legalább 25 férőhelyes, projektoros termeket típussal, emelettel!
select szam, tipus, emelet
from terem
where ferohely > 24 and projektor = true;

-- 5. Írassa ki a nyelvi és informatikatermeket férőhellyel teremszám szerint emelkedő sorrendben!
select szam, ferohely, tipus
from terem
where tipus = "informatika" or tipus = "nyelvi"
order by szam;

-- 6. Összesen hány terem van és mennyi az összes férőhely?
select count(*), sum(ferohely)
from terem;

-- 7. Emeletenként hány terem van?
select emelet, count(*)
from terem
group by emelet;

-- 8. Hány terem rendelkezik projektorral?


-- 9. Mennyi az általános típusú termek átlagos és maximális férőhelye?


-- 10. Hány informatikaterem van összesen az első és második emeleten?


-- 11. Mennyi az átlagos férőhely a projektoros, általános termekben emeletenként?


-- 12. Írassa ki a második emeleti termeket a típusukkal együtt!


-- 13. Melyik második emeleti termekben van projektor?


-- 14. Írassa ki az informatikatermeket, férőhely szerint csökkenő sorrendben!


-- 15. Melyik emeleten van a 42-es számú terem?


-- 16. Milyen típusú termekből hány darab van?


-- 17. Hány projektor nélküli terem van az első emeleten?


-- 18. Mekkora emeletenként a maximális férőhely?


-- 19. Hány darab 30 fősnél kisebb, projektoros terem van?