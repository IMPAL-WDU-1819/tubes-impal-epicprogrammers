
--
-- TABLE: Part2Item
-- 
--  

CREATE TABLE Part2Item (
  no integer NOT NULL ,
  itemNoItem integer NOT NULL ,
  itemNoPart integer NOT NULL 
);
CREATE SEQUENCE Part2Item_no_seq START 1 INCREMENT 1 ;
ALTER TABLE Part2Item ALTER COLUMN no SET DEFAULT nextval('Part2Item_no_seq');

-- 
ALTER TABLE Part2Item ADD CONSTRAINT no_part2item PRIMARY KEY (no);

-- 
ALTER TABLE Part2Item ADD CONSTRAINT fkey_itemno_item FOREIGN KEY (itemNoItem) REFERENCES Item(itemNo) ON UPDATE NO ACTION ON DELETE NO ACTION;

-- 
ALTER TABLE Part2Item ADD CONSTRAINT fkey_itemno_part FOREIGN KEY (itemNoPart) REFERENCES Part(itemNo) ON UPDATE NO ACTION ON DELETE NO ACTION;
