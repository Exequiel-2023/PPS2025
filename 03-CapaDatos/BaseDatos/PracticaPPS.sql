CREATE DATABASE PracticaPPS;
GO

USE PracticaPPS;
GO

CREATE TABLE Socios (
Id_Socio int primary key identity (1,1),
NombreCompleto VARCHAR (60),
Dni VARCHAR (60),
Email varchar (100),
Clase VARCHAR (60),
FechaIngreso Date,
ProximoVencimiento Date,
Estado VARCHAR (60),
ImagenURL VARCHAR (1000)
);

ALTER TABLE Socios alter column FechaIngreso Date; 

UPDATE Socios set Activo = 0, FechaIngreso = '' where Id_Socio = 8;
ALTER TABLE Socios add Email varchar (100)
ALTER TABLE Socios add ProximoVencimiento DATE;
ALTER TABLE Socios add ImagenURL VARCHAR (1000);
ALTER TABLE Socios add Clase VARCHAR (60);
DELETE FROM Socios WHERE Id_Socio = 53; 

ALTER TABLE Socios  add Estado varchar (60) not null default 'Activo';
ALTER TABLE Socios ALTER COLUMN Estado VARCHAR(60) not null;

INSERT INTO Socios (Nombre, Apellido, Dni, Telefono, FechaIngreso) VALUES ('Exequiel','Nu�ez','34910234','3813567876', '02/06/2025');
select * from Socios where Activo = 1;
select * from Socios where Activo = 0;
UPDATE Socios set NombreCompleto = 'Julian Alvarez' WHERE Id_Socio = 8;
UPDATE Socios set Clase = 'Spining' WHERE Id_Socio = 5;
UPDATE Socios set ImagenURL = 'C:\Users\lrmon\desktop\ImagenesSociosURL\TevezPNG.png' WHERE Id_Socio = 25;

SELECT Id_Socio, NombreCompleto, Dni, Email, Clase, FechaIngreso,ProximoVencimiento,Estado FROM Socios;

DELETE from Socios where Estado = 'Inactivo' and Id_Socio = 72;

DELETE FROM Socios WHERE (Estado IS NULL OR Estado = '') AND Id_Socio = 29;

SELECT * FROM Socios WHERE Estado = 'Activo' AND Id_Socio = 1;

ALTER TABLE Socios DROP COLUMN Telefono;
ALTER TABLE Socios DROP COLUMN Apellido;

SELECT CONCAT (Nombre,'',Apellido) AS NombreCompleto From Socios;
EXEC SP_RENAME 'Socios.Nombre', 'NombreCompleto', 'Column';


SELECT * FROM Socios WHERE Dni LIKE '%78%' AND Activo = 0;
SELECT * FROM Socios WHERE Nombre LIKE '%Felipe%' AND Activo = 1;



 
UPDATE Socios set Email = 'nzvarez833@gmail.com' WHERE Id_Socio= 17;
UPDATE Socios set Email = 'FelipeN@gmailcom' WHERE Id_Socio= 18;
UPDATE Socios set Email = 'EstelitaN@gmail.com' WHERE Id_Socio= 20;

SELECT Id_Socio , Email from Socios where activo = 0;  

INSERT INTO Socios (Nombre, Apellido, Dni, Telefono, FechaIngreso) VALUES ('','','','', '');


CREATE TABLE Entrenadores (
Id_Entrenador int primary key identity (1,1),
Nombre VARCHAR (60),
Apellido VARCHAR (60),
Dni VARCHAR (60),
Domicilio VARCHAR (60),
Telefono VARCHAR (60),
);

alter table Entrenadores add  Activo bit default 1;
ALTER TABLE Socios alter column FechaIngreso Date; 

UPDATE Entrenadores set NombreCompleto = 'Lionel Messi' WHERE Id_Entrenador = 1;
EXEC SP_RENAME 'Entrenadores.Nombre', 'Clase', 'Column';

SELECT name 
FROM sys.default_constraints 
WHERE parent_object_id = OBJECT_ID('Entrenadores') 
  AND COL_NAME(parent_object_id, parent_column_id) = 'Estado';

ALTER TABLE Entrenadores DROP COLUMN Activo;

ALTER TABLE Entrenadores DROP CONSTRAINT DF__Entrenado__Estad__3A4CA8FD;

DF__Entrenado__Estad__3A4CA8FD
ALTER TABLE Entrenadores  add Estado varchar (60) not null default 'Activo';

INSERT INTO Entrenadores (Nombre, Apellido, Dni, Domicilio, Telefono) VALUES ('Lionel','Messi','34910234','Barcelona','3813512345'),('cristiano','ronaldo','34908456','Madrid','381456987');
Select Nombre as 'Nombre Entrenador',Apellido,Dni from Entrenadores;

INSERT INTO Entrenadores (Nombre, Apellido, Dni, Domicilio, Telefono) VALUES ('angel','dimaria','87897664','Rosario','381345758'),('Viviana','Videla','43897567','Las heras 1500','3813566774');
select * from Entrenadores where Activo = 1;

SELECT Id_Entrenador, NombreCompleto, Dni, Domicilio, Clase, Telefono, Estado FROM Entrenadores;

DELETE from Entrenadores where Id_Entrenador = 8;

DELETE from Entrenadores WHERE Id_Entrenador > 3;

UPDATE Entrenadores SET NombreCompleto = 'Rodrigo De Paul', Clase = 'Sppining' where Id_Entrenador = 3;

UPDATE Entrenadores SET Activo = 0 WHERE Id_Entrenador >=1 and Id_Entrenador <=6;
UPDATE Entrenadores SET Activo = 0 WHERE Id_Entrenador = 11;

UPDATE Entrenadores set Activo = 1, Domicilio = '', Telefono = '' where Id_Entrenador = 8;

CREATE TABLE Socio_Entrenador (
Id_Socio_Entrenador int primary key identity (1,1),
Id_Socio INT,
Id_Entrenador INT,
Clase VARCHAR (60),
Constraint fk_Socio_Entrenador_Socio foreign key (Id_Socio) references Socios,
constraint fk_Socio_Entrenador_Entrenador foreign key (Id_Entrenador) references Entrenadores
);

insert into Socio_Entrenador (Id_Socio, Id_Entrenador,Clase) values (1,2,'Zumba');

Select * from Socio_Entrenador;


CREATE TABLE Secretarios (
Id_Secretario int primary key identity (1,1),
Usuario varchar (60),
Contrasena varchar (60)
);

SELECT * FROM Secretarios;

CREATE TABLE UsuarioLogin
(
  Id_Secretario int primary key identity (1,1),
  Usuario varchar (60),
  Contrasena varchar (60),
  Nombre varchar (60)
)
select * from UsuarioLogin
INSERT INTO UsuarioLogin VALUES ('jefe1','1234','Josefina')
INSERT INTO UsuarioLogin VALUES ('secre1','56','Carlos')
INSERT INTO UsuarioLogin VALUES ('secre2','78','Stefan')

UPDATE UsuarioLogin SET Usuario = 'Jefe' where Id_Secretario = 1;
UPDATE UsuarioLogin SET Usuario = 'Secretario' where Id_Secretario >= 2 ;

Exec SP_RENAME 'UsuarioLogin.Nombre', 'NombreCompleto', 'COLUMN';

ALTER TABLE UsuarioLogin ADD Documento VARCHAR (60), Domicilio VARCHAR (60), Telefono VARCHAR (60);
UPDATE UsuarioLogin SET Documento = '38785374', Domicilio = '12 de octubre 749', Telefono = '3817564837' where Id_Secretario = 3;


select * from UsuarioLogin where Usuario = 'jefe1' and Contrasena = '1234';
select Id_Secretario, NombreCompleto, Documento, Domicilio, Telefono from UsuarioLogin where Id_Secretario > 1;

UPDATE UsuarioLogin SET Domicilio = 'Los Bulacios', Telefono = '3812765234' where Id_Secretario = 8;

INSERT INTO UsuarioLogin Values ('Secretario','00','Julio Cesar', '23890567','Lomas de Tafi', '3813576932')

Delete From UsuarioLogin where Id_Secretario = 4;


INSERT INTO Secretarios (Usuario, Contrasena) VALUES ('admin', '1234');

DELETE FROM Socios WHERE Id_Socio = 11;

SELECT * FROM Secretarios;


-- nombre 3 usuario 1

select Count(Id_Secretario) as 'Cantidad de Secretarios' From Secretarios where Usuario = 'admin' and Contrasena = 1234;


CREATE TABLE Inventario (
Id_Inventario INT PRIMARY KEY IDENTITY (1,1),
Maquina VARCHAR (60),
CantidadSucursalNorte INT,
CantidadSucursalSur INT
);

SELECT * FROM Inventario;

INSERT INTO Inventario (Maquina,CantidadSucursalNorte,CantidadSucursalSur) VALUES ('Maquina Corredora', 10 , 5);
INSERT INTO Inventario (Maquina,CantidadSucursalNorte,CantidadSucursalSur) VALUES ('Pesas 2Kg', 100, 60), ('Maquina Polea', 4, 2), ('Prensa', 4, 3), ('Maquina Hack', 3, 4), ('Bicleta estatica', 6, 8);


CREATE TABLE HorariosClases (
Id_HorarioClase INT PRIMARY KEY IDENTITY (1,1),
Clase VARCHAR (60),
Horario VARCHAR (60),
Dias VARCHAR (60),
Sede VARCHAR (60)
);

Alter Table HorariosClases ADD Sede VARCHAR (60);
SELECT * FROM HorariosClases;
INSERT INTO HorariosClases (Clase, Horario, Dias, Sede) Values ('Funcional', '15:30', 'Miercoles', 'Amarillo');
INSERT INTO HorariosClases (Clase, Horario, Dias, Sede) Values ('Aerolocal', '18:30', 'Miercoles', 'Roja'),('Aerolocal', '18:30', 'Viernes', 'Roja');
INSERT INTO HorariosClases (Clase, Horario, Dias, Sede) Values ('Zumba', '20:30', 'Lunes', 'Amarilla'),('Zumba', '20:30', 'Miercoles', 'Amarilla'),('Zumba', '20:30', 'Viernes', 'Amarilla')
INSERT INTO HorariosClases (Clase, Horario, Dias, Sede) Values ('Boxeo', '11:30', 'Lunes', 'Amarilla'),('Boxeo', '21:30', 'Martes', 'Amarilla'),('Boxeo', '11:30', 'Miercoles', 'Amarilla'),('Boxeo', '21:30', 'Jueves', 'Amarilla'),('Boxeo', '11:30', 'Viernes', 'Amarilla')
SELECT Clase,Horario,Dias,Sede FROM HorariosClases;