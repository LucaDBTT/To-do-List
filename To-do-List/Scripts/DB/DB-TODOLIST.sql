USE master
CREATE DATABASE TODOLIST
GO
USE TODOLIST
GO
CREATE TABLE Usuario(
Id int identity(1,1) primary key,
NombreUsuario varchar(30) not null,
Contraseña varchar(255) not null,
TipoUsuario int not null,
Estado bit not null
);
GO
CREATE TABLE Tag(
Id int identity(1,1) primary key,
Descripcion varchar(50) not null,
Estado bit not null
);
GO
CREATE TABLE Reminder(
Id int identity(1,1) primary key,
Descripcion varchar(50) not null,
FechaHora datetime not null
);
GO
CREATE TABLE Categoria(
Id int identity(1,1) primary key,
NombreCategoria varchar(30) not null,
Descripcion varchar(50) not null,
Estado bit not null
);
GO 
CREATE TABLE Tarea(
Id int identity(1,1) primary key,
Descripcion varchar(1000) not null,
FechaCreacion datetime default getdate(),
FechaVencimiento datetime not null,
Prioridad varchar(20) not null, --Alta, Media, Baja
Id_usuario INT NOT NULL,
Id_etiqueta INT NOT NULL,  -- Clave foránea para Tag
Id_categoria INT NOT NULL,  -- Clave foránea para Categoria
Id_reminder INT NOT NULL,  -- Clave foránea para Reminder
EstaCompletada BIT NOT NULL,
FOREIGN KEY (Id_usuario) REFERENCES Usuario(Id) ON DELETE CASCADE,
FOREIGN KEY (Id_etiqueta) REFERENCES Tag(Id),
FOREIGN KEY (Id_categoria) REFERENCES Categoria(Id) ,
FOREIGN KEY (Id_reminder) REFERENCES Reminder(Id)
);