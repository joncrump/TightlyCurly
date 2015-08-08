IF OBJECT_ID ('Roles', 'U') IS NOT NULL
BEGIN
	DROP TABLE Roles;
END

CREATE TABLE Roles (
	RoleId int NOT NULL IDENTITY(1,1),
	RoleName nvarchar(255) NOT NULL,
	Description nvarchar(4000) NOT NULL,
	CONSTRAINT PK_Roles PRIMARY KEY(RoleId));

