
--
-- TABLE: User2Item
-- 
--  

CREATE TABLE User2Item (
  no integer NOT NULL ,
  emailuser character varying(200) NOT NULL ,
  itemNo integer NOT NULL 
);
CREATE SEQUENCE User2Item_no_seq START 1 INCREMENT 1 ;
ALTER TABLE User2Item ALTER COLUMN no SET DEFAULT nextval('User2Item_no_seq');

-- 
ALTER TABLE User2Item ADD CONSTRAINT no_user2item PRIMARY KEY (no);

-- 
ALTER TABLE User2Item ADD CONSTRAINT fkey_item_itemNo FOREIGN KEY (itemNo) REFERENCES Item(itemNo) ON UPDATE NO ACTION ON DELETE NO ACTION;

-- 
ALTER TABLE User2Item ADD CONSTRAINT fkey_email_user FOREIGN KEY (emailuser) REFERENCES Consumer(Email) ON UPDATE NO ACTION ON DELETE NO ACTION;
