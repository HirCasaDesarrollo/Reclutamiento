USE [HirCasa]


-- Insertar

-- 1

INSERT INTO Cliente
VALUES ('Alyssa   Macdonald  King', '477-1943', 'magnis.dis@yahoo.couk', 24, '$74,300.04', null,0 , 'Dec 4, 2021'),
('Irene   Carey    Spears', '1-153-173-1315', 'donec.feugiat@protonmail.com', 18, '$1,213,748.20', null,0 , 'Sep 16, 2022'),
('Hope          Best Charity', '1-810-927-0758', 'sed.neque@yahoo.edu', 45, '$378,121.58', null,0 , 'Sep 18, 2021'),
('  Kirsten   Glover   Carrison', '488-7837', 'ipsum.ac.mi@google.edu', 39, '$22,430.14', null,0 , 'Feb 6, 2022'),
('Cheyenne Norton       Mcdonald', '1-638-481-3863', 'nulla.eu@yahoo.ca', 28, '$664,419.39', null,0 , 'Apr 1, 2022'),
(' Kirk Nichols Douglas', '348-0176', 'donec@yahoo.edu', 25, '$980,000.50', null,0 , 'Sep 24, 2022'),
('Blaze  Massey    Adams  ', '1-483-678-4909', 'sed@aol.edu', 56, '$276,899.83', null,0 , 'Jul 9, 2022'),
('Raphael    Wright Allen', '942-4114', 'dolor.donec.fringilla@aol.couk', 83, '$778,564.00', 'Adeudo',0 , 'Jul 28, 2022'),
('   Pamela   Hanson  Love', '1-760-505-0882', 'sed@yahoo.org', 60, '$331,876.00', null,0 , 'Jan 13, 2022'),
('Lois  Byers                Parson', '1-773-637-7287', 'eu.eleifend.nec@yahoo.com', 37, '$634,567.20', null,0 , 'Sep 10, 2022');

-- 2

INSERT INTO Pago
VALUES (1, 8, '$898,960.61', 1, 'Oct 11, 2021'),
 (12, 8, '$787,879.68', 0, 'Jan 27, 2022'),
 (13, 8, '$13,777.71', 1, 'Sep 14, 2022');

-- 3

INSERT INTO Ajuste
VALUES (1, 8, '$912,738.00', null),
(2, 2, null, null),
(3, 9, null, null),
(4, 7, null, null),
(5, 3, null, null),
(6, 4, null, null),
(7, 6, null, null),
(8, 10, null, null),
(9, 1, null, null),
(10, 5, null, null);


-- Limpiar tablas

TRUNCATE TABLE Ajuste;
TRUNCATE TABLE Pago;
DELETE FROM Cliente;

-- Reestablecer indentity en cliente 

DBCC CHECKIDENT (N'Cliente', RESEED, 0);
