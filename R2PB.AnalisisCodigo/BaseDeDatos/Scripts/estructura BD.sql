USE [AnalisisCodigo]
GO

IF OBJECT_ID('dbo.R2PBPropiedad', 'U') IS NOT NULL 
  DROP TABLE dbo.R2PBPropiedad;

IF OBJECT_ID('dbo.R2PBHerencia', 'U') IS NOT NULL 
  DROP TABLE dbo.R2PBHerencia;

IF OBJECT_ID('dbo.R2PBUsing', 'U') IS NOT NULL 
  DROP TABLE dbo.R2PBUsing;

IF OBJECT_ID('dbo.R2PBControl', 'U') IS NOT NULL 
  DROP TABLE dbo.R2PBControl;

IF OBJECT_ID('dbo.R2PBParametroModificador', 'U') IS NOT NULL 
  DROP TABLE dbo.R2PBParametroModificador; 
 
IF OBJECT_ID('dbo.R2PBParametro', 'U') IS NOT NULL 
  DROP TABLE dbo.R2PBParametro; 

IF OBJECT_ID('dbo.R2PBMetodo', 'U') IS NOT NULL 
  DROP TABLE dbo.R2PBMetodo; 

IF OBJECT_ID('dbo.R2PBClase', 'U') IS NOT NULL 
  DROP TABLE dbo.R2PBClase; 

IF OBJECT_ID('dbo.R2PBProyecto', 'U') IS NOT NULL 
  DROP TABLE dbo.R2PBProyecto; 

IF OBJECT_ID('dbo.R2PBRepositorio', 'U') IS NOT NULL 
  DROP TABLE dbo.R2PBRepositorio; 

IF OBJECT_ID('dbo.R2PBPaquete', 'U') IS NOT NULL 
  DROP TABLE dbo.R2PBPaquete; 

IF OBJECT_ID('dbo.R2PBBitacora', 'U') IS NOT NULL 
  DROP TABLE dbo.R2PBBitacora; 

CREATE TABLE [dbo].[R2PBPaquete](
	[IdPaquete] [int] IDENTITY(1,1) NOT NULL,
	[NombrePaquete] [varchar](2500) NOT NULL,
	[IdentificadorPaquete] [varchar](2500) NOT NULL,
 CONSTRAINT [PK_R2PBPaquete] PRIMARY KEY CLUSTERED 
(
	[IdPaquete] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

CREATE TABLE [dbo].[R2PBProyecto](
	[IdProyecto] [int] IDENTITY(1,1) NOT NULL,
	[IdPaquete] [int] NOT NULL,
	[NombreProyecto] [varchar](2500) NOT NULL,
	[Lenguaje] [varchar](10) NOT NULL,
	[IdentificadorProyecto] [varchar](2500) NOT NULL,
 CONSTRAINT [PK_R2PBProyecto] PRIMARY KEY CLUSTERED 
(
	[IdProyecto] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

ALTER TABLE [dbo].[R2PBProyecto]  WITH CHECK ADD  CONSTRAINT [FK_R2PBProyecto_R2PBPaquete] FOREIGN KEY([IdPaquete])
REFERENCES [dbo].[R2PBPaquete] ([IdPaquete])
GO

CREATE TABLE [dbo].[R2PBClase](
	[IdClase] [int] IDENTITY(1,1) NOT NULL,
	[IdProyecto] [int] NOT NULL,
	[IdPaquete] [int] NOT NULL,
	[Visibilidad] [varchar](50) NOT NULL,
	[Nombre] [varchar](2500) NOT NULL,
	[Tipo] [smallint] NOT NULL,
	[NameSpace] [varchar](2500) NULL,
    [LineaComienzo] [int]NOT NULL,
	[LineaFinal] [int]NOT NULL,
 CONSTRAINT [PK_R2PBClase] PRIMARY KEY CLUSTERED 
(
	[IdClase] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

ALTER TABLE [dbo].[R2PBClase]  WITH CHECK ADD  CONSTRAINT [FK_R2PBClase_R2PBProyecto] FOREIGN KEY([IdProyecto])
REFERENCES [dbo].[R2PBProyecto] ([IdProyecto])
GO


CREATE TABLE [dbo].[R2PBMetodo](
	[IdMetodo] [int] IDENTITY(1,1) NOT NULL,
    [IdProyecto] [int] NOT NULL,
	[IdPaquete] [int] NOT NULL,
	[IdClase] [int] NOT NULL,
	[Visibilidad] [varchar](50) NOT NULL,
	[Nombre] [varchar](2500) NOT NULL,
	[Retorno] [varchar](50) NOT NULL,
    [LineaComienzo] [int]NOT NULL,
	[LineaFinal] [int]NOT NULL,
 CONSTRAINT [PK_R2PBMetodo] PRIMARY KEY CLUSTERED 
(
	[IdMetodo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

ALTER TABLE [dbo].[R2PBMetodo]  WITH CHECK ADD  CONSTRAINT [FK_R2PBMetodo_R2PBClase] FOREIGN KEY([IdClase])
REFERENCES [dbo].[R2PBClase] ([IdClase])
GO

CREATE TABLE [dbo].[R2PBParametro](
	[IdParametro] [int] IDENTITY(1,1) NOT NULL,
	[IdMetodo] [int] NOT NULL,
	[IdProyecto] [int] NOT NULL,
	[IdPaquete] [int] NOT NULL,
	[IdClase] [int] NOT NULL,
	[Nombre] [varchar](2500) NOT NULL,
	[Tipo] [varchar](350) NOT NULL,
	[Estatico] [bit]NOT NULL,
 CONSTRAINT [PK_R2PBParametro] PRIMARY KEY CLUSTERED 
(
	[IdParametro] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

ALTER TABLE [dbo].[R2PBParametro]  WITH CHECK ADD  CONSTRAINT [FK_R2PBParametro_R2PBMetodo] FOREIGN KEY([IdMetodo])
REFERENCES [dbo].[R2PBMetodo] ([IdMetodo])
GO

CREATE TABLE [dbo].[R2PBParametroModificador](
	[IdModificador] [int] IDENTITY(1,1) NOT NULL,
	[IdParametro] [int] NOT NULL,
	[Modificador] [varchar](50) NOT NULL,
 CONSTRAINT [PK_R2PBParametroModificador] PRIMARY KEY CLUSTERED 
(
	[IdModificador] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

ALTER TABLE [dbo].[R2PBParametroModificador]  WITH CHECK ADD  CONSTRAINT [FK_R2PBParametroModificador_R2PBParametro] FOREIGN KEY([IdParametro])
REFERENCES [dbo].[R2PBParametro] ([IdParametro])
GO


CREATE TABLE [dbo].[R2PBControl](
	[IdControl] [int] IDENTITY(1,1) NOT NULL,
	[IdMetodo] [int] NOT NULL,
    [IdProyecto] [int] NOT NULL,
	[IdPaquete] [int] NOT NULL,
	[IdClase] [int] NOT NULL,
	[Nombre] [varchar](2500) NOT NULL,
	[Tipo] [int]NOT NULL,
	[LineaComienzo] [int]NOT NULL,
	[LineaFinal] [int]NOT NULL,
 CONSTRAINT [PK_R2PBControl] PRIMARY KEY CLUSTERED 
(
	[IdControl] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

ALTER TABLE [dbo].[R2PBControl]  WITH CHECK ADD  CONSTRAINT [FK_R2PBControlo_R2PBMetodo] FOREIGN KEY([IdMetodo])
REFERENCES [dbo].[R2PBMetodo] ([IdMetodo])
GO

CREATE TABLE [dbo].[R2PBUsing](
	[IdUsing] [int] IDENTITY(1,1) NOT NULL,
	[IdClase] [int] NOT NULL,
	[IdProyecto] [int] NOT NULL,
	[IdPaquete] [int] NOT NULL,
	[UsingDeclarado] [varchar](50) NOT NULL,
 CONSTRAINT [PK_R2PBUsing] PRIMARY KEY CLUSTERED 
(
	[IdUsing] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

ALTER TABLE [dbo].[R2PBUsing]  WITH CHECK ADD  CONSTRAINT [FK_R2PBUsing_R2PBClase] FOREIGN KEY([IdClase])
REFERENCES [dbo].[R2PBClase] ([IdClase])
GO

CREATE TABLE [dbo].[R2PBHerencia](
	[IdHerencia] [int] IDENTITY(1,1) NOT NULL,
	[IdClase] [int] NOT NULL,
	[IdProyecto] [int] NOT NULL,
	[IdPaquete] [int] NOT NULL,
	[HerenciaDeclarada] [varchar](2500) NOT NULL,
 CONSTRAINT [PK_R2PBHerencia] PRIMARY KEY CLUSTERED 
(
	[IdHerencia] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

ALTER TABLE [dbo].[R2PBHerencia]  WITH CHECK ADD  CONSTRAINT [FK_R2PBHerencia_R2PBClase] FOREIGN KEY([IdClase])
REFERENCES [dbo].[R2PBClase] ([IdClase])
GO

CREATE TABLE [dbo].[R2PBPropiedad](
	[IdPropiedad] [int] IDENTITY(1,1) NOT NULL,
	[IdClase] [int] NOT NULL,
    [IdProyecto] [int] NOT NULL,
	[IdPaquete] [int] NOT NULL,
	[Visibilidad] [varchar](50) NOT NULL,
	[Nombre] [varchar](2500) NOT NULL,
	[Tipo] [varchar](350) NOT NULL,
	[Estatico] [bit]NOT NULL,
 CONSTRAINT [PK_R2PBPropiedad] PRIMARY KEY CLUSTERED 
(
	[IdPropiedad] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

ALTER TABLE [dbo].[R2PBPropiedad]  WITH CHECK ADD  CONSTRAINT [FK_R2PBPropiedad_R2PBClase] FOREIGN KEY([IdClase])
REFERENCES [dbo].[R2PBClase] ([IdClase])
GO

CREATE TABLE [dbo].[R2PBBitacora](
	[IdBitacora] [int] IDENTITY(1,1) NOT NULL,
	[IdSolucion][varchar](2500) NULL,
	[StackTrace] nvarchar(max) NULL,
	[InformacionExepcion] nvarchar(max) NULL,
	[Mensaje] nvarchar(max) NULL,
	[Componente] [int] NOT NULL,
 CONSTRAINT [PK_R2PBBitacora] PRIMARY KEY CLUSTERED 
(
	[IdBitacora] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

CREATE TABLE [dbo].[R2PBRepositorio](
	[IdRepositorio] [int] IDENTITY(1,1) NOT NULL,
	[IdPaquete][int] NULL,
	[NombreRepositorio] [varchar](2500) NULL,
	[NombreAutorRepositorio] [varchar](2500) NULL,
	[AutorCommit] [varchar](2500) NULL,
	[Año] [int] NOT NULL,
	[Mes] [int] NOT NULL,
	[Dia] [int] NOT NULL,
	[Hora] [int] NOT NULL,
	[Segundo] [int] NOT NULL,
	[Minuto] [int] NOT NULL,
	[FechaCompleta] [Datetime] NOT NULL,
	[Hash] nvarchar(max) NULL,
 CONSTRAINT [PK_R2PBRepositorio] PRIMARY KEY CLUSTERED 
(
	[IdRepositorio] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
