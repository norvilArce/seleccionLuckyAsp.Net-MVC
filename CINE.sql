USE master
GO

CREATE DATABASE CINE
GO

USE CINE
GO

CREATE TABLE DIRECTOR(
IdDirector INT IDENTITY(1,1) PRIMARY KEY,
Apellidos VARCHAR(50),
Nombres VARCHAR(50),
NombreCompleto VARCHAR(100),
Pais VARCHAR(40),
FchNac DATE)
GO

CREATE TABLE PELICULA (
IdPelicula INT IDENTITY(1,1) PRIMARY KEY,
IdDirector INT,
Nombre VARCHAR(80),
Genero VARCHAR(40),
Sinopsis VARCHAR(500),
FchEstreno DATE)
GO

ALTER TABLE PELICULA ADD CONSTRAINT FKDirector_Pelicula
FOREIGN KEY (IdDirector) REFERENCES DIRECTOR
GO

-- STORED PROCEDURE

-- DIRECTOR

-- CREATE

CREATE PROCEDURE usp_CrearDirector

@vape VARCHAR(50),
@vnom VARCHAR(50),
@vpais VARCHAR(40),
@vfec_nac DATE

AS

INSERT INTO DIRECTOR(Apellidos, Nombres, NombreCompleto, Pais, FchNac)
VALUES(@vape, @vnom, (@vnom + ' ' + @vape), @vpais, @vfec_nac)
GO

-- READ

CREATE PROCEDURE usp_listarDirectores
AS
SELECT * FROM DIRECTOR
GO

-- UPDATE

CREATE PROCEDURE usp_ActualizarDirector

@vape VARCHAR(50),
@vnom VARCHAR(50),
@vpais VARCHAR(40),
@vfec_nac DATE,
@vid_dir INT

AS

UPDATE DIRECTOR 
SET Apellidos=@vape, Nombres=@vnom, NombreCompleto=(@vnom + ' ' + @vape),
Pais=@vpais, FchNac=@vfec_nac
WHERE IdDirector=@vid_dir
GO

-- DELETE

CREATE PROCEDURE usp_EliminarDirector
@vid_dir INT
AS
DELETE FROM PELICULA WHERE IdDirector=@vid_dir
DELETE FROM DIRECTOR WHERE IdDirector=@vid_dir
GO

--FINDBYID

CREATE PROCEDURE usp_FindDirectorById
@vid_dir INT
AS
SELECT * FROM DIRECTOR WHERE IdDirector=@vid_dir
GO

-- PELICULAS

-- CREATE

CREATE PROCEDURE usp_CrearPelicula

@vid_dir INT,
@vnom VARCHAR(80),
@vgen VARCHAR(40),
@vsin VARCHAR(500),
@vfch_est DATE

AS

INSERT INTO PELICULA(IdDirector, Nombre, Genero, Sinopsis, FchEstreno)
VALUES(@vid_dir, @vnom, @vgen, @vsin, @vfch_est)
GO

-- READ

CREATE PROCEDURE usp_listarPeliculas
AS
SELECT * FROM PELICULA
GO

-- UPDATE

CREATE PROCEDURE usp_ActualizarPelicula

@vid_dir INT,
@vnom VARCHAR(80),
@vgen VARCHAR(40),
@vsin VARCHAR(500),
@vfch_est DATE,
@vid_pel INT
AS
UPDATE PELICULA 
SET IdDirector=@vid_dir, Nombre=@vnom, Genero=@vgen, Sinopsis=@vsin, FchEstreno=@vfch_est
WHERE IdPelicula=@vid_pel
GO

-- DELETE

CREATE PROCEDURE usp_EliminarPelicula
@vid_pel INT
AS
DELETE FROM PELICULA WHERE IdPelicula=@vid_pel
GO

-- PELICULA POR DIRECTOR

CREATE PROCEDURE usp_listarPeliculasPorDirector
@vid_dir INT
AS
SELECT * FROM PELICULA
WHERE IdDirector=@vid_dir
GO

-- FIND BY ID

CREATE PROCEDURE usp_FindPeliculaById
@vid_pel INT
AS
SELECT * FROM PELICULA 
WHERE IdPelicula=@vid_pel
GO
