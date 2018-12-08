
--
-- TABLE: Employee
-- 
--  

CREATE TABLE Employee (
  email character varying(200) NOT NULL ,
  pass character varying(200) NOT NULL ,
  address character varying(500) NOT NULL ,
  nama character varying(200) NOT NULL ,
  username character varying(200) NOT NULL ,
  notel numeric NOT NULL ,
  lastLogin date NOT NULL 
);

-- 
ALTER TABLE Employee ADD CONSTRAINT email_employee PRIMARY KEY (email);
