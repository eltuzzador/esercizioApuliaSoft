-- SQLite
INSERT INTO Employee(Nome)
VALUES
('Mario'),
('Giovanni'),
('Lucia');

INSERT INTO Project(Nome_Progetto)
VALUES
('Manhattan'),
('Mars Rover');

INSERT INTO SvoltoDa(Data,Ore,ID_Project,ID_Employee)
VALUES
('27 Aug 2021', 5, 'Mars Rover', 'Mario'),
('31 Aug 2021', 3, 'Manhattan', 'Giovanni'),
('01 Sep 2021', 3, 'Mars Rover', 'Mario'),
('01 Sep 2021', 3, 'Mars Rover', 'Lucia'),
('27 Aug 2021', 3, 'Manhattan', 'Mario'),
('01 Sep 2021', 3, 'Manhattan', 'Giovanni');

