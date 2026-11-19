MERGE INTO [dbo].[PrioridadTarea] AS Target
USING (
    VALUES
        (1, N'Baja'),
        (2, N'Media'),
        (3, N'Alta'),
        (4, N'Critica')
) AS Source (Id, Nombre)

ON Target.Id = Source.Id

WHEN MATCHED THEN
UPDATE SET
    Nombre = Source.Nombre

WHEN NOT MATCHED THEN
INSERT (Id, Nombre)
VALUES (Source.Id, Source.Nombre);
GO

