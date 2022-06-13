CREATE TABLE [dbo].[ChemElementList] (
    [Atomic_Number] INT  IDENTITY (1, 1) NOT NULL,
    [Element]       TEXT NULL,
    [Name]          VARCHAR(MAX) NULL,
    [Atomic_Mass]   DECIMAL(4, 2) NULL,
    PRIMARY KEY CLUSTERED ([Atomic_Number] ASC)
);

