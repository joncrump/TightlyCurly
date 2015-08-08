IF OBJECT_ID ('Users', 'U') IS NOT NULL
BEGIN
	DROP TABLE Users;
END

CREATE TABLE Users (
	UserId int IDENTITY(1,1) NOT NULL,
	Username nvarchar(255) NOT NULL,
	EmailAddress nvarchar(255) NOT NULL,
	IsLockedOut bit NULL,
	PasswordQuestion nvarchar(255) NOT NULL,
	PasswordAnswer nvarchar(1000) NOT NULL,
	Comment nvarchar(255) NULL,
	Password nvarchar(1000) NOT NULL,
	IsApproved bit NULL,
	CreationDate smalldatetime NULL,
	LastLoginDate smalldatetime NULL,
	LastActivityDate smalldatetime NULL,
	LastPasswordChangedDate smalldatetime NULL,
	LastLockoutDate smalldatetime NULL,
	CONSTRAINT PK_Users PRIMARY KEY(UserId));
