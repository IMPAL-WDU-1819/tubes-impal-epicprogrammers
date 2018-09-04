
--
-- TABLE: Consumer
-- 
--  

CREATE TABLE Consumer (
  Email string NOT NULL ,
  username string NOT NULL ,
  notel numeric NOT NULL ,
  address string NOT NULL ,
  nama string NOT NULL ,
  pass string NOT NULL 
);

-- 
ALTER TABLE Consumer ADD CONSTRAINT new_unique_constraint PRIMARY KEY (Email);
