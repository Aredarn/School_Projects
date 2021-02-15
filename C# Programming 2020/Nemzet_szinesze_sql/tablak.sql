CREATE TABLE elismeres(
   id integer primary key NOT NULL,
   megnevezes varchar(100) NOT NULL  
);

CREATE TABLE kapott(
   id integer primary key NOT NULL auto_increment,
   ev int,
   szineszid int,
   elismeresid int
);

CREATE TABLE szinesz(
   id integer NOT NULL primary key,
   nev varchar(50),
   szuletesinev varchar(50),
   valasztas date,
   szuletett date,
   szuletesihely varchar(40),
   elhunyt date,
   halalozasihely varchar(40)   
);

ALTER TABLE kapott
  ADD CONSTRAINT FK_szinesz_kapott FOREIGN KEY (szineszid)
    REFERENCES szinesz(id);
ALTER TABLE kapott
  ADD CONSTRAINT FK_elismeres_kapott FOREIGN KEY (elismeresid)
    REFERENCES elismeres(id);