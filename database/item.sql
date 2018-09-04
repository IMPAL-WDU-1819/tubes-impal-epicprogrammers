
--
-- TABLE: Item
-- 
--  

CREATE TABLE Item (
  itemNo int NOT NULL ,
  namaMobil string NOT NULL ,
  harga double precision NOT NULL ,
  tipeNo int NOT NULL ,
  warna string NOT NULL ,
  jobId int NOT NULL 
);

-- 
ALTER TABLE Item ADD CONSTRAINT new_unique_constraint PRIMARY KEY (itemNo);

-- 
ALTER TABLE Item ADD CONSTRAINT fkey_jobId_job FOREIGN KEY (jobId) REFERENCES Job(jobId) ON UPDATE NO ACTION ON DELETE NO ACTION;

-- 
ALTER TABLE Item ADD CONSTRAINT fkey_tipeNo_tipeMobil FOREIGN KEY (tipeNo) REFERENCES TipeMobil(tipeNo) ON UPDATE NO ACTION ON DELETE NO ACTION;
