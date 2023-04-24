
--Creacion de la Base de datos

CREATE DATABASE [Incidentes]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Incidentes', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\Incidentes.mdf' , SIZE = 8192KB , FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Incidentes_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\Incidentes_log.ldf' , SIZE = 8192KB , FILEGROWTH = 65536KB )
 WITH LEDGER = OFF
GO


/*
  Tablas que vayamos creando
*/
--Crear tabla de usuarios
use Incidentes
go

CREATE TABLE [dbo].[usuario](
	[nombre] [varchar](50) NULL,
	[cedula] [varchar](50) NOT NULL,
	[usuario] [varchar](50) NULL,
	[clave] [varchar](50) NULL,
	[perfil] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[cedula] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO


--Tabla Equipos
USE [Incidentes]
GO

CREATE TABLE [dbo].[equipos](
	[placa] [int] NOT NULL,
	[tipo] [varchar](50) NULL,
	[estado] [varchar](50) NULL,
	[ubicacion] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[placa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

--Tabla incidentes
CREATE TABLE dbo.Incidentes(
 NumIncidente	VARCHAR(6) NOT NULL,
 Fecha			DATETIME,
 NivelIncidente	VARCHAR(10),
 Estado         VARCHAR(10),
 NombreCliente	VARCHAR(50),
 Telefono		VARCHAR(9),
 DescError		VARCHAR(MAX)

 Primary Key(NumIncidente)

 )

/*
  Store procedures que vayamos creando.
*/
--SpValidaUsuarios
Use Incidentes
go

CREATE procedure [dbo].[SPUsuario]
	@opc int, @nombre varchar(50)= null, @cedula varchar(50)= null, 
	@usuario varchar(50)= null, @clave varchar(50)=null, @perfil varchar(50)=null
	as

	if @opc = 1
	begin
		select nombre,perfil from usuario where usuario = @usuario and clave = @clave
	end
GO

-- Gestion de equipos
CREATE PROCEDURE [dbo].[SPEquipo]
 @opc int, @placa int= null, @tipo VARCHAR(50)= null, @estado varchar (50)= null, @ubicacion varchar (50)= null
AS

IF @opc =2 
BEGIN 
   INSERT INTO equipos VALUES (@placa, @tipo, @estado, @ubicacion )
end

IF @opc =1 
BEGIN 
   SELECT * FROM equipos 
end

IF @opc = 3 
BEGIN 
  UPDATE equipos set  tipo = @tipo, estado = @estado, ubicacion = @ubicacion where placa = @placa
end

if @opc = 4
BEGIN
   DELETE FROM equipos WHERE placa = @placa
end

GO

--Buscar equipo
CREATE PROCEDURE [dbo].[SPBuscarEquipo]
    @valorBusqueda INT,
    @existeRegistro BIT OUTPUT
AS
BEGIN
    IF EXISTS (SELECT placa FROM [dbo].[equipos] WHERE placa = @valorBusqueda)
        SET @existeRegistro = 1
    ELSE
        SET @existeRegistro = 0
END
GO

-- Gestion de incidentes
CREATE PROCEDURE [dbo].[SPIncidentes]
@opc int,
@fecha datetime = Null,
@numIncidente varchar(6) = Null, 
@nivelIncidente varchar(10) = Null, 
@estado varchar(10) = Null, 
@nombreCliente varchar(50) = Null, 
@telefono varchar(9) = Null, 
@descError varchar(max) = Null
AS


IF @opc =1 
BEGIN 
   SELECT * FROM dbo.Incidentes WHERE Estado = 'Abierto'
end

IF @opc =2
BEGIN 
   SELECT * FROM dbo.Incidentes WHERE Estado = 'Cerrado'
end

IF @opc =3
BEGIN 
   SELECT * FROM dbo.Incidentes
end


IF @opc =4
BEGIN 
   INSERT INTO Incidentes VALUES (@numIncidente,@fecha,@nivelIncidente,@estado,@nombreCliente,@telefono,@descError)
end


IF @opc = 5
BEGIN 
  UPDATE Incidentes set  Fecha = @fecha, NivelIncidente = @nivelIncidente, Estado = @estado, NombreCliente = @nombreCliente, Telefono = @telefono, DescError = @descError
  where NumIncidente = @numIncidente
end
GO

/*
  Insert
*/

USE Incidentes
GO

--Usuario Admin Inicial	
INSERT INTO [dbo].[usuario] VALUES ('Admiministrator','0','Admin','123','Administrador')


--Equipos
  INSERT INTO dbo.equipos
  VALUES    ('36565','Laptop','Activo','Bodega'),
			('23432','Monitor','Activo','Taller'),
			('56623','MAC Book','Activo','Taller'),
			('99999','Impresora','Activo','Piso3'),
			('12331','Scanner','Activo','Piso2'),
			('34423','Teléfono IP','Activo','Lobby'),
			('08901','PC Scritorio','Activo','Bodega')


--Incidentes
INSERT INTO dbo.Incidentes
VALUES    ('L-5555',GETDATE(),'Alto','Abierto','Jose','8720-6365','Dañado'),
		  ('M-9898',GETDATE(),'Bajo','Abierto','Ana','8720-6365','Dañado'),
		  ('M-3232',GETDATE(),'Medio','Abierto','Emma','8720-6365','Dañado'),
		  ('I-8520',GETDATE(),'Alto','Cerrado','Memo','8720-6365','Dañado'),
		  ('S-9513',GETDATE(),'Medio','Abierto','Carlos','8720-6365','Dañado'),
		  ('T-3574',GETDATE(),'Bajo','Abierto','Ivannia','8720-6365','Dañado'),
		  ('P-8645',GETDATE(),'Alto','Cerrado','Cris','8720-6365','Dañado')




--SELECT * FROM [dbo].[usuario]