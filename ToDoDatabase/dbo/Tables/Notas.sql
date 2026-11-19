CREATE TABLE [dbo].[Notas] (
    [Id]            INT           IDENTITY (1, 1) NOT NULL,
    [IdTarea]       INT           NULL,
    [Descripcion]   VARCHAR (MAX) NOT NULL,
    [FechaCreacion] DATETIME      NOT NULL,
    [Creador]       INT           NULL,
    CONSTRAINT [PK_Notas] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Notas_Tarea] FOREIGN KEY ([IdTarea]) REFERENCES [dbo].[Tarea] ([Id]),
    CONSTRAINT [FK_Notas_Usuario] FOREIGN KEY ([Creador]) REFERENCES [dbo].[Usuario] ([Id])
);

