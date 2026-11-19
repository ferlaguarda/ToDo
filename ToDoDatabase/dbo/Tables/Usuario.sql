CREATE TABLE [dbo].[Usuario] (
    [Id]        INT              IDENTITY (1, 1) NOT NULL,
    [Name]      VARCHAR (50)     NOT NULL,
    [Email]     VARCHAR (120)    NOT NULL,
    [Password]  VARCHAR (16)     NOT NULL,
    [AccountId] UNIQUEIDENTIFIER NULL,
    CONSTRAINT [PK_Usuario] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Usuario_Cuenta] FOREIGN KEY ([AccountId]) REFERENCES [dbo].[Cuenta] ([Id])
);

