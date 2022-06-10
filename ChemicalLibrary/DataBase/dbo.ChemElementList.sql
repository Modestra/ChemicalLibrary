CREATE TABLE [dbo].[ChemElementList] (
    [Atom_Number]      INT  NOT NULL IDENTITY,
    [Element] TEXT NULL,
    [Name]    TEXT NULL,
    [Atomic_Mass] NCHAR(10) NULL, 
    PRIMARY KEY CLUSTERED ([Atom_Number] ASC)
);

