CREATE DATABASE Finanzas
GO

USE Finanzas
GO

CREATE TABLE Usuarios
(
idUsuario INT IDENTITY PRIMARY KEY,
Usuario VARCHAR(50) NOT NULL,
Contrase�a VARCHAR(15) NOT NULL
)
GO


--CREAMOS LAS TABLAS REQUERIDAS.

CREATE TABLE TablaMaestra
(
idMaestro INT IDENTITY PRIMARY KEY,
Nombre VARCHAR(50) NOT NULL,
Valor MONEY,
VidaUtil MONEY NOT NULL,
FechaInicial DATE NOT NULL,
Periodos MONEY NOT NULL,
UnidadDeTiempo CHAR NOT NULL,
FechaFinal DATE NOT NULL,
Nit INT NOT NULL,
Proveedor VARCHAR(50) NOT NULL,
Cedula INT,
Responsable VARCHAR(50) NOT NULL,
idArea INT NOT NULL
)
GO

CREATE TABLE Areas
(
idArea INT IDENTITY NOT NULL PRIMARY KEY,
Nombre VARCHAR(50) NOT NULL,
Departamento VARCHAR(50) NOT NULL
)
GO

CREATE TABLE Parametros
(
idParametro INT IDENTITY NOT NULL PRIMARY KEY,
Concepto VARCHAR(50) NOT NULL,
UnidadDeMedida VARCHAR(10) NOT NULL,
idMaestro INT NOT NULL
)
GO

CREATE TABLE Periodos
(
idPeriodo INT IDENTITY NOT NULL PRIMARY KEY,
NumeroA�o INT NOT NULL,
A�o INT NOT NULL,
Valor FLOAT NOT NULL,
idParametro INT NOT NULL
)
GO

--ESTABLECEMOS LAS RELACIONES REQUERIDAS.

ALTER TABLE TablaMaestra
ADD FOREIGN KEY(idArea) REFERENCES Areas(idArea) 
GO

ALTER TABLE Parametros
ADD FOREIGN KEY(idMaestro) REFERENCES TablaMaestra(idMaestro) ON DELETE CASCADE
GO

ALTER TABLE Periodos
ADD FOREIGN KEY(idParametro) REFERENCES Parametros(idParametro) ON DELETE CASCADE
GO


--CRUD'S
--CRUD para Areas con procedimientos almacenados.

--insertar Area.
CREATE PROCEDURE SP_InsertarArea
@Nombre VARCHAR(50),
@Departamento VARCHAR(50)
AS
BEGIN
	IF((SELECT COUNT(Nombre) FROM Areas WHERE Nombre=@Nombre)>0)
	BEGIN
		SELECT 'Esta �rea ya se encuentra registrada'
	END
	ELSE
	BEGIN
		INSERT INTO Areas(Nombre,Departamento)
		VALUES (@Nombre,@Departamento)
		SELECT 'Area Registrada con �xito'
	END
END
GO

--Actualizar Area.
CREATE PROCEDURE SP_ActualizarArea
@idArea INT,
@Nombre VARCHAR(50),
@Departamento VARCHAR(50)
AS
BEGIN
	UPDATE Areas
	SET
	Nombre=@Nombre,
	Departamento=@Departamento
	WHERE idArea=@idArea
	SELECT '�rea actualizada'
END
GO

--Eliminar Area.
CREATE PROCEDURE SP_EliminarArea
@idArea INT
AS
BEGIN
	DELETE FROM Areas
	WHERE idArea=@idArea
	SELECT '�rea Eliminada'
END
GO

--Listar Area.
CREATE PROCEDURE SP_ListarArea
AS
BEGIN
	SELECT * FROM Areas
END
GO


--CRUD para Tabla Maestra.

--Crear Tabla Maestra.
CREATE PROCEDURE SP_InsertarTablaMaestra
@Nombre VARCHAR(50),
@Valor MONEY,
@VidaUtil MONEY,
@FechaInicial DATE,
@Periodos MONEY,
@UnidadDeTiempo CHAR,
@FechaFinal DATE,
@Nit INT,
@Proveedor VARCHAR(50),
@Cedula INT,
@Responsable VARCHAR(50),
@idArea INT
AS
BEGIN
	INSERT INTO TablaMaestra(Nombre,Valor,VidaUtil,FechaInicial,Periodos,UnidadDeTiempo,FechaFinal,Nit,Proveedor,Cedula,Responsable,idArea)
	VALUES (@Nombre,@Valor,@VidaUtil,@FechaInicial,@Periodos,@UnidadDeTiempo,@FechaFinal,@Nit,@Proveedor,@Cedula,@Responsable,@idArea)
	SELECT 'Tabla Maestra Creada Correctamente'
END
GO

--Actualizar Tabla Maestra.
CREATE PROCEDURE SP_ActualizarTablaMaestra
@idMaestro INT,
@Nombre VARCHAR(50),
@Valor MONEY,
@VidaUtil MONEY,
@FechaInicial DATE,
@Periodos MONEY,
@UnidadDeTiempo CHAR,
@FechaFinal DATE,
@Nit INT,
@Proveedor VARCHAR(50),
@Cedula INT,
@Responsable VARCHAR(50),
@idArea INT
AS
BEGIN
	UPDATE TablaMaestra
	SET
		Nombre=@Nombre,
		Valor=@Valor,
		VidaUtil=@VidaUtil,
		FechaInicial=@FechaInicial,
		Periodos=@Periodos,
		UnidadDeTiempo=@UnidadDeTiempo,
		FechaFinal=@FechaFinal,
		Nit=@Nit,
		Proveedor=@Proveedor,
		Cedula=@Cedula,
		Responsable=@Responsable,
		idArea=@idArea
	WHERE idMaestro=@idMaestro
	SELECT 'Tabla Maestra Actualizada'
END
GO

--Eliminar Tabla Maestra.
CREATE PROCEDURE SP_EliminarTablaMaestra
@idMaestro INT
AS
BEGIN
	DELETE FROM TablaMaestra
	WHERE idMaestro=@idMaestro
	SELECT 'Tabla Maestra Eliminada'
END
GO

--LIstar Tabla Maestra.
CREATE PROCEDURE SP_ListarTablaMaestra
AS
BEGIN
	SELECT * FROM TablaMaestra
END
GO

--CRUD para par�metros.

--insertar par�metro.
CREATE PROCEDURE SP_insertarParametro
@Concepto VARCHAR(50),
@UnidadDeMedida VARCHAR(10),
@idMaestro INT
AS
BEGIN
	INSERT INTO Parametros(Concepto,UnidadDeMedida,idMaestro)
	VALUES (@Concepto,@UnidadDeMedida,@idMaestro)
	SELECT 'P�rametro Insertado Correctamente.'
END
GO

--Actualizar par�metro.
CREATE PROCEDURE SP_ActualizarParametro
@idParametro INT,
@Concepto VARCHAR(50),
@UnidadDeMedida VARCHAR(10)
AS
BEGIN
	UPDATE Parametros
	SET
		Concepto=@Concepto,
		UnidadDeMedida=@UnidadDeMedida
	WHERE idParametro=@idParametro
	SELECT 'Par�metro Actualizado.'
END
GO

--Eliminar par�metro.
CREATE PROCEDURE SP_EliminarParametro
@idParametro INT
AS
BEGIN
	DELETE FROM Parametros
	WHERE idParametro=@idParametro
	SELECT 'Par�metro Eliminado Correctamente.'
END
GO
--Listar Par�metros.
CREATE PROCEDURE SP_ListarParametro
AS
BEGIN
	SELECT * FROM Parametros
END
GO


----CRUD para Periodos.

--Insertar Periodo.
CREATE PROCEDURE SP_InsertarPeriodo
@NumeroA�o INT,
@A�o INT,
@Valor FLOAT,
@idParametro INT
AS
BEGIN
	INSERT INTO Periodos(NumeroA�o,A�o,Valor,idParametro)
	VALUES (@NumeroA�o,@A�o,@Valor,@idParametro)
	SELECT 'Periodo Insertado'
END
GO
--Actualizar Periodo.
CREATE PROCEDURE SP_ActualizarPeriodo
@idPeriodo INT,
@NumeroA�o INT,
@A�o INT,
@Valor FLOAT
AS
BEGIN
	UPDATE Periodos
	SET
		NumeroA�o=@NumeroA�o,
		A�o=@A�o,
		Valor=@Valor
	WHERE idPeriodo=@idPeriodo
	SELECT 'Periodo Actualizado Correctamente'
END
GO
--Eliminar Periodo
CREATE PROCEDURE SP_EliminarPeriodo
@idPeriodo INT
AS
BEGIN
	DELETE FROM Periodos
	WHERE idPeriodo=@idPeriodo
	SELECT 'Periodo Eliminado Correctamente.'
END
GO

--Listar Periodo.
CREATE PROCEDURE SP_ListarPeriodo
@idPeriodo INT
AS
BEGIN
	SELECT * FROM Periodos WHERE idPeriodo=@idPeriodo
END
GO

-----CRUD PARA LOS USUARIOS

--INSERTAR
CREATE PROCEDURE SP_InsertarUsuario
@Usuario VARCHAR(50),
@Contrase�a VARCHAR(15)
AS
BEGIN
	INSERT INTO Usuarios(Usuario,Contrase�a)
	VALUES (@Usuario,@Contrase�a)
	SELECT 'Usuario registrado con exito'
END
GO

--Actualizar
CREATE PROCEDURE SP_ActualizarUsuario
@idUsuario INT,
@Usuario VARCHAR(50),
@Contrase�a VARCHAR(15)
AS
BEGIN
	UPDATE Usuarios
	SET
		Usuario=@idUsuario,
		Contrase�a=@Contrase�a
	WHERE idUsuario=@idUsuario
	SELECT 'Usuario actualizado correctamente.'
END
GO

--Eliminar
CREATE PROCEDURE SP_EliminarUsuario
@idUsuario INT
AS
BEGIN	
	DELETE FROM Usuarios
	WHERE idUsuario=idUsuario
	SELECT 'Usuario Eliminado con exito.'
END
GO

--Listar
CREATE PROCEDURE SP_ListarUsuario
AS
BEGIN
	SELECT * FROM Usuarios
END
GO
