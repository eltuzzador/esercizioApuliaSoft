CREATE TABLE SvoltoDa(
Data TEXT(20) NOT NULL,
Ore INTEGER NOT NULL,
ID_Project TEXT(20) NOT NULL REFERENCES Project(Nome_Progetto),
ID_Employee TEXT(10) NOT NULL REFERENCES Employee (Nome),
PRIMARY KEY(ID_Project, ID_Employee, Data)

);