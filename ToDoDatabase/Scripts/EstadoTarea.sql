MERGE INTO [dbo].[EstadoTarea] AS Target
USING (
    VALUES
        (1, N'Pendiente'),
        (2, N'EnCurso'),
        (3, N'Pausada'),
        (4, N'Cancelada'),
        (5, N'Finalizada'),
        (6, N'Vencida')
) AS Source (Id, Nombre)

ON Target.Id = Source.Id

WHEN MATCHED THEN
UPDATE SET
    Nombre = Source.Nombre

WHEN NOT MATCHED THEN
INSERT (Id, Nombre)
VALUES (Source.Id, Source.Nombre);
GO
