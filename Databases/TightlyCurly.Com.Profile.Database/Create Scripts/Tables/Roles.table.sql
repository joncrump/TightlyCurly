﻿USE Alligoshee.Hair_PROFILE
GO

IF OBJECT_ID ('Roles', 'U') IS NOT NULL
BEGIN
	DROP TABLE Roles;
END

CREATE TABLE Roles (
	RoleId int IDENTITY(1,1) NOT NULL,
	RoleName nvarchar(255)
	CONSTRAINT PK_Roles PRIMARY KEY(RoleId));
