CREATE DATABASE [ImpuestoEstampilla];

USE [ImpuestoEstampilla]

CREATE TABLE [dbo].[ImpuestoEstampilla](
[NumeroDeContrato] [nvarchar](10) NOT NULL PRIMARY KEY,
[ObjetoDelContrato] [nvarchar](20) NULL,
[ValorDelContrato] [numeric](18, 0) NULL,
[ApoyaEmergenciaCovid19] [nvarchar](2) NULL,
[ValorEstampilla] [numeric](18, 0) NULL,
) 
GO

COMMIT