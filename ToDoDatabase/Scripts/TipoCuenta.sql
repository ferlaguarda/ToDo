MERGE INTO [dbo].[TipoCuenta] AS Target
USING (
    VALUES
        (1, N'Personal'),
        (2, N'Empresa')
) AS Source (Id, Name)

ON Target.Id = Source.Id

WHEN MATCHED THEN
UPDATE SET
    Name = Source.Name

WHEN NOT MATCHED THEN
INSERT (Id, Name)
VALUES (Source.Id, Source.Name);
GO