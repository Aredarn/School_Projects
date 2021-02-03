
-- megye tábla létrehozása: 
create table megye(
id int primary key,
nev varchar(70)
);

-- fa tábla létrehozása:
create table fa (
azon int primary key,
faj varchar(50),
kormeret int,		-- kerület centiméterben
telepules varchar(60),
megyeid int,
meres int,			-- mérés éve
constraint fk_fa_megye foreign key (megyeid) references megye(id)
);

