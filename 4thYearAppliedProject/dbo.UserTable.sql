﻿CREATE TABLE [dbo].[UserTable]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Username] VARCHAR(30) NOT NULL, 
    [Email] VARCHAR(100) NOT NULL, 
    [Password] VARCHAR(30) NOT NULL, 
    [Score] INT NOT NULL DEFAULT 0
)
