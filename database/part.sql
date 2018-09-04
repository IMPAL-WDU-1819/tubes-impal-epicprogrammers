
--
-- TABLE: Part
-- 
--  

CREATE TABLE Part (
  itemNo int NOT NULL ,
  namaPart string NOT NULL ,
  harga double precision NOT NULL ,
  qty int NOT NULL 
);

-- 
ALTER TABLE Part ADD CONSTRAINT new_unique_constraint PRIMARY KEY (itemNo);
