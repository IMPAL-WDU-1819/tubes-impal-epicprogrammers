
--
-- TABLE: Item
-- 
--  

CREATE TABLE Item (
  itemNo integer NOT NULL ,
  namaMobil character varying(200) NOT NULL ,
  harga double precision NOT NULL ,
  tipeNo integer NOT NULL ,
  warna character varying(200) NOT NULL ,
  jobId integer NOT NULL 
);
CREATE SEQUENCE Item_itemNo_seq START 1 INCREMENT 1 ;
ALTER TABLE Item ALTER COLUMN itemNo SET DEFAULT nextval('Item_itemNo_seq');

-- 
ALTER TABLE Item ADD CONSTRAINT itemNo_item PRIMARY KEY (itemNo);

-- 
ALTER TABLE Item ADD CONSTRAINT fkey_jobId_job FOREIGN KEY (jobId) REFERENCES Job(jobId) ON UPDATE NO ACTION ON DELETE NO ACTION;

-- 
ALTER TABLE Item ADD CONSTRAINT fkey_tipeNo_tipeMobil FOREIGN KEY (tipeNo) REFERENCES TipeMobil(tipeNo) ON UPDATE NO ACTION ON DELETE NO ACTION;
