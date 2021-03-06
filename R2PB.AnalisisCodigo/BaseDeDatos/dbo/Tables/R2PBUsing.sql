﻿CREATE TABLE [dbo].[R2PBUsing](
	[IdUsing] [int] IDENTITY(1,1) NOT NULL,
	[IdClase] [int] NOT NULL,
	[UsingDeclarado] [varchar](50) NOT NULL,
 CONSTRAINT [PK_R2PBUsing] PRIMARY KEY CLUSTERED 
(
	[IdUsing] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[R2PBUsing]  WITH CHECK ADD  CONSTRAINT [FK_R2PBUsing_R2PBClase] FOREIGN KEY([IdClase])
REFERENCES [dbo].[R2PBClase] ([IdClase])