
--
-- TABLE: Part
-- 
--  

CREATE TABLE Part (
  itemNo integer NOT NULL ,
  namaPart character varying(200) NOT NULL ,
  harga double precision NOT NULL ,
  qty integer NOT NULL 
);
CREATE SEQUENCE Part_itemNo_seq START 1 INCREMENT 1 ;
ALTER TABLE Part ALTER COLUMN itemNo SET DEFAULT nextval('Part_itemNo_seq');

-- 
ALTER TABLE Part ADD CONSTRAINT itemNo_part PRIMARY KEY (itemNo);
