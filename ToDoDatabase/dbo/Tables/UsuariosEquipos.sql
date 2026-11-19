CREATE TABLE [dbo].[UsuariosEquipos] (
    [IdEquipo]  INT NOT NULL,
    [IdUsuario] INT NOT NULL,
    CONSTRAINT [PK_UsuariosEquipos] PRIMARY KEY CLUSTERED ([IdEquipo] ASC, [IdUsuario] ASC),
    CONSTRAINT [FK_UsuariosEquipos_Equipos] FOREIGN KEY ([IdEquipo]) REFERENCES [dbo].[Equipos] ([Id]),
    CONSTRAINT [FK_UsuariosEquipos_Usuario] FOREIGN KEY ([IdUsuario]) REFERENCES [dbo].[Usuario] ([Id])
);

