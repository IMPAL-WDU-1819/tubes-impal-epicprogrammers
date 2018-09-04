
--
-- TABLE: Part2Item
-- 
--  

CREATE TABLE Part2Item (
  no int NOT NULL ,
  itemNoItem int NOT NULL ,
  itemNoPart int NOT NULL 
);
CREATE SEQUENCE Part2Item_no_seq START 1 INCREMENT 1 ;
ALTER TABLE Part2Item ALTER COLUMN no SET NOT 0;
ALTER TABLE Part2Item ALTER COLUMN no SET DEFAULT nextval('Part2Item_no_seq');

-- 
ALTER TABLE Part2Item ADD CONSTRAINT new_unique_constraint PRIMARY KEY (no);

-- 
ALTER TABLE Part2Item ADD CONSTRAINT fkey_itemno_item FOREIGN KEY (itemNoItem) REFERENCES Item(itemNo) ON UPDATE NO ACTION ON DELETE NO ACTION;

-- 
ALTER TABLE Part2Item ADD CONSTRAINT fkey_itemno_part FOREIGN KEY (itemNoPart) REFERENCES Part(itemNo) ON UPDATE NO ACTION ON DELETE NO ACTION;
