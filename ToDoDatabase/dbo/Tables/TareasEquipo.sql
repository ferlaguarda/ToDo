CREATE TABLE [dbo].[TareasEquipo] (
    [IdTarea]         INT      NOT NULL,
    [IdEquipo]        INT      NOT NULL,
    [FechaAsignacion] DATETIME NOT NULL,
    CONSTRAINT [PK_TareasEquipo] PRIMARY KEY CLUSTERED ([IdTarea] ASC, [IdEquipo] ASC),
    CONSTRAINT [FK_TareasEquipo_Equipos] FOREIGN KEY ([IdEquipo]) REFERENCES [dbo].[Equipos] ([Id]),
    CONSTRAINT [FK_TareasEquipo_Tarea] FOREIGN KEY ([IdTarea]) REFERENCES [dbo].[Tarea] ([Id])
);

