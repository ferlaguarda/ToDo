CREATE TABLE [dbo].[Tarea] (
    [Id]               INT              IDENTITY (1, 1) NOT NULL,
    [AccountId]        UNIQUEIDENTIFIER NOT NULL,
    [Nombre]           VARCHAR (100)    NOT NULL,
    [Descripcion]      VARCHAR (MAX)    NULL,
    [FechaCreacion]    DATETIME         NOT NULL,
    [FechaLimite]      DATETIME         NULL,
    [DuracionEstimada] INT              NULL,
    [Responsable]      INT              NULL,
    [Prioridad]        SMALLINT         NULL,
    [Estado]           SMALLINT         NULL,
    CONSTRAINT [PK_Tarea] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Tarea_Cuenta] FOREIGN KEY ([AccountId]) REFERENCES [dbo].[Cuenta] ([Id]),
    CONSTRAINT [FK_Tarea_Estado] FOREIGN KEY ([Estado]) REFERENCES [dbo].[EstadoTarea] ([Id]),
    CONSTRAINT [FK_Tarea_Prioridad] FOREIGN KEY ([Prioridad]) REFERENCES [dbo].[PrioridadTarea] ([Id]),
    CONSTRAINT [FK_Tarea_Usuario] FOREIGN KEY ([Responsable]) REFERENCES [dbo].[Usuario] ([Id])
);

