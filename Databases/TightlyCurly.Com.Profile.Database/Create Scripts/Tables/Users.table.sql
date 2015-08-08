USE Alligoshee.Hair_PROFILE
GO

IF OBJECT_ID ('Users', 'U') IS NOT NULL
BEGIN
	DROP TABLE Users;
END 

CREATE TABLE Users (
	UserId int IDENTITY(1,1) NOT NULL,
	Username nvarchar(25) NOT NULL,
	FirstName nvarchar(255) NOT NULL,
	MiddleName nvarchar(255) NULL,
	LastName nvarchar(255) NOT NULL,
	IsDeactivated bit NULL,
	SignupDate smalldatetime NOT NULL,
	UpdatedDate smalldatetime NOT NULL,
	CONSTRAINT PK_Users PRIMARY KEY(UserId));
	 