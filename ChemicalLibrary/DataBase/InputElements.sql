INSERT INTO ChemElementList(Element,Name, Atomic_Mass) VALUES('C',N'Углерод', 12);
DELETE FROM ChemElementList;
DBCC CHECKIDENT ('ChemElementList', RESEED, 0);
