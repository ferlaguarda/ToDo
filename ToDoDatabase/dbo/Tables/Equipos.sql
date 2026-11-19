CREATE TABLE [dbo].[Equipos] (
    [Id]             INT              IDENTITY (1, 1) NOT NULL,
    [Nombre]         VARCHAR (100)    NOT NULL,
    [MaxIntegrantes] SMALLINT         CONSTRAINT [DF_Equipos_MaxIntegrantes] DEFAULT ((0)) NOT NULL,
    [IdManager]      INT              NULL,
    [AccountId]      UNIQUEIDENTIFIER NULL,
    CONSTRAINT [PK_Equipos] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Equipos_Cuenta] FOREIGN KEY ([AccountId]) REFERENCES [dbo].[Cuenta] ([Id]),
    CONSTRAINT [FK_Equipos_Usuario] FOREIGN KEY ([IdManager]) REFERENCES [dbo].[Usuario] ([Id])
);

