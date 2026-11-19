CREATE TABLE [dbo].[Comentarios] (
    [Id]             INT           IDENTITY (1, 1) NOT NULL,
    [IdTarea]        INT           NOT NULL,
    [Descripcion]    VARCHAR (500) NOT NULL,
    [FechaCreacion]  DATETIME      NOT NULL,
    [Respuesta]      VARCHAR (500) NULL,
    [FechaRespuesta] DATETIME      NULL,
    [Creador]        INT           NOT NULL,
    CONSTRAINT [PK_Comentarios] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Comentarios_Tarea] FOREIGN KEY ([IdTarea]) REFERENCES [dbo].[Tarea] ([Id]),
    CONSTRAINT [FK_Comentarios_Usuario] FOREIGN KEY ([Creador]) REFERENCES [dbo].[Usuario] ([Id])
);

