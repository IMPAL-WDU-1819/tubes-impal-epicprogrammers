
--
-- TABLE: TipeMobil
-- 
--  

CREATE TABLE TipeMobil (
  tipeNo int NOT NULL ,
  tipe string NOT NULL 
);

-- 
ALTER TABLE TipeMobil ADD CONSTRAINT new_unique_constraint PRIMARY KEY (tipeNo);
