USE [master]
GO
CREATE DATABASE [GeoTema]
GO
USE [GeoTema]
GO
CREATE TABLE [dbo].[Lande](
	[ID] [int] NOT NULL,
	[Lande] [varchar](30) NULL,
	[Verdensdel] [varchar](15) NULL,
	[Rang] [varchar](30) NULL,
	[FodselsRate] [varchar](10) NULL,
	PRIMARY KEY (ID)
)
