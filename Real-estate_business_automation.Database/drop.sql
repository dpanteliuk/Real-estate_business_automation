USE [DB_Real_Estate_Strorage];
GO

IF OBJECT_ID('dbo.Contracts','U') IS NOT NULL
 DROP TABLE dbo.Contracts;
GO

IF OBJECT_ID('dbo.Estate','U') IS NOT NULL
 DROP TABLE dbo.Estate;
GO

IF OBJECT_ID('dbo.District','U') IS NOT NULL
 DROP TABLE dbo.District;
GO

IF OBJECT_ID('dbo.DBUser','U') IS NOT NULL
 DROP TABLE dbo.DBUser;
GO

IF OBJECT_ID('dbo.Person','U') IS NOT NULL
 DROP TABLE dbo.Person;
GO