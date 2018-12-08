
--
-- TABLE: TipeMobil
-- 
--  

CREATE TABLE TipeMobil (
  tipeNo integer NOT NULL ,
  tipe character varying(200) NOT NULL 
);
CREATE SEQUENCE TipeMobil_tipeNo_seq START 1 INCREMENT 1 ;
ALTER TABLE TipeMobil ALTER COLUMN tipeNo SET DEFAULT nextval('TipeMobil_tipeNo_seq');

-- 
ALTER TABLE TipeMobil ADD CONSTRAINT tipeNo_tipemobil PRIMARY KEY (tipeNo);
