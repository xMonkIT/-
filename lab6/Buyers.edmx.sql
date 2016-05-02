
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 04/05/2016 10:43:43
-- Generated from EDMX file: C:\Users\vovka\Desktop\миспис лабы\Лаб 6_LINQ запросы\LINQPractice\lab6\Buyers.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Buyers];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_BuyBuyMerchandise]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[BuyMerchandise] DROP CONSTRAINT [FK_BuyBuyMerchandise];
GO
IF OBJECT_ID(N'[dbo].[FK_ClientBuy]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Buy] DROP CONSTRAINT [FK_ClientBuy];
GO
IF OBJECT_ID(N'[dbo].[FK_DiscountBuy]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Buy] DROP CONSTRAINT [FK_DiscountBuy];
GO
IF OBJECT_ID(N'[dbo].[FK_MerchandiseBuyMerchandise]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[BuyMerchandise] DROP CONSTRAINT [FK_MerchandiseBuyMerchandise];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Buy]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Buy];
GO
IF OBJECT_ID(N'[dbo].[BuyMerchandise]', 'U') IS NOT NULL
    DROP TABLE [dbo].[BuyMerchandise];
GO
IF OBJECT_ID(N'[dbo].[Client]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Client];
GO
IF OBJECT_ID(N'[dbo].[Discount]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Discount];
GO
IF OBJECT_ID(N'[dbo].[Merchandise]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Merchandise];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Buys'
CREATE TABLE [dbo].[Buys] (
    [Идентификатор] int IDENTITY(1,1) NOT NULL,
    [Date] datetime  NOT NULL,
    [Client_Идентификатор] int  NOT NULL,
    [Discount_Идентификатор] int  NOT NULL
);
GO

-- Creating table 'BuyMerchandises'
CREATE TABLE [dbo].[BuyMerchandises] (
    [Идентификатор] int IDENTITY(1,1) NOT NULL,
    [Count] smallint  NOT NULL,
    [Merchandise_Идентификатор] int  NOT NULL,
    [Buy_Идентификатор] int  NOT NULL
);
GO

-- Creating table 'Clients'
CREATE TABLE [dbo].[Clients] (
    [Идентификатор] int IDENTITY(1,1) NOT NULL,
    [LastName] nvarchar(max)  NOT NULL,
    [FirstName] nvarchar(max)  NOT NULL,
    [Patronymic] nvarchar(max)  NULL,
    [Address] nvarchar(max)  NULL
);
GO

-- Creating table 'Discounts'
CREATE TABLE [dbo].[Discounts] (
    [Идентификатор] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NULL,
    [Percents] smallint  NOT NULL
);
GO

-- Creating table 'Merchandises'
CREATE TABLE [dbo].[Merchandises] (
    [Идентификатор] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Price] float  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Идентификатор] in table 'Buys'
ALTER TABLE [dbo].[Buys]
ADD CONSTRAINT [PK_Buys]
    PRIMARY KEY CLUSTERED ([Идентификатор] ASC);
GO

-- Creating primary key on [Идентификатор] in table 'BuyMerchandises'
ALTER TABLE [dbo].[BuyMerchandises]
ADD CONSTRAINT [PK_BuyMerchandises]
    PRIMARY KEY CLUSTERED ([Идентификатор] ASC);
GO

-- Creating primary key on [Идентификатор] in table 'Clients'
ALTER TABLE [dbo].[Clients]
ADD CONSTRAINT [PK_Clients]
    PRIMARY KEY CLUSTERED ([Идентификатор] ASC);
GO

-- Creating primary key on [Идентификатор] in table 'Discounts'
ALTER TABLE [dbo].[Discounts]
ADD CONSTRAINT [PK_Discounts]
    PRIMARY KEY CLUSTERED ([Идентификатор] ASC);
GO

-- Creating primary key on [Идентификатор] in table 'Merchandises'
ALTER TABLE [dbo].[Merchandises]
ADD CONSTRAINT [PK_Merchandises]
    PRIMARY KEY CLUSTERED ([Идентификатор] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Buy_Идентификатор] in table 'BuyMerchandises'
ALTER TABLE [dbo].[BuyMerchandises]
ADD CONSTRAINT [FK_BuyBuyMerchandise]
    FOREIGN KEY ([Buy_Идентификатор])
    REFERENCES [dbo].[Buys]
        ([Идентификатор])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_BuyBuyMerchandise'
CREATE INDEX [IX_FK_BuyBuyMerchandise]
ON [dbo].[BuyMerchandises]
    ([Buy_Идентификатор]);
GO

-- Creating foreign key on [Client_Идентификатор] in table 'Buys'
ALTER TABLE [dbo].[Buys]
ADD CONSTRAINT [FK_ClientBuy]
    FOREIGN KEY ([Client_Идентификатор])
    REFERENCES [dbo].[Clients]
        ([Идентификатор])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClientBuy'
CREATE INDEX [IX_FK_ClientBuy]
ON [dbo].[Buys]
    ([Client_Идентификатор]);
GO

-- Creating foreign key on [Discount_Идентификатор] in table 'Buys'
ALTER TABLE [dbo].[Buys]
ADD CONSTRAINT [FK_DiscountBuy]
    FOREIGN KEY ([Discount_Идентификатор])
    REFERENCES [dbo].[Discounts]
        ([Идентификатор])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_DiscountBuy'
CREATE INDEX [IX_FK_DiscountBuy]
ON [dbo].[Buys]
    ([Discount_Идентификатор]);
GO

-- Creating foreign key on [Merchandise_Идентификатор] in table 'BuyMerchandises'
ALTER TABLE [dbo].[BuyMerchandises]
ADD CONSTRAINT [FK_MerchandiseBuyMerchandise]
    FOREIGN KEY ([Merchandise_Идентификатор])
    REFERENCES [dbo].[Merchandises]
        ([Идентификатор])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MerchandiseBuyMerchandise'
CREATE INDEX [IX_FK_MerchandiseBuyMerchandise]
ON [dbo].[BuyMerchandises]
    ([Merchandise_Идентификатор]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------