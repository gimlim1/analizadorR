﻿CREATE TABLE [dbo].[R2PBPaquete](
	[IdPaquete] [int] IDENTITY(1,1) NOT NULL,
	[NombrePaquete] [varchar](50) NOT NULL,
	[IdentificadorPaquete] [varchar](50) NOT NULL,
 CONSTRAINT [PK_R2PBPaquete] PRIMARY KEY CLUSTERED 
(
	[IdPaquete] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]