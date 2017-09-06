﻿CREATE TABLE [dbo].[R2PBParametro](
	[IdParametro] [int] IDENTITY(1,1) NOT NULL,
	[IdMetodo] [int] NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Tipo] [varchar](50) NOT NULL,
	[Estatico] [bit]NOT NULL,
 CONSTRAINT [PK_R2PBParametro] PRIMARY KEY CLUSTERED 
(
	[IdParametro] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[R2PBParametro]  WITH CHECK ADD  CONSTRAINT [FK_R2PBParametro_R2PBMetodo] FOREIGN KEY([IdMetodo])
REFERENCES [dbo].[R2PBMetodo] ([IdMetodo])