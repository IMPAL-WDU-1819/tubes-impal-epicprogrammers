
--
-- TABLE: Employee
-- 
--  

CREATE TABLE Employee (
  email string NOT NULL ,
  pass string NOT NULL ,
  address string NOT NULL ,
  nama string NOT NULL ,
  user string NOT NULL ,
  notel numeric NOT NULL ,
  lastLogin date NOT NULL 
);

-- 
ALTER TABLE Employee ADD CONSTRAINT new_unique_constraint PRIMARY KEY (email);
