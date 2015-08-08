INSERT Users (
	Username, 
	EmailAddress,
	PasswordQuestion,
	PasswordAnswer,
	Password,
	IsApproved,
	CreationDate)
VALUES (
	'telzeek',
	'teri@tightlycurly.com',
	'What was my cat''s name in Kentucky',
	'Elmer',
	'BF815CEF5EDB3B6198A69901DA33694A7D8D7749',
	1,
	GETDATE());

INSERT Users (
	Username, 
	EmailAddress,
	PasswordQuestion,
	PasswordAnswer,
	Password,
	IsApproved,
	CreationDate)
VALUES (
	'jhcrump',
	'jhcrump@gmail.com',
	'What was my cat''s name',
	'Buddy',
	'BF815CEF5EDB3B6198A69901DA33694A7D8D7749',
	1,
	GETDATE());
