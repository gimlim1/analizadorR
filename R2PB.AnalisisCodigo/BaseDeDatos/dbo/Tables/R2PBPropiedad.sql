CREATE TABLE [dbo].[R2PBPropiedad](
	[IdPropiedad] [int] IDENTITY(1,1) NOT NULL,
	[IdClase] [int] NOT NULL,
	[Visibilidad] [varchar](50) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Tipo] [varchar](50) NOT NULL,
	[Estatico] [bit]NOT NULL,
 CONSTRAINT [PK_R2PBPropiedad] PRIMARY KEY CLUSTERED 
(
	[IdPropiedad] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[R2PBPropiedad]  WITH CHECK ADD  CONSTRAINT [FK_R2PBPropiedad_R2PBClase] FOREIGN KEY([IdClase])
REFERENCES [dbo].[R2PBClase] ([IdClase])