USE Alligoshee.Hair_PROFILE
GO

IF OBJECT_ID ('Genders', 'U') IS NOT NULL
BEGIN
	DROP TABLE Genders;
END 
 
CREATE TABLE Genders (
	GenderId smallint IDENTITY(1,1) NOT NULL,
	GenderName varchar(30) NOT NULL,
	CONSTRAINT PK_Genders PRIMARY KEY(GenderId));