
--
-- TABLE: User2Item
-- 
--  

CREATE TABLE User2Item (
  no int NOT NULL ,
  emailuser string NOT NULL ,
  itemNo int NOT NULL 
);
CREATE SEQUENCE User2Item_no_seq START 1 INCREMENT 1 ;
ALTER TABLE User2Item ALTER COLUMN no SET NOT 0;
ALTER TABLE User2Item ALTER COLUMN no SET DEFAULT nextval('User2Item_no_seq');

-- 
ALTER TABLE User2Item ADD CONSTRAINT new_unique_constraint PRIMARY KEY (no);

-- 
ALTER TABLE User2Item ADD CONSTRAINT fkey_item_itemNo FOREIGN KEY (itemNo) REFERENCES Item(itemNo) ON UPDATE NO ACTION ON DELETE NO ACTION;

-- 
ALTER TABLE User2Item ADD CONSTRAINT fkey_email_user FOREIGN KEY (emailuser) REFERENCES User(Email) ON UPDATE NO ACTION ON DELETE NO ACTION;
