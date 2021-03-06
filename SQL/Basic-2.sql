--ADD COLUMNS TO EXISTING TABLE
USE TEST

ALTER TABLE TABLEONE
ADD EMAIL NVARCHAR(50)

SELECT * FROM TABLEONE

--UPDATING THE RECORDS IN THE TABLE
UPDATE TABLEONE 
SET ID=1 -- USING TILL HERE IS QUITE DANGEROUS, AS IT SETS ID 1 FOR EVERY RECORD
WHERE ID IS NULL


--MAKING REQUIRED TO EXISTING COLUMN
ALTER TABLE TABLEONE 
ADD CONSTRAINT UK_EMAIL UNIQUE (EMAIL)

ALTER TABLE TABLEONE 
ADD PRIMARY KEY (ID)

SELECT * FROM TABLEONE 
WHERE NAME < 'C' AND ID < 0

UPDATE TABLEONE 
SET NAME='TEST' -- USING TILL HERE IS QUITE DANGEROUS
WHERE NAME IS NULL

--DELETE 
DELETE FROM TABLEONE WHERE NAME IS NULL


