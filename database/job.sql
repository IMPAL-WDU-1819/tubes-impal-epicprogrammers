
--
-- TABLE: Job
-- 
--  

CREATE TABLE Job (
  jobId int NOT NULL ,
  progress string NOT NULL ,
  employeeEmail string NOT NULL ,
  lastUpdated time without time zone NOT NULL 
);

-- 
ALTER TABLE Job ADD CONSTRAINT new_unique_constraint PRIMARY KEY (jobId);

-- 
ALTER TABLE Job ADD CONSTRAINT fkey_employeeEmail_employee FOREIGN KEY (employeeEmail) REFERENCES Employee(email) ON UPDATE NO ACTION ON DELETE NO ACTION;
