﻿CREATE TABLE [dbo].[Member]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
	[MemberID] INT NOT NULL, 
	[FirstName] NVARCHAR(50) NOT NULL, 
	[LastName] NVARCHAR(50) NOT NULL, 
	[TelNo] NCHAR(10) NOT NULL, 
	[EMail] NVARCHAR(100) NOT NULL, 
	[PostCode] NCHAR(10) NOT NULL
)