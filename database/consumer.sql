
--
-- TABLE: Consumer
-- 
--  

CREATE TABLE Consumer (
  Email character varying(200) NOT NULL ,
  username character varying(200) NOT NULL ,
  notel numeric NOT NULL ,
  address character varying(500) NOT NULL ,
  nama character varying(200) NOT NULL ,
  pass character varying(200) NOT NULL 
);

-- 
ALTER TABLE Consumer ADD CONSTRAINT consumer_email PRIMARY KEY (Email);
