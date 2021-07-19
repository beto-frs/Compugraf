USE [master]
GO

CREATE DATABASE [Compugraf]
 
 GO

USE Compugraf
CREATE TABLE [dbo].[Usuarios](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CPF] [varchar](14) NOT NULL,
	[Nome] [varchar](100) NOT NULL,
	[Sobrenome] [varchar](100) NOT NULL,
	[Nacionalidade] [varchar](100) NOT NULL,
	[CEP] [varchar](9) NOT NULL,
	[Estado] [varchar](2) NOT NULL,
	[Cidade] [varchar](100) NOT NULL,
	[Logradouro] [varchar](100) NOT NULL,
	[Email] [varchar](100) NOT NULL,
	[Telefone] [varchar](100) NOT NULL
) ON [PRIMARY]
GO





