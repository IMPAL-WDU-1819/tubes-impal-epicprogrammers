
--
-- TABLE: User
-- 
--  

CREATE TABLE User (
  Email string NOT NULL ,
  User string NOT NULL ,
  notel numeric NOT NULL ,
  address string NOT NULL ,
  nama string NOT NULL ,
  pass string NOT NULL 
);

-- 
ALTER TABLE User ADD CONSTRAINT new_unique_constraint PRIMARY KEY (Email);
