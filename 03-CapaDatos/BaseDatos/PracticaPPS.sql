CREATE DATABASE PracticaPPS;
GO

USE PracticaPPS;
GO

CREATE TABLE Socios (
Id_Socio int primary key identity (1,1),
Nombre VARCHAR (60),
Apellido VARCHAR (60),
Dni VARCHAR (60),
Telefono VARCHAR (60),
FechaIngreso smalldatetime,
Activo Bit default 1
);

ALTER TABLE Socios alter column FechaIngreso Date; 
UPDATE Socios set Activo = 0, FechaIngreso = '' where Id_Socio = 8;


INSERT INTO Socios (Nombre, Apellido, Dni, Telefono, FechaIngreso) VALUES ('Exequiel','Nuñez','34910234','3813567876', '02/06/2025');
select * from Socios where Activo = 1;
UPDATE Socios set Nombre  = 'NICOLAS',Apellido = 'RODRIGUEZ', Dni = '43567880',Telefono = '381456758',FechaIngreso = '2005/02/07' WHERE Id_Socio= 8;
 

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


INSERT INTO Entrenadores (Nombre, Apellido, Dni, Domicilio, Telefono) VALUES ('Lionel','Messi','34910234','Barcelona','3813512345'),('cristiano','ronaldo','34908456','Madrid','381456987');
Select Nombre as 'Nombre Entrenador',Apellido,Dni from Entrenadores;

INSERT INTO Entrenadores (Nombre, Apellido, Dni, Domicilio, Telefono) VALUES ('angel','dimaria','87897664','Rosario','381345758'),('Viviana','Videla','43897567','Las heras 1500','3813566774');
select * from Entrenadores where Activo = 1;

DELETE from Entrenadores where Id_Entrenador = 8;
UPDATE Entrenadores SET Domicilio = '', Telefono = '' where Id_Entrenador = 3;
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

INSERT INTO Secretarios (Usuario, Contrasena) VALUES ('admin', '1234');

DELETE FROM Socios WHERE Id_Socio = 11;