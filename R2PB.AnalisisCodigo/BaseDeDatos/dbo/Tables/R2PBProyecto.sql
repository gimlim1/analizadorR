CREATE TABLE [dbo].[R2PBProyecto](
	[IdProyecto] [int] IDENTITY(1,1) NOT NULL,
	[IdPaquete] [int] NOT NULL,
	[NombreProyecto] [varchar](50) NOT NULL,
	[Lenguaje] [varchar](10) NOT NULL,
	[IdentificadorProyecto] [varchar](50) NOT NULL,
 CONSTRAINT [PK_R2PBProyecto] PRIMARY KEY CLUSTERED 
(
	[IdProyecto] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[R2PBProyecto]  WITH CHECK ADD  CONSTRAINT [FK_R2PBProyecto_R2PBPaquete] FOREIGN KEY([IdPaquete])
REFERENCES [dbo].[R2PBPaquete] ([IdPaquete])