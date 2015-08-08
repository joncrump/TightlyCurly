USE Alligoshee.Hair_PROFILE
GO

IF OBJECT_ID ('Profiles', 'U') IS NOT NULL
BEGIN
	DROP TABLE Profiles;
END  

	CREATE TABLE Profiles (
		ProfileId int IDENTITY(1,1) NOT NULL,
		UserId int NOT NULL,
		GenderId smallint NOT NULL,
		BirthDate smalldatetime NOT NULL,
		Signature nvarchar(400) NOT NULL,
		EmailAddress nvarchar(300) NOT NULL,
		AboutMe nvarchar(300) NOT NULL,
		Avatar image NULL,
		Password nvarchar(500) NOT NULL,
		SecurityQuestion1 nvarchar(255) NOT NULL,
		SecurityQuestion1Answer nvarchar(1000) NOT NULL,
		SecurityQuestion2 nvarchar(255) NOT NULL,
		SecurityQuestion2Answer nvarchar(1000) NOT NULL,
		SecurityQuestion3 nvarchar(255) NOT NULL,
		SecurityQuestion3Answer nvarchar(1000) NULL,
		City nvarchar(255) NULL,
		State nvarchar(255) NULL,
		Country nvarchar(255) NULL,
		CONSTRAINT PK_Profiles PRIMARY KEY(ProfileId),
		CONSTRAINT FK_Profiles_Gender FOREIGN KEY(GenderId) REFERENCES Genders(GenderId));