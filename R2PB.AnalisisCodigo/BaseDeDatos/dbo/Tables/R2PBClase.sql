CREATE TABLE [dbo].[R2PBClase](
	[IdClase] [int] IDENTITY(1,1) NOT NULL,
	[IdProyecto] [int] NOT NULL,
	[Visibilidad] [varchar](50) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Tipo] [smallint] NOT NULL,
	[NameSpace] [varchar](50) NOT NULL,
 CONSTRAINT [PK_R2PBClase] PRIMARY KEY CLUSTERED 
(
	[IdClase] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[R2PBClase]  WITH CHECK ADD  CONSTRAINT [FK_R2PBClase_R2PBProyecto] FOREIGN KEY([IdProyecto])
REFERENCES [dbo].[R2PBProyecto] ([IdProyecto])