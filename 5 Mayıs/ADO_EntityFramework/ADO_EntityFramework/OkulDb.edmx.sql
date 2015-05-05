
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 05/05/2015 15:15:54
-- Generated from EDMX file: c:\users\ogrenci\documents\visual studio 2013\Projects\ADO_EntityFramework\ADO_EntityFramework\OkulDb.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [OkulDb];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Veliler'
CREATE TABLE [dbo].[Veliler] (
    [VeliId] int IDENTITY(1,1) NOT NULL,
    [VeliAdi] varchar(50)  NOT NULL,
    [VeliSoyadi] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [VeliId] in table 'Veliler'
ALTER TABLE [dbo].[Veliler]
ADD CONSTRAINT [PK_Veliler]
    PRIMARY KEY CLUSTERED ([VeliId] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------