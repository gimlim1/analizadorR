CREATE TABLE [dbo].[R2PBParametroModificador](
	[IdModificador] [int] IDENTITY(1,1) NOT NULL,
	[IdParametro] [int] NOT NULL,
	[Modificador] [varchar](50) NOT NULL,
 CONSTRAINT [PK_R2PBParametroModificador] PRIMARY KEY CLUSTERED 
(
	[IdModificador] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[R2PBParametroModificador]  WITH CHECK ADD  CONSTRAINT [FK_R2PBParametroModificador_R2PBParametro] FOREIGN KEY([IdParametro])
REFERENCES [dbo].[R2PBParametro] ([IdParametro])