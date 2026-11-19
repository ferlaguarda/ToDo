CREATE TABLE [dbo].[Cuenta] (
    [Id]            UNIQUEIDENTIFIER NOT NULL,
    [OwnerId]       INT              NOT NULL,
    [AccountTypeId] SMALLINT         NOT NULL,
    CONSTRAINT [PK_Cuenta] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Cuenta_TipoCuenta] FOREIGN KEY ([AccountTypeId]) REFERENCES [dbo].[TipoCuenta] ([Id]),
    CONSTRAINT [FK_Cuenta_Usuario] FOREIGN KEY ([OwnerId]) REFERENCES [dbo].[Usuario] ([Id])
);

