
--
-- TABLE: Job
-- 
--  

CREATE TABLE Job (
  jobId integer NOT NULL ,
  progress character varying(500) NOT NULL ,
  employeeEmail character varying(200) NOT NULL ,
  lastUpdated timestamp NOT NULL 
);

-- 
ALTER TABLE Job ADD CONSTRAINT jobId_job PRIMARY KEY (jobId);

-- 
ALTER TABLE Job ADD CONSTRAINT fkey_employeeEmail_employee FOREIGN KEY (employeeEmail) REFERENCES Employee(email) ON UPDATE NO ACTION ON DELETE NO ACTION;
