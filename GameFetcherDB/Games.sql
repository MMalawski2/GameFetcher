﻿ CREATE TABLE [dbo].[Games]
(
	[Id] INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	Title VARCHAR (100) NOT NULL,
	ReleaseDate INT,
	Summary NVARCHAR (4000),
	Status INT NOT NULL DEFAULT 1,
	CONSTRAINT fk_PlayingStatus FOREIGN KEY (Status) REFERENCES PlayingStatus (id)
)
