--create database Test --it creates the database named Test

--drop database Test --it deletes the database named Test

--USE TEST -- CHANGES THE ACTIVE DATABASE 

CREATE TABLE TABLEONE
(
	ID INT,
	NAME NVARCHAR(20)
)

INSERT INTO TABLETWO (ID,NAME) VALUES
(123,'PRABI'),
('234','JEEWSAN')


SELECT * FROM TABLETWO
