INSERT INTO ChemElementList(Element,Name, Atomic_Mass) VALUES('C',N'Углерод', 10.81);
DELETE FROM ChemElementList;
DBCC CHECKIDENT ('ChemElementList', RESEED, 0);
